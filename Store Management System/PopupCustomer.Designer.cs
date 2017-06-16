namespace Midterm_Exam {
    partial class PopupCustomer {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.PopupTMR = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
            this.SearchBX = new System.Windows.Forms.TextBox();
            this.SearchLine = new System.Windows.Forms.Label();
            this.FNBox = new System.Windows.Forms.TextBox();
            this.SearchLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
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
            this.CancelBTN.Location = new System.Drawing.Point(201, 544);
            this.CancelBTN.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(114, 30);
            this.CancelBTN.TabIndex = 14;
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
            this.AddBTN.Location = new System.Drawing.Point(74, 544);
            this.AddBTN.Margin = new System.Windows.Forms.Padding(2);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(114, 30);
            this.AddBTN.TabIndex = 13;
            this.AddBTN.Text = "SELECT";
            this.AddBTN.UseVisualStyleBackColor = false;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // PopupTMR
            // 
            this.PopupTMR.Interval = 1;
            this.PopupTMR.Tick += new System.EventHandler(this.PopupTMR_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select a customer";
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.AllowUserToAddRows = false;
            this.UsersDataGrid.AllowUserToDeleteRows = false;
            this.UsersDataGrid.AllowUserToResizeColumns = false;
            this.UsersDataGrid.AllowUserToResizeRows = false;
            this.UsersDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            this.UsersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UsersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.UsersDataGrid.EnableHeadersVisualStyles = false;
            this.UsersDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.UsersDataGrid.Location = new System.Drawing.Point(28, 97);
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
            this.UsersDataGrid.Size = new System.Drawing.Size(345, 428);
            this.UsersDataGrid.TabIndex = 76;
            this.UsersDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGrid_CellClick);
            this.UsersDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGrid_CellClick);
            this.UsersDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.UsersDataGrid_CellFormatting);
            // 
            // SearchBX
            // 
            this.SearchBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            this.SearchBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBX.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBX.ForeColor = System.Drawing.Color.White;
            this.SearchBX.Location = new System.Drawing.Point(109, 62);
            this.SearchBX.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBX.Name = "SearchBX";
            this.SearchBX.Size = new System.Drawing.Size(178, 18);
            this.SearchBX.TabIndex = 77;
            this.SearchBX.Text = "Search or filter result.";
            this.SearchBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchBX.TextChanged += new System.EventHandler(this.SearchBX_TextChanged);
            this.SearchBX.Enter += new System.EventHandler(this.SearchBX_Enter);
            this.SearchBX.Leave += new System.EventHandler(this.SearchBX_Leave);
            // 
            // SearchLine
            // 
            this.SearchLine.AutoSize = true;
            this.SearchLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            this.SearchLine.ForeColor = System.Drawing.Color.White;
            this.SearchLine.Location = new System.Drawing.Point(106, 71);
            this.SearchLine.Name = "SearchLine";
            this.SearchLine.Size = new System.Drawing.Size(181, 13);
            this.SearchLine.TabIndex = 78;
            this.SearchLine.Text = "_____________________________";
            this.SearchLine.Visible = false;
            // 
            // FNBox
            // 
            this.FNBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            this.FNBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FNBox.Enabled = false;
            this.FNBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FNBox.ForeColor = System.Drawing.Color.White;
            this.FNBox.Location = new System.Drawing.Point(324, 580);
            this.FNBox.Margin = new System.Windows.Forms.Padding(2);
            this.FNBox.Name = "FNBox";
            this.FNBox.Size = new System.Drawing.Size(77, 18);
            this.FNBox.TabIndex = 79;
            // 
            // SearchLBL
            // 
            this.SearchLBL.AutoSize = true;
            this.SearchLBL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            this.SearchLBL.Location = new System.Drawing.Point(2, 580);
            this.SearchLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchLBL.Name = "SearchLBL";
            this.SearchLBL.Size = new System.Drawing.Size(117, 20);
            this.SearchLBL.TabIndex = 80;
            this.SearchLBL.Text = "Search for a user.";
            this.SearchLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchLBL.Visible = false;
            // 
            // PopupCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(149)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(398, 598);
            this.ControlBox = false;
            this.Controls.Add(this.SearchLBL);
            this.Controls.Add(this.FNBox);
            this.Controls.Add(this.SearchBX);
            this.Controls.Add(this.SearchLine);
            this.Controls.Add(this.UsersDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.AddBTN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopupCustomer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PopupCustomer_FormClosing);
            this.Load += new System.EventHandler(this.PopupCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Timer PopupTMR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UsersDataGrid;
        private System.Windows.Forms.TextBox SearchBX;
        private System.Windows.Forms.Label SearchLine;
        private System.Windows.Forms.TextBox FNBox;
        private System.Windows.Forms.Label SearchLBL;
    }
}