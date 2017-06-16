namespace Midterm_Exam {
    partial class EditPopup {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPopup));
            this.CancelBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductNameLBL = new System.Windows.Forms.Label();
            this.QBX = new System.Windows.Forms.TextBox();
            this.SearchLine = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceDetails = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FadeTMR = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.Color.IndianRed;
            this.CancelBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBTN.BackgroundImage")));
            this.CancelBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBTN.FlatAppearance.BorderSize = 0;
            this.CancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBTN.ForeColor = System.Drawing.Color.White;
            this.CancelBTN.Location = new System.Drawing.Point(233, 182);
            this.CancelBTN.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(114, 30);
            this.CancelBTN.TabIndex = 16;
            this.CancelBTN.Text = "CANCEL";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.SaveBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBTN.BackgroundImage")));
            this.SaveBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveBTN.FlatAppearance.BorderSize = 0;
            this.SaveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBTN.ForeColor = System.Drawing.Color.White;
            this.SaveBTN.Location = new System.Drawing.Point(78, 182);
            this.SaveBTN.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(140, 30);
            this.SaveBTN.TabIndex = 15;
            this.SaveBTN.Text = "SAVE CHANGES";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(40, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 88;
            this.label11.Text = "PRODUCT NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(88, -434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 87;
            this.label1.Text = "Select a product";
            // 
            // ProductNameLBL
            // 
            this.ProductNameLBL.AutoSize = true;
            this.ProductNameLBL.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLBL.ForeColor = System.Drawing.Color.DimGray;
            this.ProductNameLBL.Location = new System.Drawing.Point(38, 52);
            this.ProductNameLBL.Name = "ProductNameLBL";
            this.ProductNameLBL.Size = new System.Drawing.Size(371, 30);
            this.ProductNameLBL.TabIndex = 89;
            this.ProductNameLBL.Text = "Everline Marking Paint Spray- 700ml";
            // 
            // QBX
            // 
            this.QBX.BackColor = System.Drawing.Color.White;
            this.QBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QBX.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.QBX.ForeColor = System.Drawing.Color.DimGray;
            this.QBX.Location = new System.Drawing.Point(174, 98);
            this.QBX.Margin = new System.Windows.Forms.Padding(2);
            this.QBX.Name = "QBX";
            this.QBX.Size = new System.Drawing.Size(31, 22);
            this.QBX.TabIndex = 90;
            this.QBX.Text = "10";
            this.QBX.TextChanged += new System.EventHandler(this.QBX_TextChanged);
            this.QBX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QBX_KeyDown);
            // 
            // SearchLine
            // 
            this.SearchLine.AutoSize = true;
            this.SearchLine.BackColor = System.Drawing.Color.White;
            this.SearchLine.ForeColor = System.Drawing.Color.DimGray;
            this.SearchLine.Location = new System.Drawing.Point(171, 110);
            this.SearchLine.Name = "SearchLine";
            this.SearchLine.Size = new System.Drawing.Size(31, 13);
            this.SearchLine.TabIndex = 91;
            this.SearchLine.Text = "____";
            this.SearchLine.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(99, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "QUANTITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(99, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "PRICE*QUANTITY";
            // 
            // PriceDetails
            // 
            this.PriceDetails.AutoSize = true;
            this.PriceDetails.BackColor = System.Drawing.Color.White;
            this.PriceDetails.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.PriceDetails.ForeColor = System.Drawing.Color.DimGray;
            this.PriceDetails.Location = new System.Drawing.Point(222, 133);
            this.PriceDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceDetails.Name = "PriceDetails";
            this.PriceDetails.Size = new System.Drawing.Size(71, 30);
            this.PriceDetails.TabIndex = 96;
            this.PriceDetails.Text = "10.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(203, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 30);
            this.label7.TabIndex = 97;
            this.label7.Text = "₱";
            // 
            // FadeTMR
            // 
            this.FadeTMR.Interval = 1;
            this.FadeTMR.Tick += new System.EventHandler(this.FadeTMR_Tick);
            // 
            // EditPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 248);
            this.ControlBox = false;
            this.Controls.Add(this.PriceDetails);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QBX);
            this.Controls.Add(this.SearchLine);
            this.Controls.Add(this.ProductNameLBL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.SaveBTN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPopup_FormClosing);
            this.Load += new System.EventHandler(this.EditPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductNameLBL;
        private System.Windows.Forms.TextBox QBX;
        private System.Windows.Forms.Label SearchLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PriceDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer FadeTMR;
    }
}