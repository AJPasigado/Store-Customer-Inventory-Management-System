namespace Midterm_Exam {
    partial class Start {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);


        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.LoginPNL = new System.Windows.Forms.Panel();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AnimationTMR = new System.Windows.Forms.Timer(this.components);
            this.StartPNL = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LogoutBTN = new System.Windows.Forms.Button();
            this.WelcomeLBL = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.UserManBTN = new System.Windows.Forms.Button();
            this.ProductMonitoringBTN = new System.Windows.Forms.Button();
            this.CustomerTransactionBTN = new System.Windows.Forms.Button();
            this.PurchaseOrdersBTN = new System.Windows.Forms.Button();
            this.CustomerBTN = new System.Windows.Forms.Button();
            this.OderLinesBTN = new System.Windows.Forms.Button();
            this.NotificationsPNL = new System.Windows.Forms.FlowLayoutPanel();
            this.ItemsAvailableBTN = new System.Windows.Forms.Button();
            this.ActiveBTN = new System.Windows.Forms.Button();
            this.ActiveCustomerBTN = new System.Windows.Forms.Button();
            this.TransactionsNotifBTN = new System.Windows.Forms.Button();
            this.OrderRequestsNotifBTN = new System.Windows.Forms.Button();
            this.PendingOrdersNotifBTN = new System.Windows.Forms.Button();
            this.ToBeApprovedNotifBTN = new System.Windows.Forms.Button();
            this.FadeTMR = new System.Windows.Forms.Timer(this.components);
            this.LoginPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.StartPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.NotificationsPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPNL
            // 
            this.LoginPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.LoginPNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginPNL.Controls.Add(this.CloseBTN);
            this.LoginPNL.Controls.Add(this.label3);
            this.LoginPNL.Controls.Add(this.label2);
            this.LoginPNL.Controls.Add(this.label5);
            this.LoginPNL.Controls.Add(this.pictureBox1);
            this.LoginPNL.Controls.Add(this.PassBox);
            this.LoginPNL.Controls.Add(this.label4);
            this.LoginPNL.Controls.Add(this.label8);
            this.LoginPNL.Controls.Add(this.txtUser);
            this.LoginPNL.Controls.Add(this.label7);
            this.LoginPNL.Controls.Add(this.LoginBTN);
            this.LoginPNL.Controls.Add(this.pictureBox2);
            this.LoginPNL.Location = new System.Drawing.Point(0, 600);
            this.LoginPNL.Name = "LoginPNL";
            this.LoginPNL.Size = new System.Drawing.Size(850, 600);
            this.LoginPNL.TabIndex = 37;
            this.LoginPNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.LoginPNL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.LoginPNL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // CloseBTN
            // 
            this.CloseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CloseBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseBTN.BackgroundImage")));
            this.CloseBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBTN.FlatAppearance.BorderSize = 0;
            this.CloseBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.CloseBTN.ForeColor = System.Drawing.Color.White;
            this.CloseBTN.Location = new System.Drawing.Point(446, 356);
            this.CloseBTN.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(90, 30);
            this.CloseBTN.TabIndex = 40;
            this.CloseBTN.Text = "EXIT";
            this.CloseBTN.UseVisualStyleBackColor = false;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(346, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(347, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "USERNAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(285, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 74);
            this.label5.TabIndex = 36;
            this.label5.Text = "Convenient";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.pictureBox1.BackgroundImage = global::Midterm_Exam.Properties.Resources.EyeWhite;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(525, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 17);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Password_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Password_MouseUp);
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.ForeColor = System.Drawing.Color.White;
            this.PassBox.Location = new System.Drawing.Point(349, 295);
            this.PassBox.Margin = new System.Windows.Forms.Padding(2);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '●';
            this.PassBox.Size = new System.Drawing.Size(197, 25);
            this.PassBox.TabIndex = 27;
            this.PassBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(372, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "You name it, we got it!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(346, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "_________________________________";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(350, 239);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(197, 25);
            this.txtUser.TabIndex = 26;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(347, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "_________________________________";
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.LoginBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBTN.BackgroundImage")));
            this.LoginBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBTN.FlatAppearance.BorderSize = 0;
            this.LoginBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.LoginBTN.ForeColor = System.Drawing.Color.White;
            this.LoginBTN.Location = new System.Drawing.Point(352, 356);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(90, 30);
            this.LoginBTN.TabIndex = 28;
            this.LoginBTN.Text = "LOGIN";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Midterm_Exam.Properties.Resources.LoginBG;
            this.pictureBox2.Location = new System.Drawing.Point(0, 356);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(850, 244);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // AnimationTMR
            // 
            this.AnimationTMR.Interval = 1;
            this.AnimationTMR.Tick += new System.EventHandler(this.AnimationTMR_Tick);
            // 
            // StartPNL
            // 
            this.StartPNL.BackColor = System.Drawing.Color.White;
            this.StartPNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartPNL.Controls.Add(this.pictureBox3);
            this.StartPNL.Controls.Add(this.LogoutBTN);
            this.StartPNL.Controls.Add(this.WelcomeLBL);
            this.StartPNL.Controls.Add(this.DateLabel);
            this.StartPNL.Controls.Add(this.flowLayoutPanel1);
            this.StartPNL.Controls.Add(this.NotificationsPNL);
            this.StartPNL.Location = new System.Drawing.Point(0, 0);
            this.StartPNL.Name = "StartPNL";
            this.StartPNL.Size = new System.Drawing.Size(850, 600);
            this.StartPNL.TabIndex = 38;
            this.StartPNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.StartPNL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.StartPNL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Midterm_Exam.Properties.Resources.Background;
            this.pictureBox3.Location = new System.Drawing.Point(0, 458);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(850, 142);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // LogoutBTN
            // 
            this.LogoutBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.LogoutBTN.BackgroundImage = global::Midterm_Exam.Properties.Resources.Button;
            this.LogoutBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoutBTN.FlatAppearance.BorderSize = 0;
            this.LogoutBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.LogoutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.LogoutBTN.ForeColor = System.Drawing.Color.White;
            this.LogoutBTN.Location = new System.Drawing.Point(95, 171);
            this.LogoutBTN.Name = "LogoutBTN";
            this.LogoutBTN.Size = new System.Drawing.Size(80, 30);
            this.LogoutBTN.TabIndex = 39;
            this.LogoutBTN.TabStop = false;
            this.LogoutBTN.Text = "LOGOUT";
            this.LogoutBTN.UseVisualStyleBackColor = false;
            this.LogoutBTN.Visible = false;
            this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
            // 
            // WelcomeLBL
            // 
            this.WelcomeLBL.AutoSize = true;
            this.WelcomeLBL.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLBL.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.WelcomeLBL.ForeColor = System.Drawing.Color.DimGray;
            this.WelcomeLBL.Location = new System.Drawing.Point(88, 108);
            this.WelcomeLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeLBL.Name = "WelcomeLBL";
            this.WelcomeLBL.Size = new System.Drawing.Size(213, 54);
            this.WelcomeLBL.TabIndex = 38;
            this.WelcomeLBL.Text = "Hi, Name!";
            this.WelcomeLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.DimGray;
            this.DateLabel.Location = new System.Drawing.Point(97, 87);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(137, 21);
            this.DateLabel.TabIndex = 37;
            this.DateLabel.Text = "February 08, 2017";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.UserManBTN);
            this.flowLayoutPanel1.Controls.Add(this.ProductMonitoringBTN);
            this.flowLayoutPanel1.Controls.Add(this.CustomerTransactionBTN);
            this.flowLayoutPanel1.Controls.Add(this.PurchaseOrdersBTN);
            this.flowLayoutPanel1.Controls.Add(this.CustomerBTN);
            this.flowLayoutPanel1.Controls.Add(this.OderLinesBTN);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(415, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(375, 552);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // UserManBTN
            // 
            this.UserManBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.UserManBTN.BackgroundImage = global::Midterm_Exam.Properties.Resources.EmployeeMN;
            this.UserManBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserManBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UserManBTN.FlatAppearance.BorderSize = 0;
            this.UserManBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(204)))), ((int)(((byte)(222)))));
            this.UserManBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.UserManBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserManBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserManBTN.ForeColor = System.Drawing.Color.DimGray;
            this.UserManBTN.Location = new System.Drawing.Point(3, 3);
            this.UserManBTN.Name = "UserManBTN";
            this.UserManBTN.Size = new System.Drawing.Size(178, 171);
            this.UserManBTN.TabIndex = 3;
            this.UserManBTN.TabStop = false;
            this.UserManBTN.Text = "User Management";
            this.UserManBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UserManBTN.UseVisualStyleBackColor = false;
            this.UserManBTN.Click += new System.EventHandler(this.UserManBTN_Click);
            // 
            // ProductMonitoringBTN
            // 
            this.ProductMonitoringBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.ProductMonitoringBTN.BackgroundImage = global::Midterm_Exam.Properties.Resources.Monitoring;
            this.ProductMonitoringBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ProductMonitoringBTN.FlatAppearance.BorderSize = 0;
            this.ProductMonitoringBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.ProductMonitoringBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ProductMonitoringBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductMonitoringBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductMonitoringBTN.ForeColor = System.Drawing.Color.DimGray;
            this.ProductMonitoringBTN.Location = new System.Drawing.Point(187, 3);
            this.ProductMonitoringBTN.Name = "ProductMonitoringBTN";
            this.ProductMonitoringBTN.Size = new System.Drawing.Size(178, 171);
            this.ProductMonitoringBTN.TabIndex = 4;
            this.ProductMonitoringBTN.TabStop = false;
            this.ProductMonitoringBTN.Text = "Product Monitoring";
            this.ProductMonitoringBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProductMonitoringBTN.UseVisualStyleBackColor = false;
            this.ProductMonitoringBTN.Click += new System.EventHandler(this.ProductMonitoring_Click);
            // 
            // CustomerTransactionBTN
            // 
            this.CustomerTransactionBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.CustomerTransactionBTN.BackgroundImage = global::Midterm_Exam.Properties.Resources.Transactions;
            this.CustomerTransactionBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.CustomerTransactionBTN.FlatAppearance.BorderSize = 0;
            this.CustomerTransactionBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.CustomerTransactionBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.CustomerTransactionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerTransactionBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTransactionBTN.ForeColor = System.Drawing.Color.DimGray;
            this.CustomerTransactionBTN.Location = new System.Drawing.Point(3, 180);
            this.CustomerTransactionBTN.Name = "CustomerTransactionBTN";
            this.CustomerTransactionBTN.Size = new System.Drawing.Size(178, 171);
            this.CustomerTransactionBTN.TabIndex = 5;
            this.CustomerTransactionBTN.TabStop = false;
            this.CustomerTransactionBTN.Text = "Customer Transactions";
            this.CustomerTransactionBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomerTransactionBTN.UseVisualStyleBackColor = false;
            this.CustomerTransactionBTN.Click += new System.EventHandler(this.CustomerTransactionBTN_Click);
            // 
            // PurchaseOrdersBTN
            // 
            this.PurchaseOrdersBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.PurchaseOrdersBTN.BackgroundImage = global::Midterm_Exam.Properties.Resources.Purchase;
            this.PurchaseOrdersBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.PurchaseOrdersBTN.FlatAppearance.BorderSize = 0;
            this.PurchaseOrdersBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.PurchaseOrdersBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.PurchaseOrdersBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseOrdersBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseOrdersBTN.ForeColor = System.Drawing.Color.DimGray;
            this.PurchaseOrdersBTN.Location = new System.Drawing.Point(187, 180);
            this.PurchaseOrdersBTN.Name = "PurchaseOrdersBTN";
            this.PurchaseOrdersBTN.Size = new System.Drawing.Size(178, 171);
            this.PurchaseOrdersBTN.TabIndex = 6;
            this.PurchaseOrdersBTN.TabStop = false;
            this.PurchaseOrdersBTN.Text = "Purchase Orders";
            this.PurchaseOrdersBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PurchaseOrdersBTN.UseVisualStyleBackColor = false;
            this.PurchaseOrdersBTN.Click += new System.EventHandler(this.PurchaseOrdersBTN_Click);
            // 
            // CustomerBTN
            // 
            this.CustomerBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.CustomerBTN.BackgroundImage = global::Midterm_Exam.Properties.Resources.Customer;
            this.CustomerBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.CustomerBTN.FlatAppearance.BorderSize = 0;
            this.CustomerBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.CustomerBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.CustomerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBTN.ForeColor = System.Drawing.Color.DimGray;
            this.CustomerBTN.Location = new System.Drawing.Point(3, 357);
            this.CustomerBTN.Name = "CustomerBTN";
            this.CustomerBTN.Size = new System.Drawing.Size(178, 171);
            this.CustomerBTN.TabIndex = 7;
            this.CustomerBTN.TabStop = false;
            this.CustomerBTN.Text = "Customers";
            this.CustomerBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomerBTN.UseVisualStyleBackColor = false;
            this.CustomerBTN.Click += new System.EventHandler(this.CustomerBTN_Click);
            // 
            // OderLinesBTN
            // 
            this.OderLinesBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.OderLinesBTN.BackgroundImage = global::Midterm_Exam.Properties.Resources.Oder_Lines;
            this.OderLinesBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.OderLinesBTN.FlatAppearance.BorderSize = 0;
            this.OderLinesBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.OderLinesBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.OderLinesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OderLinesBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OderLinesBTN.ForeColor = System.Drawing.Color.DimGray;
            this.OderLinesBTN.Location = new System.Drawing.Point(187, 357);
            this.OderLinesBTN.Name = "OderLinesBTN";
            this.OderLinesBTN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OderLinesBTN.Size = new System.Drawing.Size(178, 171);
            this.OderLinesBTN.TabIndex = 8;
            this.OderLinesBTN.TabStop = false;
            this.OderLinesBTN.Text = "Order Lines";
            this.OderLinesBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OderLinesBTN.UseVisualStyleBackColor = false;
            this.OderLinesBTN.Click += new System.EventHandler(this.OderLinesBTN_Click);
            // 
            // NotificationsPNL
            // 
            this.NotificationsPNL.Controls.Add(this.ItemsAvailableBTN);
            this.NotificationsPNL.Controls.Add(this.ActiveBTN);
            this.NotificationsPNL.Controls.Add(this.ActiveCustomerBTN);
            this.NotificationsPNL.Controls.Add(this.TransactionsNotifBTN);
            this.NotificationsPNL.Controls.Add(this.OrderRequestsNotifBTN);
            this.NotificationsPNL.Controls.Add(this.PendingOrdersNotifBTN);
            this.NotificationsPNL.Controls.Add(this.ToBeApprovedNotifBTN);
            this.NotificationsPNL.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.NotificationsPNL.Location = new System.Drawing.Point(84, 245);
            this.NotificationsPNL.Name = "NotificationsPNL";
            this.NotificationsPNL.Size = new System.Drawing.Size(267, 326);
            this.NotificationsPNL.TabIndex = 40;
            // 
            // ItemsAvailableBTN
            // 
            this.ItemsAvailableBTN.FlatAppearance.BorderSize = 0;
            this.ItemsAvailableBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsAvailableBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ItemsAvailableBTN.ForeColor = System.Drawing.Color.DimGray;
            this.ItemsAvailableBTN.Location = new System.Drawing.Point(3, 3);
            this.ItemsAvailableBTN.Name = "ItemsAvailableBTN";
            this.ItemsAvailableBTN.Size = new System.Drawing.Size(264, 32);
            this.ItemsAvailableBTN.TabIndex = 3;
            this.ItemsAvailableBTN.TabStop = false;
            this.ItemsAvailableBTN.Text = "12 Items available";
            this.ItemsAvailableBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ItemsAvailableBTN.UseVisualStyleBackColor = true;
            this.ItemsAvailableBTN.Visible = false;
            this.ItemsAvailableBTN.Click += new System.EventHandler(this.ItemsAvailableBTN_Click);
            // 
            // ActiveBTN
            // 
            this.ActiveBTN.FlatAppearance.BorderSize = 0;
            this.ActiveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActiveBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ActiveBTN.ForeColor = System.Drawing.Color.DimGray;
            this.ActiveBTN.Location = new System.Drawing.Point(3, 41);
            this.ActiveBTN.Name = "ActiveBTN";
            this.ActiveBTN.Size = new System.Drawing.Size(264, 32);
            this.ActiveBTN.TabIndex = 4;
            this.ActiveBTN.TabStop = false;
            this.ActiveBTN.Text = "4 Active Employees";
            this.ActiveBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActiveBTN.UseVisualStyleBackColor = true;
            this.ActiveBTN.Visible = false;
            this.ActiveBTN.Click += new System.EventHandler(this.ActiveBTN_Click);
            // 
            // ActiveCustomerBTN
            // 
            this.ActiveCustomerBTN.FlatAppearance.BorderSize = 0;
            this.ActiveCustomerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActiveCustomerBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ActiveCustomerBTN.ForeColor = System.Drawing.Color.DimGray;
            this.ActiveCustomerBTN.Location = new System.Drawing.Point(3, 79);
            this.ActiveCustomerBTN.Name = "ActiveCustomerBTN";
            this.ActiveCustomerBTN.Size = new System.Drawing.Size(264, 32);
            this.ActiveCustomerBTN.TabIndex = 5;
            this.ActiveCustomerBTN.TabStop = false;
            this.ActiveCustomerBTN.Text = "4 Active Customers";
            this.ActiveCustomerBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActiveCustomerBTN.UseVisualStyleBackColor = true;
            this.ActiveCustomerBTN.Visible = false;
            this.ActiveCustomerBTN.Click += new System.EventHandler(this.ActiveCustomerBTN_Click);
            // 
            // TransactionsNotifBTN
            // 
            this.TransactionsNotifBTN.FlatAppearance.BorderSize = 0;
            this.TransactionsNotifBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionsNotifBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TransactionsNotifBTN.ForeColor = System.Drawing.Color.DimGray;
            this.TransactionsNotifBTN.Location = new System.Drawing.Point(3, 117);
            this.TransactionsNotifBTN.Name = "TransactionsNotifBTN";
            this.TransactionsNotifBTN.Size = new System.Drawing.Size(264, 32);
            this.TransactionsNotifBTN.TabIndex = 0;
            this.TransactionsNotifBTN.TabStop = false;
            this.TransactionsNotifBTN.Text = "0 Completed Transaction(s)";
            this.TransactionsNotifBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionsNotifBTN.UseVisualStyleBackColor = true;
            this.TransactionsNotifBTN.Visible = false;
            this.TransactionsNotifBTN.Click += new System.EventHandler(this.PurchaseOrdersBTN_Click);
            // 
            // OrderRequestsNotifBTN
            // 
            this.OrderRequestsNotifBTN.FlatAppearance.BorderSize = 0;
            this.OrderRequestsNotifBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderRequestsNotifBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OrderRequestsNotifBTN.ForeColor = System.Drawing.Color.DimGray;
            this.OrderRequestsNotifBTN.Location = new System.Drawing.Point(3, 155);
            this.OrderRequestsNotifBTN.Name = "OrderRequestsNotifBTN";
            this.OrderRequestsNotifBTN.Size = new System.Drawing.Size(264, 32);
            this.OrderRequestsNotifBTN.TabIndex = 1;
            this.OrderRequestsNotifBTN.TabStop = false;
            this.OrderRequestsNotifBTN.Text = "to be approved";
            this.OrderRequestsNotifBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderRequestsNotifBTN.UseVisualStyleBackColor = true;
            this.OrderRequestsNotifBTN.Visible = false;
            this.OrderRequestsNotifBTN.Click += new System.EventHandler(this.CustomerTransactionBTN_Click);
            // 
            // PendingOrdersNotifBTN
            // 
            this.PendingOrdersNotifBTN.FlatAppearance.BorderSize = 0;
            this.PendingOrdersNotifBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PendingOrdersNotifBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PendingOrdersNotifBTN.ForeColor = System.Drawing.Color.DimGray;
            this.PendingOrdersNotifBTN.Location = new System.Drawing.Point(3, 193);
            this.PendingOrdersNotifBTN.Name = "PendingOrdersNotifBTN";
            this.PendingOrdersNotifBTN.Size = new System.Drawing.Size(264, 32);
            this.PendingOrdersNotifBTN.TabIndex = 2;
            this.PendingOrdersNotifBTN.TabStop = false;
            this.PendingOrdersNotifBTN.Text = "48 Pending Orders";
            this.PendingOrdersNotifBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PendingOrdersNotifBTN.UseVisualStyleBackColor = true;
            this.PendingOrdersNotifBTN.Visible = false;
            this.PendingOrdersNotifBTN.Click += new System.EventHandler(this.OderLinesBTN_Click);
            // 
            // ToBeApprovedNotifBTN
            // 
            this.ToBeApprovedNotifBTN.FlatAppearance.BorderSize = 0;
            this.ToBeApprovedNotifBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToBeApprovedNotifBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ToBeApprovedNotifBTN.ForeColor = System.Drawing.Color.DimGray;
            this.ToBeApprovedNotifBTN.Location = new System.Drawing.Point(3, 231);
            this.ToBeApprovedNotifBTN.Name = "ToBeApprovedNotifBTN";
            this.ToBeApprovedNotifBTN.Size = new System.Drawing.Size(264, 32);
            this.ToBeApprovedNotifBTN.TabIndex = 6;
            this.ToBeApprovedNotifBTN.TabStop = false;
            this.ToBeApprovedNotifBTN.Text = "to be approved";
            this.ToBeApprovedNotifBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToBeApprovedNotifBTN.UseVisualStyleBackColor = true;
            this.ToBeApprovedNotifBTN.Visible = false;
            this.ToBeApprovedNotifBTN.Click += new System.EventHandler(this.CustomerTransactionBTN_Click);
            // 
            // FadeTMR
            // 
            this.FadeTMR.Interval = 1;
            this.FadeTMR.Tick += new System.EventHandler(this.FadeTMR_Tick);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CloseBTN;
            this.ClientSize = new System.Drawing.Size(848, 598);
            this.ControlBox = false;
            this.Controls.Add(this.StartPNL);
            this.Controls.Add(this.LoginPNL);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Password_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Password_MouseUp);
            this.LoginPNL.ResumeLayout(false);
            this.LoginPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.StartPNL.ResumeLayout(false);
            this.StartPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.NotificationsPNL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LoginPNL;
        private System.Windows.Forms.Panel StartPNL;
        private System.Windows.Forms.Label WelcomeLBL;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button UserManBTN;
        private System.Windows.Forms.Button ProductMonitoringBTN;
        private System.Windows.Forms.Button CustomerTransactionBTN;
        private System.Windows.Forms.Button PurchaseOrdersBTN;
        private System.Windows.Forms.Timer AnimationTMR;
        private System.Windows.Forms.Button LogoutBTN;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FlowLayoutPanel NotificationsPNL;
        private System.Windows.Forms.Button TransactionsNotifBTN;
        private System.Windows.Forms.Button OrderRequestsNotifBTN;
        private System.Windows.Forms.Button PendingOrdersNotifBTN;
        private System.Windows.Forms.Timer FadeTMR;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ItemsAvailableBTN;
        private System.Windows.Forms.Button ActiveBTN;
        private System.Windows.Forms.Button CustomerBTN;
        private System.Windows.Forms.Button ActiveCustomerBTN;
        private System.Windows.Forms.Button OderLinesBTN;
        private System.Windows.Forms.Button ToBeApprovedNotifBTN;
    }
}

