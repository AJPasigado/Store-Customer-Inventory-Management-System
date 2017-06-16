namespace Midterm_Exam {
    partial class PopupItem {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupItem));
            this.SearchBX = new System.Windows.Forms.TextBox();
            this.SearchLine = new System.Windows.Forms.Label();
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.QBX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SearchLBL = new System.Windows.Forms.Label();
            this.FNBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceDetails = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBX
            // 
            this.SearchBX.BackColor = System.Drawing.Color.White;
            this.SearchBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBX.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBX.ForeColor = System.Drawing.Color.DimGray;
            this.SearchBX.Location = new System.Drawing.Point(108, 62);
            this.SearchBX.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBX.Name = "SearchBX";
            this.SearchBX.Size = new System.Drawing.Size(178, 18);
            this.SearchBX.TabIndex = 83;
            this.SearchBX.Text = "Search or filter result.";
            this.SearchBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchBX.TextChanged += new System.EventHandler(this.SearchBX_TextChanged);
            this.SearchBX.Enter += new System.EventHandler(this.SearchBX_Enter);
            this.SearchBX.Leave += new System.EventHandler(this.SearchBX_Leave);
            // 
            // SearchLine
            // 
            this.SearchLine.AutoSize = true;
            this.SearchLine.BackColor = System.Drawing.Color.White;
            this.SearchLine.ForeColor = System.Drawing.Color.DimGray;
            this.SearchLine.Location = new System.Drawing.Point(105, 71);
            this.SearchLine.Name = "SearchLine";
            this.SearchLine.Size = new System.Drawing.Size(181, 13);
            this.SearchLine.TabIndex = 84;
            this.SearchLine.Text = "_____________________________";
            this.SearchLine.Visible = false;
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.AllowUserToAddRows = false;
            this.UsersDataGrid.AllowUserToDeleteRows = false;
            this.UsersDataGrid.AllowUserToResizeColumns = false;
            this.UsersDataGrid.AllowUserToResizeRows = false;
            this.UsersDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.UsersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UsersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.UsersDataGrid.EnableHeadersVisualStyles = false;
            this.UsersDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.UsersDataGrid.Location = new System.Drawing.Point(27, 97);
            this.UsersDataGrid.MultiSelect = false;
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UsersDataGrid.RowHeadersVisible = false;
            this.UsersDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UsersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGrid.ShowEditingIcon = false;
            this.UsersDataGrid.Size = new System.Drawing.Size(345, 379);
            this.UsersDataGrid.TabIndex = 82;
            this.UsersDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGrid_CellEnter);
            this.UsersDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGrid_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(110, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 81;
            this.label1.Text = "Select a product";
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
            this.CancelBTN.Location = new System.Drawing.Point(200, 544);
            this.CancelBTN.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(114, 30);
            this.CancelBTN.TabIndex = 80;
            this.CancelBTN.Text = "CANCEL";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // AddBTN
            // 
            this.AddBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.AddBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBTN.BackgroundImage")));
            this.AddBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddBTN.FlatAppearance.BorderSize = 0;
            this.AddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBTN.ForeColor = System.Drawing.Color.White;
            this.AddBTN.Location = new System.Drawing.Point(73, 544);
            this.AddBTN.Margin = new System.Windows.Forms.Padding(2);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(114, 30);
            this.AddBTN.TabIndex = 79;
            this.AddBTN.Text = "ADD";
            this.AddBTN.UseVisualStyleBackColor = false;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(62, 500);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "QUANTITY:";
            // 
            // QBX
            // 
            this.QBX.BackColor = System.Drawing.Color.White;
            this.QBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QBX.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.QBX.ForeColor = System.Drawing.Color.DimGray;
            this.QBX.Location = new System.Drawing.Point(133, 496);
            this.QBX.Margin = new System.Windows.Forms.Padding(2);
            this.QBX.Name = "QBX";
            this.QBX.Size = new System.Drawing.Size(39, 18);
            this.QBX.TabIndex = 85;
            this.QBX.Text = "1";
            this.QBX.TextChanged += new System.EventHandler(this.QBX_TextChanged);
            this.QBX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QBX_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(129, 505);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 87;
            this.label14.Text = "______";
            // 
            // SearchLBL
            // 
            this.SearchLBL.AutoSize = true;
            this.SearchLBL.BackColor = System.Drawing.Color.White;
            this.SearchLBL.Enabled = false;
            this.SearchLBL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLBL.ForeColor = System.Drawing.Color.White;
            this.SearchLBL.Location = new System.Drawing.Point(-2, 580);
            this.SearchLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchLBL.Name = "SearchLBL";
            this.SearchLBL.Size = new System.Drawing.Size(117, 20);
            this.SearchLBL.TabIndex = 89;
            this.SearchLBL.Text = "Search for a user.";
            this.SearchLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchLBL.Visible = false;
            // 
            // FNBox
            // 
            this.FNBox.BackColor = System.Drawing.Color.White;
            this.FNBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FNBox.Enabled = false;
            this.FNBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FNBox.ForeColor = System.Drawing.Color.White;
            this.FNBox.Location = new System.Drawing.Point(320, 580);
            this.FNBox.Margin = new System.Windows.Forms.Padding(2);
            this.FNBox.Name = "FNBox";
            this.FNBox.Size = new System.Drawing.Size(77, 18);
            this.FNBox.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(188, 499);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "TOTAL:";
            // 
            // PriceDetails
            // 
            this.PriceDetails.AutoSize = true;
            this.PriceDetails.BackColor = System.Drawing.Color.White;
            this.PriceDetails.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.PriceDetails.ForeColor = System.Drawing.Color.DimGray;
            this.PriceDetails.Location = new System.Drawing.Point(250, 490);
            this.PriceDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceDetails.Name = "PriceDetails";
            this.PriceDetails.Size = new System.Drawing.Size(71, 30);
            this.PriceDetails.TabIndex = 92;
            this.PriceDetails.Text = "00.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(231, 490);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 30);
            this.label7.TabIndex = 93;
            this.label7.Text = "₱";
            // 
            // PopupItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 598);
            this.ControlBox = false;
            this.Controls.Add(this.PriceDetails);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchLBL);
            this.Controls.Add(this.FNBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.QBX);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SearchBX);
            this.Controls.Add(this.SearchLine);
            this.Controls.Add(this.UsersDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.AddBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopupItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PopupItem_FormClosing);
            this.Load += new System.EventHandler(this.PopupItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBX;
        private System.Windows.Forms.Label SearchLine;
        private System.Windows.Forms.DataGridView UsersDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox QBX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label SearchLBL;
        private System.Windows.Forms.TextBox FNBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PriceDetails;
        private System.Windows.Forms.Label label7;
    }
}