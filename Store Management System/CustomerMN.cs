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
    public partial class CustomerMN : Form {
        public Start reference { get; set; }
        public MySqlConnection conn;

        int Status = 100;
        int AccountID;
        public int UserID;

        bool isEditing = false;

        public CustomerMN() {
            InitializeComponent();
            DetailsPNL.Location = new Point(-400, 0);
            GridPNL.Location = new Point(-400, 0);
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
        private void UserMN_Load(object sender, EventArgs e) {
            Rifrish();
            UsersDataGrid.ClearSelection();
        }
        private void CloseBTN_Click(object sender, EventArgs e) {
            if (isEditing) {
                DialogResult rs = MessageBox.Show("Do you really want to go back? \nAny unsaved changes will be lost.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes) this.Close();
            }
            else this.Close();
        }
        private void FadeTMR_Tick(object sender, EventArgs e) {
            this.Opacity += 0.1;
            if (this.Opacity == 1) FadeTMR.Stop();
            if (DetailsPNL.Location != new Point(0, 0)) DetailsPNL.Location = new Point(DetailsPNL.Location.X + 50, GridPNL.Location.Y);
            else reference.Hide();

        }
        private void UserMN_FormClosing(object sender, FormClosingEventArgs e) {
            if (isEditing) {
                DialogResult rs = MessageBox.Show("Do you really want to go exit? \nAny unsaved changes will be lost.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes) {
                    reference.Opacity = 0;
                    reference.Location = this.Location;
                    reference.Show();
                }
                else e.Cancel = true;
            }
            else {
                reference.Opacity = 0;
                reference.Location = this.Location;
                reference.Show();
            }
        }
        private void EditDetailsBTN_Click(object sender, EventArgs e) {
            PanelChangeTMR.Start();
        }
        private void PanelChangeTMR_Tick(object sender, EventArgs e) {
            if (!isEditing) {
                UsersDataGrid.Enabled = false;
                SearchBX.Enabled = false;
                Point hide = new Point(-400, 0);
                Point appear = new Point(0, 0);
                if (DetailsPNL.Location != hide) { DetailsPNL.Location = new Point(DetailsPNL.Location.X - 50, 0); }
                else {
                    if (GridPNL.Location != appear) GridPNL.Location = new Point(GridPNL.Location.X + 50, 0);
                    else { PanelChangeTMR.Stop(); isEditing = true; DetailsPNL.Enabled = false; GridPNL.Enabled = true; }
                }
            }
            else {
                UsersDataGrid.Enabled = true;
                SearchBX.Enabled = true;
                Point hide = new Point(-400, 0);
                Point appear = new Point(0, 0);
                if (GridPNL.Location != hide) { GridPNL.Location = new Point(GridPNL.Location.X - 50, 0); }
                else {
                    if (DetailsPNL.Location != appear) DetailsPNL.Location = new Point(DetailsPNL.Location.X + 50, 0);
                    else { PanelChangeTMR.Stop(); isEditing = false; DetailsPNL.Enabled = true; GridPNL.Enabled = false; }
                }
            }
        }
        #endregion

        #region Details Panel
        private void ClearBoxes() {
            FNBox.Text = String.Empty;
            MNBox.Text = String.Empty;
            LNBox.Text = String.Empty;
            AddressBX.Text = String.Empty;
            ContactBX.Text = String.Empty;
            ActiveBTN.Checked = false;
            InactiveBTN.Checked = false;
            LNLBL.Text = "Details";
            FNMNLBL.Text = "Select a user from the table";
            AddressLBL.Text = ".";
            ContactLBL.Text = ".";
            StatusLBL.Text = ".";
            DeleteBTN.Enabled = false;
            EditDetailsBTN.Enabled = false;
        }
        private void ActiveBTN_CheckedChanged(object sender, EventArgs e) {
            if (ActiveBTN.Checked) Status = 1;
        }
        private void InactiveBTN_CheckedChanged(object sender, EventArgs e) {
            if (InactiveBTN.Checked) {
                if (CheckIfIncluded()) { InactiveBTN.Checked = false; ActiveBTN.Checked = true; }
                else Status = 2;
            }
        }
        private bool CheckIfIncluded () {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM transactions WHERE (status = 1 OR status = 2 OR status = 4 OR status = 6) AND  TCID = " + AccountID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0) { MessageBox.Show("The customer is currently included in an ongoing transaction"); return true; }
                else return false;
            }
            catch (Exception ee) {
                conn.Close();
                return false;
            }
        }
        private void AddBTN_Click(object sender, EventArgs e) {
            ClearBoxes();
            PanelChangeTMR.Start();
            CreateBTN.Text = "ADD";
            UsersDataGrid.ClearSelection();
        }
        private void CreateBTN_Click(object sender, EventArgs e) {
            if (CreateBTN.Text.Equals("ADD")) {
                if (FNBox.Text.Equals("") ||
                    MNBox.Text.Equals("") ||
                    LNBox.Text.Equals("") ||
                    AddressBX.Text.Equals("") ||
                    ContactBX.Text.Equals("") ||
                    Status == 100) MessageBox.Show("Please supply all information.");
                else {
                    try {
                        conn.Open();
                        MySqlCommand comm = new MySqlCommand("INSERT INTO Customer(fn, mn, ln, address , status, contact) VALUES('" + FNBox.Text + "','" + MNBox.Text + "','" + LNBox.Text + "','" + AddressBX.Text + "','" + Status + "','" + ContactBX.Text + "')", conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        UpdateBoxes();
                        PanelChangeTMR.Start();
                        Rifrish();
                        ClearBoxes();
                        UsersDataGrid.ClearSelection();
                    }
                    catch (Exception ee) {
                        conn.Close();
                        MessageBox.Show(ee.Message);
                    }
                }
            }
            else {
                if (FNBox.Text.Equals("") ||
                    MNBox.Text.Equals("") ||
                    LNBox.Text.Equals("") ||
                    AddressBX.Text.Equals("") ||
                    ContactBX.Text.Equals("") ||
                    Status == 100) {
                    MessageBox.Show("Please supply all information.");
                }
                else {
                    try {
                        conn.Open();
                        MySqlCommand comm = new MySqlCommand("UPDATE Customer SET fn = '" + FNBox.Text + "', mn='" + MNBox.Text + "', ln='" + LNBox.Text + "', address ='" + AddressBX.Text + "', status='" + Status + "',contact='" + ContactBX.Text + "' WHERE CID = '" + AccountID + "'", conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        UpdateBoxes();
                        PanelChangeTMR.Start();
                        ClearBoxes();
                        Rifrish();
                        CreateBTN.Text = "ADD";
                        UsersDataGrid.ClearSelection();
                    }
                    catch (Exception ee) {
                        conn.Close();
                        MessageBox.Show("Please check your input");
                    }
                }
            }
        }
        private void GoBackBTN_Click(object sender, EventArgs e) {
            DialogResult rs = MessageBox.Show("Cancel Chnages? \nAny unsaved changes will be lost.", "Stop Editing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) PanelChangeTMR.Start();
            ClearBoxes();
        }
        private void DeleteBTN_Click(object sender, EventArgs e) {
            DialogResult rs = MessageBox.Show("Delete "+LNLBL.Text +", "+FNMNLBL.Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) {
                try {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("DELETE FROM Customer WHERE CID=" + AccountID, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    Rifrish();
                    ClearBoxes();
                }
                catch (Exception ee) {
                    conn.Close();
                    MessageBox.Show(LNLBL.Text + ", " + FNMNLBL.Text + " currently has a transaction.");
                }
            }
        }
        #endregion

        #region Main Panel
        private void Rifrish() {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM customer", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                UsersDataGrid.DataSource = dt;
                UsersDataGrid.Columns["cid"].Visible = false;
                UsersDataGrid.Columns["fn"].HeaderText = "FIRST";
                UsersDataGrid.Columns["fn"].Width = 80;
                UsersDataGrid.Columns["mn"].HeaderText = "MIDDLE";
                UsersDataGrid.Columns["mn"].Width = 80;
                UsersDataGrid.Columns["ln"].HeaderText = "LAST";
                UsersDataGrid.Columns["ln"].Width = 80;
                UsersDataGrid.Columns["address"].Visible = false;
                UsersDataGrid.Columns["status"].HeaderText = "STATUS";
                UsersDataGrid.Columns["status"].Width = 90;
                UsersDataGrid.Columns["contact"].Visible = false;
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
                MessageBox.Show(ee.Message);
            }
        }
        private void UpdateBoxes() {
            LNLBL.Text = LNBox.Text;
            FNMNLBL.Text = FNBox.Text + " " + MNBox.Text;
            AddressLBL.Text = AddressBX.Text;
            ContactLBL.Text = ContactBX.Text;
            if (Status == 1) {
                StatusLBL.Text = "Active";
            } else StatusLBL.Text = "Inactive";

        }
        private void UsersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            DeleteBTN.Enabled = true;
            EditDetailsBTN.Enabled = true;
            if (isEditing) PanelChangeTMR.Start();
            try {
                FNBox.Text = UsersDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                MNBox.Text = UsersDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                LNBox.Text = UsersDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                 AddressBX.Text = UsersDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                ContactBX.Text = UsersDataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                AccountID = int.Parse(UsersDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                UpdateBoxes();
                if (UsersDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString().Equals("1")) {
                    ActiveBTN.Checked = true;
                    InactiveBTN.Checked = false;
                    StatusLBL.Text = "Active";
                }
                else {
                    ActiveBTN.Checked = false;
                    InactiveBTN.Checked = true;
                    StatusLBL.Text = "Inactive";
                }
                CreateBTN.Text = "UPDATE";
                DeleteBTN.Enabled = true;
            }
            catch {
            }
        }
        private void UsersDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex == 5) {
                if (e.Value is int) {
                    int value = (int)e.Value;
                    if (value == 1) {
                        e.Value = "Active";
                    }
                    else if (value == 2) {
                        e.Value = "Inactive";
                    }
                    e.FormattingApplied = true;
                }
            }
        }
        #endregion

        private void SearchBX_TextChanged(object sender, EventArgs e) {
            if (!SearchBX.Text.Equals(String.Empty)) {
                try {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT * FROM customer WHERE CONCAT(fn,' ',mn,' ',ln) LIKE '%" + SearchBX.Text + "%' OR CONCAT(fn,' ',mn,' ',ln) LIKE '" + SearchBX.Text + "%' OR CONCAT(fn,' ',mn,' ',ln) LIKE '%" + SearchBX.Text+"'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    UsersDataGrid.DataSource = dt;
                    UsersDataGrid.Columns["cid"].Visible = false;
                    UsersDataGrid.Columns["fn"].HeaderText = "FIRST";
                    UsersDataGrid.Columns["fn"].Width = 80;
                    UsersDataGrid.Columns["mn"].HeaderText = "MIDDLE";
                    UsersDataGrid.Columns["mn"].Width = 80;
                    UsersDataGrid.Columns["ln"].HeaderText = "LAST";
                    UsersDataGrid.Columns["ln"].Width = 80;
                    UsersDataGrid.Columns["address"].Visible = false;
                    UsersDataGrid.Columns["status"].HeaderText = "STATUS";
                    UsersDataGrid.Columns["status"].Width = 90;
                    UsersDataGrid.Columns["contact"].Visible = false;
                    conn.Close();
                }
                catch (Exception ee) {
                    conn.Close();
                    MessageBox.Show("Please enter a valid customer name.");
                }
            }
            else Rifrish();
        }

        private void SearchBX_Enter(object sender, EventArgs e) {
            if (SearchBX.Text.Equals("Search or filter result.")) {
                SearchBX.Clear();
                SearchBX.Font = FNBox.Font;
                SearchBX.TextAlign = HorizontalAlignment.Left;
                SearchLine.Visible = true;
            }
        }

        private void SearchBX_Leave(object sender, EventArgs e) {
            if (SearchBX.Text.Equals("")) {
                SearchBX.Text = "Search or filter result.";
                SearchBX.Font = SearchLBL.Font;
                SearchBX.TextAlign = HorizontalAlignment.Center;
                SearchLine.Visible = false;
                Rifrish();
            }
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

        private void ContactBX_TextChanged(object sender, EventArgs e) {
            if (ContactBX.TextLength > 11) { MessageBox.Show("Please enter a valid number \nor change the format from +639** to 09**"); }
        }
    }
}
