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
    public partial class Start : Form {
        public MySqlConnection conn;

        public int UserType = 1;
        int UserID;
        String name = "AJ";
        bool login = true;

        public Start() {
            InitializeComponent();
            LoginPNL.Location = new Point(0, 0);
            StartPNL.Location = new Point(0, -600);
            this.DoubleBuffered = true;
            this.Opacity = 0;
            FadeTMR.Start();
            DateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            conn = new MySqlConnection("Server=localhost;Database=convinientdb;Uid=root;Pwd=root;");
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
            if (this.Opacity == 1) Notifs();
        }
        private void Start_FormClosing(object sender, FormClosingEventArgs e) {
            if (StartPNL.Location == new Point(0, 0)) {
                e.Cancel = true;
                PassBox.Clear();
                AnimationTMR.Start();
            }
        }
        private void AnimationTMR_Tick(object sender, EventArgs e) {
            int baseInt = 30;
            if (login) {
                StartPNL.Enabled = true;
                Point hide = new Point(0, 600);
                Point start = new Point(0, 0);
                if (LoginPNL.Location != hide) LoginPNL.Location = new Point(LoginPNL.Location.X, LoginPNL.Location.Y + baseInt);
                if (StartPNL.Location != start) StartPNL.Location = new Point(StartPNL.Location.X, StartPNL.Location.Y + baseInt);
                else {
                    AnimationTMR.Stop();
                    login = false;
                    LogoutBTN.Visible = true;
                    LoginPNL.Enabled = false;
                }
            }
            else {
                LoginPNL.Enabled = true;
                Point hide = new Point(0, 0);
                Point start = new Point(0, -600);
                if (StartPNL.Location != start) StartPNL.Location = new Point(StartPNL.Location.X, StartPNL.Location.Y - baseInt);
                if (LoginPNL.Location != hide) LoginPNL.Location = new Point(LoginPNL.Location.X, LoginPNL.Location.Y - baseInt);
                else {
                    AnimationTMR.Stop();
                    login = true;
                    LogoutBTN.Visible = false;
                    StartPNL.Enabled = false;
                    txtUser.SelectAll();
                }
            }
        }

        public void StartLoad() {
            if (UserType == 1) {
                UserManBTN.Visible = true;
                ProductMonitoringBTN.Visible = true;
                CustomerTransactionBTN.Visible = false;
                PurchaseOrdersBTN.Visible = true;
                CustomerBTN.Visible = false;
                OderLinesBTN.Visible = false;

                ToBeApprovedNotifBTN.Visible = false;
                TransactionsNotifBTN.Visible = true;
                OrderRequestsNotifBTN.Visible = false;
                PendingOrdersNotifBTN.Visible = false;
                ItemsAvailableBTN.Visible = true;
                ActiveBTN.Visible = true;
                ActiveCustomerBTN.Visible = false;
            }
            else if (UserType == 2) {
                UserManBTN.Visible = false;
                ProductMonitoringBTN.Visible = false;
                CustomerTransactionBTN.Visible = true;
                PurchaseOrdersBTN.Visible = false;
                CustomerBTN.Visible = true;
                OderLinesBTN.Visible = false;

                ToBeApprovedNotifBTN.Visible = true;
                TransactionsNotifBTN.Visible = false;
                OrderRequestsNotifBTN.Visible = true;
                PendingOrdersNotifBTN.Visible = false;
                ItemsAvailableBTN.Visible = false;
                ActiveBTN.Visible = false;
                ActiveCustomerBTN.Visible = true;
            }
            else if (UserType == 3) {
                UserManBTN.Visible = false;
                ProductMonitoringBTN.Visible = false;
                CustomerTransactionBTN.Visible = false;
                PurchaseOrdersBTN.Visible = false;
                CustomerBTN.Visible = false;
                OderLinesBTN.Visible = true;

                ToBeApprovedNotifBTN.Visible = false;
                TransactionsNotifBTN.Visible = false;
                OrderRequestsNotifBTN.Visible = false;
                PendingOrdersNotifBTN.Visible = true;
                ItemsAvailableBTN.Visible = false;
                ActiveBTN.Visible = false;
                ActiveCustomerBTN.Visible = false;
            }
            else UserManBTN.Visible = false;
            WelcomeLBL.Text = "Hi, " + name + "!";
            
        }
        private void Notifs() {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM products WHERE status = 2", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                ItemsAvailableBTN.Text = dt.Rows.Count + " Item(s) Not Available";
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
            }
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM employees WHERE status = 1", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                ActiveBTN.Text = dt.Rows.Count + " Active Employee(s)";
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
            }
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM customer WHERE status = 1", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                ActiveCustomerBTN.Text = dt.Rows.Count + " Active Customer(s)";
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
            }
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM transactions WHERE status = 7", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                TransactionsNotifBTN.Text = dt.Rows.Count + " Completed Transaction(s)";
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
            }
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM transactions LEFT JOIN assignment on Atid = tid WHERE status = 4 and aeid="+UserID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                OrderRequestsNotifBTN.Text = dt.Rows.Count + " transaction(s) is still open";
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
            }
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM transactions WHERE status = 1", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                PendingOrdersNotifBTN.Text = dt.Rows.Count + " transaction(s) needs a runner";
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
            }
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM transactions LEFT OUTER JOIN assignment ON atid = tid WHERE status = 2 and aeid="+UserID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                ToBeApprovedNotifBTN.Text = dt.Rows.Count + " transaction(s) needs approval";
                conn.Close();
            }
            catch (Exception ee) {
                conn.Close();
            }

        }
        #endregion

        #region Login Page
        private void LoginBTN_Click(object sender, EventArgs e) {
            Login();
        }
        public void Login() {
            if (PassBox.Text.Equals("")) MessageBox.Show("Please enter your password");
            else if (txtUser.Text.Equals("")) MessageBox.Show("Please enter your username");
            else {
                try {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT * FROM employees WHERE username = '" + txtUser.Text + "' AND password = '" + PassBox.Text + "'", conn);
                    conn.Close();
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count == 1) {
                        if (int.Parse(dt.Rows[0]["status"].ToString()) == 2)  MessageBox.Show("User is currently inactive.");
                        else {
                            UserType = int.Parse(dt.Rows[0]["staffdesc"].ToString());
                            name = dt.Rows[0]["fn"].ToString();
                            StartLoad();
                            UserID = int.Parse(dt.Rows[0]["EID"].ToString());
                            AnimationTMR.Start();

                            Notifs();
                        }
                    }
                    else MessageBox.Show("The username or password is incorrect");
                }
                catch (Exception ee) {
                    conn.Close();
                    MessageBox.Show("The username or password is incorrect");
                }
            }
        }
        private void txtPass_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode.ToString().Equals("Escape")) {
                if (MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.Close();
            }
            if (e.KeyValue.ToString().Equals("13")) {
                Login();
            }
        }
        private void Password_MouseUp(object sender, MouseEventArgs e) {
            PassBox.PasswordChar = '●';
        }
        private void Password_MouseDown(object sender, MouseEventArgs e) {
            PassBox.PasswordChar = '\0';
        }
        private void CloseBTN_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }
        private void LogoutBTN_Click(object sender, EventArgs e) {
            PassBox.Clear();
            AnimationTMR.Start();
        }
        #endregion

        #region Start Buttons
        private void UserManBTN_Click(object sender, EventArgs e) {
            UserMN user = new UserMN();
            user.reference = this;
            this.Hide();
            user.UserID = this.UserID;
            user.conn = this.conn;
            user.Location = this.Location;
            user.Show();
        }
        private void ProductMonitoring_Click(object sender, EventArgs e) {
            ProductMonitoring prod = new ProductMonitoring();
            prod.reference = this;
            this.Hide();
            prod.conn = this.conn;
            prod.Location = this.Location;
            prod.Show();
        }

        private void ItemsAvailableBTN_Click(object sender, EventArgs e) {
            ProductMonitoring prod = new ProductMonitoring();
            prod.reference = this;
            this.Hide();
            prod.conn = this.conn;
            prod.Location = this.Location;
            prod.Show();
        }

        private void ActiveBTN_Click(object sender, EventArgs e) {
            UserMN user = new UserMN();
            user.reference = this;
            this.Hide();
            user.UserID = this.UserID;
            user.conn = this.conn;
            user.Location = this.Location;
            user.Show();
        }

        private void CustomerBTN_Click(object sender, EventArgs e) {
            CustomerMN user = new CustomerMN();
            user.reference = this;
            this.Hide();
            user.UserID = this.UserID;
            user.conn = this.conn;
            user.Location = this.Location;
            user.Show();
        }

        private void ActiveCustomerBTN_Click(object sender, EventArgs e) {
            CustomerMN user = new CustomerMN();
            user.reference = this;
            this.Hide();
            user.UserID = this.UserID;
            user.conn = this.conn;
            user.Location = this.Location;
            user.Show();
        }

        private void CustomerTransactionBTN_Click(object sender, EventArgs e) {
            CustomerTransaction user = new CustomerTransaction();
            user.reference = this;
            this.Hide();
            user.UserID = this.UserID;
            user.conn = this.conn;
            user.Location = this.Location;
            user.Show();
        }

        private void PurchaseOrdersBTN_Click(object sender, EventArgs e) {
            PurchaseOrders user = new PurchaseOrders();
            user.reference = this;
            this.Hide();
            user.conn = this.conn;
            user.Location = this.Location;
            user.Show();
        }

        private void OderLinesBTN_Click(object sender, EventArgs e) {
            OrderLines user = new OrderLines();
            user.reference = this;
            this.Hide();
            user.UserID = this.UserID;
            user.conn = this.conn;
            user.Location = this.Location;
            user.Show();
        }
        #endregion

    }
}
