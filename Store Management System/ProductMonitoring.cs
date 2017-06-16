using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_Exam {
    public partial class ProductMonitoring : Form {
        public Start reference { get; set; }
        public MySqlConnection conn;

        bool isEditing = false;
        int Page = 1;
        bool NextPage = true;

        int Status = 100;
        int ProdID;

        public ProductMonitoring() {
            InitializeComponent();
            DetailsPNL.Location = new Point(0, 600);
            EditPNL.Location = new Point(0, 600);

            Panel2.Location = new Point(850, Panel1.Location.Y);
            Panel3.Location = new Point(850, Panel1.Location.Y);

            this.Opacity = 0;
            FadeTMR.Start();
            this.DoubleBuffered = true;
        }

        #region Form Props
        Point lastLocation;
        bool mouseDown;
        private void Drag_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }
        private void Drag_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Drag_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void FadeTMR_Tick(object sender, EventArgs e) {
            this.Opacity += 0.1;
            if (Opacity == 1) FadeTMR.Stop();
            if (DetailsPNL.Location != new Point(0, 420)) DetailsPNL.Location = new Point(DetailsPNL.Location.X, DetailsPNL.Location.Y-20);
            else reference.Hide();
        }
        private void CloseBTN_Click(object sender, EventArgs e) {
            if (isEditing) {
                DialogResult rs = MessageBox.Show("Do you really want to go back? \nAny unsaved changes will be lost.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                    this.Close();
            } else this.Close();
        }
        private void ProductMonitoring_FormClosing(object sender, FormClosingEventArgs e) {
            if (isEditing) {
                DialogResult rs = MessageBox.Show("Do you really want to go exit? \nAny unsaved changes will be lost.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes) {
                    reference.Opacity = 0;
                    reference.Location = this.Location;
                    reference.Show();
                } else e.Cancel = true;
            }
            else {
                reference.Opacity = 0;
                reference.Location = this.Location;
                reference.Show();
            }
        }
        private void ProductMonitoring_Load(object sender, EventArgs e) {
            RefreshList();
        }
        private void PanelChanageTMR_Tick(object sender, EventArgs e) {
            if (!isEditing) {
                Panel1.Enabled = false;
                Panel2.Enabled = false;
                Panel3.Enabled = false;
                Point hide = new Point(0, 600);
                Point appear = new Point(0, 420);
                if (DetailsPNL.Location != hide) { DetailsPNL.Location = new Point(0, DetailsPNL.Location.Y + 30); }
                else {
                    if (EditPNL.Location != appear) EditPNL.Location = new Point(0, EditPNL.Location.Y - 30);
                    else { PanelChangeTMR.Stop(); isEditing = true; DetailsPNL.Enabled = false; EditPNL.Enabled = true; }
                }
            }
            else {
                Panel1.Enabled = true;
                Panel2.Enabled = true;
                Panel3.Enabled = true;
                Point hide = new Point(0, 600);
                Point appear = new Point(0, 420);
                if (EditPNL.Location != hide) { EditPNL.Location = new Point(0, EditPNL.Location.Y + 30); }
                else {
                    if (DetailsPNL.Location != appear) DetailsPNL.Location = new Point(0, DetailsPNL.Location.Y - 30);
                    else { PanelChangeTMR.Stop(); isEditing = false; DetailsPNL.Enabled = true; EditPNL.Enabled = false; }
                }
            }
        }
        private void PageChangeTMR_Tick(object sender, EventArgs e) {
            Point hideLeft = new Point(-650, Panel1.Location.Y);
            Point hideRight = new Point(850, Panel1.Location.Y);
            if (Page == 1 && NextPage) {
                if (Panel1.Location != hideLeft) {
                    Panel1.Location = new Point(Panel1.Location.X - 50, Panel1.Location.Y);
                    Panel2.Location = new Point(Panel2.Location.X - 50, Panel1.Location.Y);
                }
                else {
                    PageChangeTMR.Stop();
                    Page = 2;
                    PrevBTN.Enabled = true;
                    Panel1.Enabled = false;
                    Panel2.Enabled = true;
                    Panel3.Enabled = false;
                }
            }
            else if (Page == 2 && NextPage) {
                if (Panel2.Location != hideLeft) {
                    Panel2.Location = new Point(Panel2.Location.X - 50, Panel1.Location.Y);
                    Panel3.Location = new Point(Panel3.Location.X - 50, Panel1.Location.Y);
                }
                else {
                    PageChangeTMR.Stop();
                    Page = 3;
                    NextBTN.Enabled = false;
                    Panel1.Enabled = false;
                    Panel2.Enabled = false;
                    Panel3.Enabled = true;
                }
            }
            else if (Page == 3 && !NextPage) {
                if (Panel3.Location != hideRight) {
                    Panel2.Location = new Point(Panel2.Location.X + 50, Panel1.Location.Y);
                    Panel3.Location = new Point(Panel3.Location.X + 50, Panel1.Location.Y);
                }
                else {
                    PageChangeTMR.Stop();
                    Page = 2;
                    NextBTN.Enabled = true;
                    Panel1.Enabled = false;
                    Panel2.Enabled = true;
                    Panel3.Enabled = false;
                }
            }
            else if (Page == 2 && !NextPage) {
                if (Panel2.Location != hideRight) {
                    Panel2.Location = new Point(Panel2.Location.X + 50, Panel1.Location.Y);
                    Panel1.Location = new Point(Panel1.Location.X + 50, Panel1.Location.Y);
                }
                else {
                    PageChangeTMR.Stop();
                    Page = 1;
                    PrevBTN.Enabled = false;
                    Panel1.Enabled = true;
                    Panel2.Enabled = false;
                    Panel3.Enabled = false;
                }
            }
        }
        #endregion

        #region Main Area
        private void RefreshList() {
            try {
                DataGridView dg=SchoolGrid;
                for (int i = 1; i < 10; i++) {
                    if (i == 1) dg = SchoolGrid;
                    else if (i == 2) dg = OfficeGrid;
                    else if (i == 3) dg = FoodGrid;
                    else if (i == 4) dg = BeverageGrid;
                    else if (i == 5) dg = HardwareGrid;
                    else if (i == 6) dg = KitchenwareGrid;
                    else if (i == 7) dg = PersonalGrid;
                    else if (i == 8) dg = CarGrid;
                    else if (i == 9) dg = ConstructionGrid;
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT PID, name, FORMAT(price,2) AS price, prodtype, status FROM products WHERE ProdType =" + i, conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dg.DataSource = dt;
                    dg.Columns["PID"].Visible = false;
                    dg.Columns["name"].HeaderText = "NAME";
                    dg.Columns["name"].Width = 135;
                    dg.Columns["price"].Visible = false;
                    dg.Columns["prodtype"].Visible = false;
                    dg.Columns["status"].HeaderText = "STATUS";
                    dg.Columns["status"].Width = 65;
                    conn.Close();
                    dg.ClearSelection();
                }
            }
            catch { conn.Close(); MessageBox.Show("Error in List."); }
        }
        private void NextBTN_Click(object sender, EventArgs e) {
            NextPage = true;
            PageChangeTMR.Start();
        }
        private void PrevBTN_Click(object sender, EventArgs e) {
            NextPage = false;
            PageChangeTMR.Start();
        }
        private void DataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex == 4) {
                if (e.Value is int) {
                    int value = (int)e.Value;
                    if (value == 1) {
                        e.Value = "Available";
                    }
                    else if (value == 2) {
                        e.Value = "Not Available";
                    }
                    e.FormattingApplied = true;
                }
            }
        }
        private void SchoolGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            changeName(e, SchoolGrid);
            ClearSelect(1);
        }
        private void OfficeGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            changeName(e, OfficeGrid);
            ClearSelect(2);
        }
        private void FoodGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            changeName(e, FoodGrid);
            ClearSelect(3);
        }
        private void BeverageGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            changeName(e, BeverageGrid);
            ClearSelect(4);
        }
        private void HardwareGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            changeName(e, HardwareGrid);
            ClearSelect(5);
        }
        private void KitchenwareGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            changeName(e, KitchenwareGrid);
            ClearSelect(6);
        }
        private void PersonalGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            changeName(e, PersonalGrid);
            ClearSelect(7);
        }
        private void CarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            changeName(e, CarGrid);
            ClearSelect(8);
        }
        private void ConstructionGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            changeName(e, ConstructionGrid);
            ClearSelect(9);
        }
        private void changeName(DataGridViewCellEventArgs e, DataGridView d) {
            if (isEditing) PanelChangeTMR.Start();
            DeleteBTN.Enabled = true;
            EditBTN.Enabled = true;
            try {
                ProductNameBX.Text = d.Rows[e.RowIndex].Cells[1].Value.ToString();
                PriceBX.Text = d.Rows[e.RowIndex].Cells[2].Value.ToString();
                TypeBox.SelectedIndex = int.Parse(d.Rows[e.RowIndex].Cells[3].Value.ToString());

                NameLBL.Text = ProductNameBX.Text;
                PriceLBL.Text = "₱ " + PriceBX.Text;
                TypeLBL.Text = TypeBox.Text;

                ProdID = int.Parse(d.Rows[e.RowIndex].Cells[0].Value.ToString());
                Status = int.Parse(d.Rows[e.RowIndex].Cells[4].Value.ToString());
                if (d.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("1")) {
                    AvailableBTN.Checked = true;
                    UnavailableBTN.Checked = false;
                    StatusLBL.Text = "Available";
                }
                else {
                    AvailableBTN.Checked = false;
                    UnavailableBTN.Checked = true;
                    StatusLBL.Text = "Not Available";
                }
            }
            catch { }

        }
        private void ClearSelect(int i) {
            if (i != 1) SchoolGrid.ClearSelection();
            if (i != 2) OfficeGrid.ClearSelection();
            if (i != 3) FoodGrid.ClearSelection();
            if (i != 4) BeverageGrid.ClearSelection();
            if (i != 5) HardwareGrid.ClearSelection();
            if (i != 6) KitchenwareGrid.ClearSelection();
            if (i != 7) PersonalGrid.ClearSelection();
            if (i != 8) CarGrid.ClearSelection();
            if (i != 9) ConstructionGrid.ClearSelection();
        }
        #endregion

        #region Details Area
        private void AddNewBTN_Click(object sender, EventArgs e) {
            ClearBoxes();
            CreateBTN.Text = "ADD";
            PanelChangeTMR.Start();
        }
        private void DeleteBTN_Click(object sender, EventArgs e) {
            DialogResult rs = MessageBox.Show("Are you sure you want to delete "+ProductNameBX.Text, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) {
                try {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("DELETE FROM products WHERE PID = '" + ProdID + "'", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    ClearBoxes();
                    RefreshList();
                }
                catch (Exception ee) {
                    conn.Close();
                    MessageBox.Show("Product is currently included in a transaction.");
                }
            }
        }
        private void EditBTN_Click(object sender, EventArgs e) {
            PanelChangeTMR.Start();
            CreateBTN.Text = "UPDATE";
        }
        private void BackBTN_Click(object sender, EventArgs e) {
            DialogResult rs = MessageBox.Show("Do you really want to go back? \nAny unsaved changes will be lost.", "Stop Editing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) PanelChangeTMR.Start();
            ClearBoxes();
        }
        private void CreateBTN_Click(object sender, EventArgs e) {
            if (CreateBTN.Text.Equals("ADD")) {
                if (ProductNameBX.Text.Equals("") ||
                    PriceBX.Text.Equals("") ||
                    TypeBox.SelectedIndex == 0 ||
                    !double.TryParse(PriceBX.Text, out heh) ||
                    Status == 100) {
                    if (!double.TryParse(PriceBX.Text, out heh)) MessageBox.Show("Input a valid price.");
                    else MessageBox.Show("Please supply all information");
                }
                else {
                    try {
                        conn.Open();
                        try {
                            MySqlCommand comm = new MySqlCommand("INSERT INTO Products(name, price, prodtype, status) VALUES('" + ProductNameBX.Text + "','" + PriceBX.Text + "','" + TypeBox.SelectedIndex + "','" + Status + "')", conn);
                            comm.ExecuteNonQuery();
                            PanelChangeTMR.Start();
                            conn.Close();
                            RefreshList();
                            ClearBoxes();
                        }
                        catch (Exception ee) {
                            conn.Close();
                            MessageBox.Show("Please check your input.");
                            
                        }
                    }
                    catch (Exception ee) {
                        conn.Close();
                        MessageBox.Show("Please check your input.");
                    }
                }
            }
            else {
                if (ProductNameBX.Text.Equals("") ||
                    PriceBX.Text.Equals("") ||
                    TypeBox.SelectedIndex == 0 ||
                    !double.TryParse(PriceBX.Text, out heh) ||
                    Status == 100) {
                    if (!double.TryParse(PriceBX.Text, out heh)) MessageBox.Show("Input a valid price.");
                    else MessageBox.Show("Please supply all information");
                }
                else {
                    try {
                        conn.Open();
                        MySqlCommand comm = new MySqlCommand("UPDATE Products SET name = '" + ProductNameBX.Text + "', price='" + PriceBX.Text + "', prodtype='" + TypeBox.SelectedIndex + "', status ='" + Status + "' WHERE PID = '" + ProdID + "'", conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        PanelChangeTMR.Start();
                        ClearBoxes();
                        RefreshList();
                        CreateBTN.Text = "ADD";
                    }
                    catch (Exception ee) {
                        conn.Close();
                        MessageBox.Show("Please check your input.");
                    }
                }
            }
        }
        private void AvailableBTN_CheckedChanged(object sender, EventArgs e) {
            Status = 1;
        }
        private void UnavailableBTN_CheckedChanged(object sender, EventArgs e) {
            if (UnavailableBTN.Checked) {
                if (CheckIfIncluded()) {
                    UnavailableBTN.Checked = false; AvailableBTN.Checked = true;
                } else  Status = 2;
            }
        }
        private bool CheckIfIncluded() {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM OrderLine JOIN Transactions ON OTID = tid WHERE (transactions.status = 1 OR transactions.status = 2 OR transactions.status = 4 OR transactions.status = 6) AND  OPID = " + ProdID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0) { MessageBox.Show("The product is currently included in an ongoing transaction"); return true; }
                else return false;
            }
            catch (Exception ee) {
                conn.Close();
                return false;
            }
        }
        private void ClearBoxes() {
            ProductNameBX.Text = "";
            PriceBX.Text = "";
            TypeBox.SelectedIndex = 0;
            AvailableBTN.Checked = false;
            UnavailableBTN.Checked = false;
            NameLBL.Text = "Product Details";
            PriceLBL.Text = "Select a product from list";
            TypeLBL.Text = ".";
            StatusLBL.Text = "";
            DeleteBTN.Enabled = false;
            EditBTN.Enabled = false;
            ClearSelect(10);
        }
        #endregion

        private void SearchBX_Enter(object sender, EventArgs e) {
            if (SearchBX.Text.Equals("Search or filter result.")) {
                SearchBX.Clear();
                SearchBX.Font = PriceBX.Font;
                SearchLine.Visible = true;
            }
        }

        private void SearchBX_Leave(object sender, EventArgs e) {
            if (SearchBX.Text.Equals("")) {
                SearchBX.Text = "Search or filter result.";
                SearchBX.Font = SearchLBL.Font;
                SearchLine.Visible = false;
                RefreshList();
            }
     
        }

        private void SearchBX_TextChanged(object sender, EventArgs e) {
            try {
                DataGridView dg = SchoolGrid;
                for (int i = 1; i < 10; i++) {
                    if (i == 1) dg = SchoolGrid;
                    else if (i == 2) dg = OfficeGrid;
                    else if (i == 3) dg = FoodGrid;
                    else if (i == 4) dg = BeverageGrid;
                    else if (i == 5) dg = HardwareGrid;
                    else if (i == 6) dg = KitchenwareGrid;
                    else if (i == 7) dg = PersonalGrid;
                    else if (i == 8) dg = CarGrid;
                    else if (i == 9) dg = ConstructionGrid;
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT PID, name, FORMAT(price,2) as price, prodtype, status FROM products WHERE (name LIKE '%" + SearchBX.Text+ "%' OR name LIKE '" + SearchBX.Text + "%' OR name LIKE '%" + SearchBX.Text + "') AND ProdType=" + i, conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    
                    conn.Close();
                    adp.Fill(dt);
                    dg.DataSource = dt;
                    dg.Columns["PID"].Visible = false;
                    dg.Columns["name"].HeaderText = "NAME";
                    dg.Columns["name"].Width = 135;
                    dg.Columns["price"].Visible = false;
                    dg.Columns["prodtype"].Visible = false;
                    dg.Columns["status"].HeaderText = "STATUS";
                    dg.Columns["status"].Width = 65;
                    dg.ClearSelection();
                }
            }
            catch { conn.Close(); MessageBox.Show("Please enter a valid name."); }
        }

        private void PriceBX_KeyDown(object sender, KeyEventArgs e) {
            if (!(e.KeyCode.ToString().Equals("D0") ||
              e.KeyCode.ToString().Equals("D1") ||

              e.KeyCode.ToString().Equals("NumPad0") ||
              e.KeyCode.ToString().Equals("NumPad1") ||
              e.KeyCode.ToString().Equals("NumPad2") ||
              e.KeyCode.ToString().Equals("NumPad3") ||
              e.KeyCode.ToString().Equals("NumPad4") ||
              e.KeyCode.ToString().Equals("NumPad5") ||
              e.KeyCode.ToString().Equals("NumPad6") ||
              e.KeyCode.ToString().Equals("NumPad7") ||
              e.KeyCode.ToString().Equals("NumPad8") ||
              e.KeyCode.ToString().Equals("NumPad9") ||

              e.KeyCode.ToString().Equals("D2") ||
              e.KeyCode.ToString().Equals("D3") ||
              e.KeyCode.ToString().Equals("D4") ||
              e.KeyCode.ToString().Equals("D5") ||
              e.KeyCode.ToString().Equals("D6") ||
              e.KeyCode.ToString().Equals("D7") ||
              e.KeyCode.ToString().Equals("D8") ||
               e.KeyCode.ToString().Equals("Back") ||
               e.KeyCode.ToString().Equals("OemPeriod") ||
              e.KeyCode.ToString().Equals("D9"))
              ) {
                e.SuppressKeyPress = true;
            }
        }
        double heh;
        private void PriceBX_TextChanged(object sender, EventArgs e) {
            if (PriceBX.TextLength > 9) {
                PriceBX.Clear();
                MessageBox.Show("Please enter a valid price.");
            }
        }

        private void ProductNameBX_TextChanged(object sender, EventArgs e) {
            if (ProductNameBX.TextLength > 50) {
                MessageBox.Show("Product name is too long", "Invalid Product Name");
                ProductNameBX.Clear();
            }
        }
    }
}
