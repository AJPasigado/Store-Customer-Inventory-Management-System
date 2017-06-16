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
    public partial class OrderLines : Form {
        public Start reference { get; set; }
        public MySqlConnection conn;

        public OrderLines() {
            InitializeComponent();
            DetailsPNL.Location = new Point(1250, 0);
            this.Opacity = 0;
            FadeTMR.Start();
            this.DoubleBuffered = true;
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
        bool isEditing;
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

        private void OrderLines_FormClosing(object sender, FormClosingEventArgs e) {
            if (MainPNL.Location != new Point(0, 0)) {
                e.Cancel = true;
                PanelChangeTMR.Start();
            }
            else {
                reference.Opacity = 0;
                reference.Location = this.Location;
                reference.Show();
            }
        }

        private void OrderLines_Load(object sender, EventArgs e) {
            RefreshOrders();
        }
        private void RefreshOrders() {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT tid, CONCAT(customer.ln, ', ', customer.fn, ' ', customer.mn) AS Customer, dateentry , Transactions.status, cid, address, contact FROM transactions JOIN customer on TCID=cid LEFT OUTER JOIN Assignment ON atid=tid WHERE transactions.status=1 OR (transactions.status=2 AND AEID ="+UserID+") GROUP BY tid", conn);
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
                OrdersGrid.Columns["address"].Visible = false;
                OrdersGrid.Columns["contact"].Visible = false;
                conn.Close();
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
        int TID;
        public int UserID;
        private void OrdersGrid_CellEnter(object sender, DataGridViewCellEventArgs e) {
            ApproveBTN.Visible = true;
            ViewDetailsBTN.Visible = true;
            try {
                TransactionDetails.Text = OrdersGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                DateDetails.Text = OrdersGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                CustomerLBL.Text = OrdersGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                TID = int.Parse(OrdersGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("1")) StatusDetails.Text = "Pending";
                else if (OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("2")) { StatusDetails.Text = "Waiting for approval..."; ApproveBTN.Visible = false; }
                else if (OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("3")) StatusDetails.Text = "Delivered";
                else if (OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("4")) StatusDetails.Text = "Open";
                else if (OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("5")) StatusDetails.Text = "Cancelled";
                else if (OrdersGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("6")) StatusDetails.Text = "Delivering";
                AddressLBL.Text = OrdersGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                ContactLBL.Text = OrdersGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            } catch { }
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT CONCAT(employees.ln, ', ', employees.fn, ' ', employees.mn) AS POST FROM employees JOIN assignment ON AEID=EID JOIN transactions ON ATID=TID WHERE atype=1 AND TID=" + TID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable dt = new DataTable();
                adp.Fill(dt);
                PostStaffDetails.Text = dt.Rows[0][0].ToString();
            }
            catch (Exception ee) {
                PostStaffDetails.Text = "Unassigned";
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

            }
            catch (Exception ee) {
                PriceDetails.Text = "00.00";
                conn.Close();
            }
            UpdateDetails();
        }



        private void ViewDetailsBTN_Click(object sender, EventArgs e) {
            PanelChangeTMR.Start();
        }

        private void BackBTN_Click(object sender, EventArgs e) {
            PanelChangeTMR.Start();
        }

        private void ApproveBTN_Click(object sender, EventArgs e) {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("UPDATE Transactions SET status = 2 WHERE TID = "+ TID, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
                MessageBox.Show("Cannot approve assignment.");
            }

            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("INSERT INTO Assignment(Atype, Aeid, Atid) VALUES('2', '"+UserID+"','"+TID+"') ", conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
                MessageBox.Show("Cannot approve assignment");
            }
            RefreshOrders();
        }

        private void CloseBTN_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void UpdateDetails() {
            TransactionLBL.Text = "Transaction #" + TransactionDetails.Text;
            PostLBL.Text = PostStaffDetails.Text;
            PriceLBL.Text = PriceDetails.Text;
            DateLBL.Text = DateDetails.Text;
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
            RefreshProductGrid();
            ProductsGrid.ClearSelection();
        }

        private void RefreshProductGrid() {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT name, quantity, FORMAT(price,2) AS price, FORMAT((price*quantity),2) AS tal FROM products INNER JOIN Orderline ON pid=opid WHERE otid=" + TID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                ProductsGrid.DataSource = dt;
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
        }

        private void OrdersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
