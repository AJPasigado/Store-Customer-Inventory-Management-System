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
    public partial class EditPopup : Form {
        public MySqlConnection conn;
        public CustomerTransaction reference { get; set; }

        public String prodName;
        public int qty;
        public double price;
        public double origprice;

        public EditPopup() {
            InitializeComponent();
        }

        private void FadeTMR_Tick(object sender, EventArgs e) {

        }

        private void QBX_TextChanged(object sender, EventArgs e) {
            if (QBX.TextLength > 0)
                if (QBX.TextLength > 3) { MessageBox.Show("Please enter a lower value"); QBX.Clear(); }
                else PriceDetails.Text = (origprice * int.Parse(QBX.Text)).ToString();
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

        private void CancelBTN_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void EditPopup_FormClosing(object sender, FormClosingEventArgs e) {
            reference.updatePop = false;
        }

        private void EditPopup_Load(object sender, EventArgs e) {
            ProductNameLBL.Text = prodName;
            QBX.Text = qty.ToString();
            PriceDetails.Text = price.ToString();
        }

        private void SaveBTN_Click(object sender, EventArgs e) {
            if (QBX.Text.Equals("")) {
                MessageBox.Show("Please input quantity.");
            }
            else {
                reference.UpdateItem(int.Parse(QBX.Text));
                this.Close();
            }
        }
    }
}
