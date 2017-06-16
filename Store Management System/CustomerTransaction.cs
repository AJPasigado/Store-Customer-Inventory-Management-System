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
    public partial class CustomerTransaction : Form {
        public Start reference { get; set; }
        public MySqlConnection conn;
        public int UserID;
        public int CID = -1 ;
        public int PID;
        public int TID;

        public bool Add = false;

        public CustomerTransaction() {
            InitializeComponent();
            DetailsPNL.Location = new Point(1250, 0);
            this.Opacity = 0;
            FadeTMR.Start();
            this.DoubleBuffered = true;
        }

        #region Form Properties
        private void CustomerTransaction_Load(object sender, EventArgs e) {
            RefreshOrders();
        }
        private void FadeTMR_Tick(object sender, EventArgs e) {
            this.Opacity += 0.1;
            if (DetailsPNL.Location != new Point(450, 0)) DetailsPNL.Location = new Point(DetailsPNL.Location.X - 50, DetailsPNL.Location.Y);
            else { reference.Hide(); FadeTMR.Stop(); }
        }
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
        private void PanelChangeTMR_Tick(object sender, EventArgs e) {
            EditPNL.Enabled = true;
            MainPNL.Enabled = true;
            if (!isEditing) {
                Point showPanel = new Point(0, 0);
                if (EditPNL.Location != showPanel) {
                    EditPNL.Location = new Point(EditPNL.Location.X - 50, EditPNL.Location.Y);
                    MainPNL.Location = new Point(MainPNL.Location.X - 50, MainPNL.Location.Y);
                }
                else {
                    PanelChangeTMR.Stop();
                    isEditing = true;
                    MainPNL.Enabled = false;
                    EditPNL.Enabled = true;
                    EditItemBTN.Enabled = false;
                    RemoveItemBTN.Enabled = false;
                }
            }
            else {
                Point hidePanel = new Point(0, 0);
                if (MainPNL.Location != hidePanel) {
                    EditPNL.Location = new Point(EditPNL.Location.X + 50, EditPNL.Location.Y);
                    MainPNL.Location = new Point(MainPNL.Location.X + 50, MainPNL.Location.Y);
                }
                else {
                    PanelChangeTMR.Stop();
                    isEditing = false;
                    MainPNL.Enabled = true;
                    EditPNL.Enabled = false;
                }
            }
        }
        private void CustomerTransaction_FormClosing(object sender, FormClosingEventArgs e) {
            if (MainPNL.Location != new Point(0, 0)) {
                e.Cancel = true;
                PanelChangeTMR.Start();
            }else {
                reference.Opacity = 0;
                reference.Location = this.Location;
                reference.Show();
            }
        }
        private void CloseBTN_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion

        #region Main Page
        private void RefreshOrders() {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT tid, CONCAT(customer.ln, ', ', customer.fn, ' ', customer.mn) AS Customer, dateentry , Transactions.status, cid FROM transactions JOIN customer on TCID=cid JOIN Assignment ON Atid = tid WHERE AEID="+UserID+" ORDER BY tid desc", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                OrdersGrid.DataSource = dt;
                OrdersGrid.Columns["tid"].HeaderText = "NO.";
                OrdersGrid.Columns["tid"].Width = 50;
                OrdersGrid.Columns["customer"].HeaderText = "CUSTOMER";
                OrdersGrid.Columns["customer"].Width = 190;
                OrdersGrid.Columns["dateentry"].HeaderText = "DATE";
                OrdersGrid.Columns["dateentry"].Width = 90;
                OrdersGrid.Columns["status"].HeaderText = "STATUS";
                OrdersGrid.Columns["status"].Width = 80;
                OrdersGrid.Columns["cid"].Visible = false;
                conn.Close();
                UpdateDetails();
            }
            catch (Exception ee) {
                conn.Close();
                MessageBox.Show(ee.Message);
                
            }
        }
        private void UsersDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex == 3) {
                if (e.Value is int) {
                    int value = (int)e.Value;
                    if (value == 1) {
                        e.Value = "Pending";
                    }
                    else if (value == 2) {
                        e.Value = "Waiting";
                    }
                    else if (value == 3) {
                        e.Value = "Delivered";
                    }
                    else if (value == 4) {
                        e.Value = "Open";
                    }
                    else if (value == 5) {
                        e.Value = "Cancelled";
                    }
                    else if (value == 6) {
                        e.Value = "Delivering";
                    }
                    else e.Value = "Completed";
                    e.FormattingApplied = true;
                }
            }
        }
        int transactionType;
        private void OrdersGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            ViewDetailsBTN.Enabled = true;
            CancelBTN.Enabled = true;
            try {
                TransactionDetails.Text = OrdersGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                DateDetails.Text = OrdersGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                CustomerLBL.Text = OrdersGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                TID = int.Parse(OrdersGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                CID = int.Parse(OrdersGrid.Rows[e.RowIndex].Cells[4].Value.ToString());
                transactionType = int.Parse(OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("1")) StatusDetails.Text = "Pending";
                else if (OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("2")) StatusDetails.Text = "Waiting for approval...";
                else if (OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("3")) StatusDetails.Text = "Delivered";
                else if (OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("4")) StatusDetails.Text = "Open";
                else if (OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("5")) StatusDetails.Text = "Cancelled";
                else if (OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("6")) StatusDetails.Text = "Delivering";
                else if (OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("7")) StatusDetails.Text = "Completed";
            }
            catch {}
            ApproveBTN.Visible = false;
            DenyBTN.Visible = false;
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT CONCAT(employees.ln, ', ', employees.fn, ' ', employees.mn) AS POST FROM employees JOIN assignment ON AEID=EID JOIN transactions ON ATID=TID WHERE atype=2 AND TID=" + TID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable dt = new DataTable();
                adp.Fill(dt);
                RunnerStaffDetails.Text = dt.Rows[0][0].ToString();
                if (transactionType == 2) { ApproveBTN.Visible = true; DenyBTN.Visible = true; }
            }
            catch (Exception ee) {
                RunnerStaffDetails.Text = "Unassigned";
                conn.Close();
            }

            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT FORMAT(SUM(price*quantity),2) AS SUM FROM products INNER JOIN Orderline ON pid=opid WHERE otid=" + TID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable dt = new DataTable();
                adp.Fill(dt);
                PriceDetails.Text = dt.Rows[0][0].ToString();
                
            } catch (Exception ee) {
                PriceDetails.Text = "00.00";
                conn.Close();
            }
            UpdateDetails();
        }
        private void ApproveBTN_Click(object sender, EventArgs e) {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("UPDATE Transactions SET status = 6 WHERE TID =" + TID, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                PanelChangeTMR.Start();
                RefreshOrders();
            }
            catch (Exception ee) {
                conn.Close();
            }
        }
        private void UpdateDetails() {
            TransactionLBL.Text = "Transaction #" + TransactionDetails.Text;
            RunnerLBL.Text = RunnerStaffDetails.Text;
            PriceLBL.Text = PriceDetails.Text;
            DateLBL.Text = DateDetails.Text;
            StatLBL.Text = StatusDetails.Text;
            
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT SUM(quantity) AS SUM FROM products INNER JOIN Orderline ON pid=opid WHERE otid=" + TID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                QuantityLBL.Text = dt.Rows[0][0].ToString() + " items";
                conn.Close();
            }
            catch (Exception ee) {
                QuantityLBL.Text = "0 items";
                conn.Close();
            }
            CancelBTN.Visible = true;
            DeleteBTN.Visible = true;
            PaidBTN.Visible = false;
            DeliveredBTN.Visible = false;
            if (transactionType > 2) CancelBTN.Visible = false;
            if (transactionType == 6) DeleteBTN.Visible = false;
            if (transactionType == 3) PaidBTN.Visible = true;
            if (transactionType == 6) DeliveredBTN.Visible = true;
            if (transactionType != 4) {
                AddItemBTN.Visible = false;
                EditItemBTN.Visible = false;
                RemoveItemBTN.Visible = false;
                CheckoutBTN.Visible = false;
            }
            else {
                AddItemBTN.Visible = true;
                EditItemBTN.Visible = true;
                RemoveItemBTN.Visible = true;
                CheckoutBTN.Visible = true;
            }
            
            RefreshProductOrder();
            ProductsGrid.ClearSelection();
        }
        bool isEditing = false;
        private void EditDetailsBTN_Click(object sender, EventArgs e) {
            Add = false;
            PanelChangeTMR.Start();
        }
        private void CancelBTN_Click(object sender, EventArgs e) {
            DialogResult rs = MessageBox.Show("Are you sure you want to cancel?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) {
                try {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("UPDATE Transactions SET status = 5 WHERE TID =" + TID, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    if (!(MainPNL.Location == new Point (0,0)))PanelChangeTMR.Start();
                    RefreshOrders();
                }
                catch (Exception ee) {
                    conn.Close();
                }
                RefreshOrders();
            }
        }
        #endregion

        #region Customer Popup/ Add new Transaction
        public bool ispop;
        private void AddBTN_Click(object sender, EventArgs e) {
            PopupCustomer pop = new PopupCustomer();
            MainPNL.Enabled = false;
            PopupTMR.Start();
            ispop = true;
            Add = false;
            pop.reference = this;
            pop.conn = this.conn;
            pop.Location = new Point(this.Location.X + 200, this.Location.Y);
            pop.Show();
        }
        private void PopupTMR_Tick(object sender, EventArgs e) {
            OrdersGrid.ClearSelection();
            if (ispop && this.Opacity > 0.6) this.Opacity -= 0.2;
            if (!ispop) this.Opacity += 0.2;
            if (this.Opacity == 1) {
                PopupTMR.Stop();
                MainPNL.Enabled = true;
            }
        }
        public void LoadNewDetailsPage() {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM customer WHERE cid = " + CID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                CustomerLBL.Text = dt.Rows[0]["ln"].ToString() + ", " + dt.Rows[0]["fn"].ToString() + " " + dt.Rows[0]["mn"].ToString();
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
                MessageBox.Show("Problem in loading new page.");
               
            }
            DateLBL.Text = DateTime.Now.ToShortDateString();
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("INSERT INTO Transactions(DateEntry, TCID, Status) VALUES('"+DateLBL.Text+"','"+CID+"','4')", conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
                MessageBox.Show("Problem in loading new page.");
            }
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT Tid FROM Transactions ORDER BY tid ASC", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                TID = int.Parse(dt.Rows[dt.Rows.Count-1][0].ToString());
                TransactionLBL.Text = "Transaction #"+TID;
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
                MessageBox.Show("Problem in loading new page.");
            }
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("INSERT INTO Assignment(Atype, AEID, ATID) VALUES('" + 1 + "','" + UserID + "','"+TID+"')", conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
                MessageBox.Show("Problem in loading new page.");
            }
            RefreshOrders();
            PanelChangeTMR.Start();
            RefreshProductOrder();
            StatLBL.Text = "Open";
            QuantityLBL.Text = "0 Items";
            PriceLBL.Text = "00.00";
            RemoveItemBTN.Enabled = false;
            EditItemBTN.Enabled = false;
            AddItemBTN.Visible = true;
            EditItemBTN.Visible = true;
            RemoveItemBTN.Visible = true;
            CheckoutBTN.Visible = true;
        }
        #endregion

        #region Add Item
        private void AddItemBTN_Click(object sender, EventArgs e) {
            PopupItem itm = new PopupItem();
            EditPNL.Enabled = false;
            ItemTMR.Start();
            itempop = true;
            itm.TID = this.TID;
            itemadd = false;
            itm.Location = new Point(this.Location.X + 200, this.Location.Y);
            itm.reference = this;
            itm.conn = this.conn;
            itm.Show();
        }
        public bool itempop = false;
        public bool itemadd;
        private void ItemTMR_Tick(object sender, EventArgs e) {
            if (itempop && this.Opacity > 0.6) this.Opacity -= 0.2;
            if (!itempop) {
                this.Opacity += 0.2;
                EditPNL.Enabled = true;
            }
            if (this.Opacity == 1) ItemTMR.Stop();
        }
        public void AddItem(int prodID, int Quantity) {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("INSERT INTO Orderline(OTID, OPID, Quantity) VALUES('" + TID + "','" + prodID + "','" + Quantity + "')", conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
                MessageBox.Show(ee.Message);
            }
            RefreshProductOrder();
        }
        #endregion

        #region Details Page
        private void DraftBTN_Click(object sender, EventArgs e) {
            DialogResult rs = MessageBox.Show("Are you sure you want to delete this transaction?\nIt will be removed from the database.", "Delete Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) {
                try {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("DELETE FROM Assignment WHERE ATID=" + TID, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ee) {
                    conn.Close();
                }
                try {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("DELETE FROM Orderline WHERE OTID=" + TID, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ee) {
                    conn.Close();
                }
                try {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("DELETE FROM Transactions WHERE TID=" + TID, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ee) {
                    conn.Close();
                }
            }
            RefreshOrders();
            PanelChangeTMR.Start();
        }
        private void CheckoutBTN_Click(object sender, EventArgs e) {
            if (PriceDetails.Text.Equals("")) {
                MessageBox.Show("Please add at least one item.");
            }
            else {
                try {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("UPDATE Transactions SET status = 1 WHERE TID =" + TID, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    PanelChangeTMR.Start();
                    RefreshOrders();
                }
                catch (Exception ee) {
                    conn.Close();
                }
            }
        }
        private void BackBTN_Click(object sender, EventArgs e) {
            PanelChangeTMR.Start();
            RefreshOrders();
        }
        private void RefreshProductOrder() {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT pid, name, quantity, FORMAT(price, 2) AS price, FORMAT((price*quantity),2) AS tal FROM products INNER JOIN Orderline ON pid=opid WHERE otid=" +TID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                ProductsGrid.DataSource = dt;
                ProductsGrid.Columns["pid"].Visible = false;
                ProductsGrid.Columns["name"].HeaderText = "PRODUCT";
                ProductsGrid.Columns["name"].Width = 200;
                ProductsGrid.Columns["quantity"].HeaderText = "QUANTITY";
                ProductsGrid.Columns["quantity"].Width = 80;
                ProductsGrid.Columns["price"].HeaderText = "PRICE";
                ProductsGrid.Columns["price"].Width = 80;
                ProductsGrid.Columns["tal"].HeaderText = "TALLIED PRICE";
                ProductsGrid.Columns["tal"].Width = 80;
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
                MessageBox.Show(ee.Message);
            }
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT FORMAT(SUM(price*quantity),2), SUM(quantity) FROM products INNER JOIN Orderline ON pid=opid WHERE otid=" + TID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                PriceLBL.Text = dt.Rows[0][0].ToString();
                QuantityLBL.Text = dt.Rows[0][1].ToString() + " items";
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
                MessageBox.Show(ee.Message);
            }
        }
        int quants;
        double price;
        String productName;

        private void ProductsGrid_CellEnter(object sender, DataGridViewCellEventArgs e) {
            RemoveItemBTN.Enabled = true;
            EditItemBTN.Enabled = true;
            try {
                PID = int.Parse(ProductsGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                productName = ProductsGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                quants = int.Parse(ProductsGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                price = double.Parse(ProductsGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch {
            }
        }
        private void RemoveItemBTN_Click(object sender, EventArgs e) {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("DELETE FROM Orderline WHERE opid = " + PID + " AND oTID=" + TID, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
                MessageBox.Show(ee.Message);
            }
            RefreshProductOrder();
        }

        #endregion
        


        public bool updatePop;
        private void EditItemBTN_Click(object sender, EventArgs e) {
            EditPopup itm = new EditPopup();
            EditPNL.Enabled = false;
            UpdateTMR.Start();
            updatePop = true;
            itm.Location = new Point(this.Location.X + 200, this.Location.Y+175);
            itm.reference = this;
            itm.price = price * quants;
            itm.origprice = this.price;
            itm.prodName = productName;
            itm.qty = quants;
            itm.Show();
        }
        private void UpdateTMR_Tick(object sender, EventArgs e) {
            if (updatePop && this.Opacity > 0.6) this.Opacity -= 0.2;
            if (!updatePop) {
                this.Opacity += 0.2;
                EditPNL.Enabled = true;
            }
            if (this.Opacity == 1) UpdateTMR.Stop();
        }

        private void CompleteBTN_Click(object sender, EventArgs e) {
        }

        private void button5_Click(object sender, EventArgs e) {
            DialogResult rs = MessageBox.Show("Complete Transaction?", "Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) {
                try {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("UPDATE Transactions SET status = 7 WHERE TID =" + TID, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    if (!(MainPNL.Location == new Point(0, 0))) PanelChangeTMR.Start();
                    RefreshOrders();
                }
                catch (Exception ee) {
                    conn.Close();
                }
                RefreshOrders();
            }
        }

        private void DeliveredBTN_Click(object sender, EventArgs e) {
            DialogResult rs = MessageBox.Show("Complete delivery?", "Delivered", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) {
                try {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("UPDATE Transactions SET status = 3 WHERE TID =" + TID, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    if (!(MainPNL.Location == new Point(0, 0))) PanelChangeTMR.Start();
                    RefreshOrders();
                }
                catch (Exception ee) {
                    conn.Close();
                }
                RefreshOrders();
            }
        }



        public void UpdateItem(int qty) {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("UPDATE Orderline SET Quantity = '"+qty+"' WHERE OPID =" + PID+" AND OTID = "+ TID, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
            }
            RefreshProductOrder();

        }

        private void DenyBTN_Click(object sender, EventArgs e) {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("DELETE FROM Assign WHERE AType 2 AND ATID = " + TID, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
            }
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("UPDATE Transactions SET status = 1 WHERE TID = " + TID, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
            }
            RefreshOrders();
        }
    }
}
                