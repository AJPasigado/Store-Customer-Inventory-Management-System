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
    public partial class PopupItem : Form {
        public MySqlConnection conn;
        public CustomerTransaction reference { get; set; }

        public int TID;
        public int quantity = 1;
        public int PID;
        public double price;

        public string button = "ADD";

        public PopupItem() {
            InitializeComponent();
        }

        private void PopupItem_Load(object sender, EventArgs e) {
            Rifrish();
            if (button.Equals("UPDATE")) {
                QBX.Text = quantity.ToString();
                PriceDetails.Text = price.ToString();
                AddBTN.Text = button;
            }
        }

        private void Rifrish() {
              try {
                  conn.Open();
                  MySqlCommand comm = new MySqlCommand("SELECT * FROM products WHERE status = 1 AND PID NOT IN (SELECT OPID FROM ORDERLINE WHERE OTID="+TID+")", conn);
                  MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                  DataTable dt = new DataTable();
                  adp.Fill(dt);
                UsersDataGrid.DataSource = dt;
                  UsersDataGrid.Columns[0].Visible = false;
                  UsersDataGrid.Columns[1].HeaderText = "NAME";
                  UsersDataGrid.Columns[1].Width = 250;
                  UsersDataGrid.Columns[2].HeaderText = "PRICE";
                  UsersDataGrid.Columns[3].Visible = false;
                  UsersDataGrid.Columns[4].Visible = false;
                  conn.Close();

                UsersDataGrid.ClearSelection();
                
            }
              catch (Exception ee) {
                conn.Close();
                MessageBox.Show("Empty List.");
              }
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

        private void UsersDataGrid_CellEnter(object sender, DataGridViewCellEventArgs e) {
            try {
                PID = int.Parse(UsersDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                price = double.Parse(UsersDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (QBX.TextLength > 0) PriceDetails.Text = (price * int.Parse(QBX.Text)).ToString();
                else PriceDetails.Text = price.ToString();
            }
            catch {
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SearchBX_TextChanged(object sender, EventArgs e) {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM products WHERE (name LIKE '%" + SearchBX.Text + "%' OR name LIKE '" + SearchBX.Text + "%' OR name LIKE '%" + SearchBX.Text + "') AND status = 1 AND PID NOT IN (SELECT OPID FROM ORDERLINE WHERE OTID=" + TID + ")", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                UsersDataGrid.DataSource = dt;
                UsersDataGrid.Columns["PID"].Visible = false;
                UsersDataGrid.Columns["name"].HeaderText = "NAME";
                UsersDataGrid.Columns["name"].Width = 250;
                UsersDataGrid.Columns["price"].HeaderText = "PRICE";
                UsersDataGrid.Columns["prodtype"].Visible = false;
                UsersDataGrid.Columns["status"].Visible = false;
                conn.Close();
            }
            catch (Exception ee){ conn.Close(); MessageBox.Show("Bes tarunga ang name (Easter Egg)"); }
            
        }

        private void SearchBX_Enter(object sender, EventArgs e) {
            if (SearchBX.Text.Equals("Search or filter result.")) {
                SearchBX.Clear();
                SearchBX.Font = FNBox.Font;
                SearchLine.Visible = true;
            }
        }

        private void SearchBX_Leave(object sender, EventArgs e) {
            if (SearchBX.Text.Equals("")) {
                SearchBX.Text = "Search or filter result.";
                SearchBX.Font = SearchLBL.Font;
                SearchLine.Visible = false;
                Rifrish();
            }
        }

        private void PopupItem_FormClosing(object sender, FormClosingEventArgs e) {
            reference.itempop = false;
        }

        private void QBX_TextChanged(object sender, EventArgs e) {
            if (QBX.TextLength > 0)
                if (QBX.TextLength > 3) { MessageBox.Show("Please enter a lower value"); QBX.Clear(); }
                else PriceDetails.Text = (price * int.Parse(QBX.Text)).ToString();
            else PriceDetails.Text = price.ToString();
        }

        private void QBX_KeyDown(object sender, KeyEventArgs e) {
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
               e.KeyCode.ToString().Equals("D9"))
               ) {
                e.SuppressKeyPress = true;
            }

        }

        private void AddBTN_Click(object sender, EventArgs e) {
            if (QBX.Text.Equals("")) {
                MessageBox.Show("Enter Quantity");
            }
            else {
                reference.AddItem(PID, int.Parse(QBX.Text));
                this.Close();
            }
        }
    }
}
