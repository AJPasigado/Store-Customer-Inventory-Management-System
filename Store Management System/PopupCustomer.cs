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
    public partial class PopupCustomer : Form {
        public MySqlConnection conn;
        public CustomerTransaction reference { get; set; }
        int CID = - 1;

        public PopupCustomer() {
            InitializeComponent();
        }

        private void AddBTN_Click(object sender, EventArgs e) {
            reference.CID = this.CID;
            reference.Add = true;
            reference.LoadNewDetailsPage();
            this.Close();
        }

        private void PopupTMR_Tick(object sender, EventArgs e) {
        }

        private void PopupCustomer_Load(object sender, EventArgs e) {
            Rifrish();
        }

        private void Rifrish() {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM customer WHERE status = 1", conn);
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
                MessageBox.Show("Empty List.");
               
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

        private void UsersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                CID = int.Parse(UsersDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch {
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void PopupCustomer_FormClosing(object sender, FormClosingEventArgs e) {
            reference.ispop = false;
        }

        private void SearchBX_TextChanged(object sender, EventArgs e) {
            if (!SearchBX.Text.Equals(String.Empty)) {
                try {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT * FROM customer WHERE CONCAT(fn,' ',mn,' ',ln) LIKE '%" + SearchBX.Text + "%' OR CONCAT(fn,' ',mn,' ',ln) LIKE '" + SearchBX.Text + "%' OR CONCAT(fn,' ',mn,' ',ln) LIKE '%" + SearchBX.Text + "'", conn);
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
                    MessageBox.Show("Please enter a valid name.");
                   
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
    }
}
