namespace Project4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgrwCustomers = new System.Windows.Forms.DataGridView();
            tbxId = new System.Windows.Forms.TextBox();
            tbxFirstName = new System.Windows.Forms.TextBox();
            tbxLastName = new System.Windows.Forms.TextBox();
            tbxEmail = new System.Windows.Forms.TextBox();
            tbxCity = new System.Windows.Forms.TextBox();
            lblId = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            gbxAdd = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).BeginInit();
            gbxAdd.SuspendLayout();
            SuspendLayout();
            // 
            // dgrwCustomers
            // 
            dgrwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            dgrwCustomers.Location = new System.Drawing.Point(0, 0);
            dgrwCustomers.Name = "dgrwCustomers";
            dgrwCustomers.RowHeadersWidth = 51;
            dgrwCustomers.RowTemplate.Height = 29;
            dgrwCustomers.Size = new System.Drawing.Size(1255, 142);
            dgrwCustomers.TabIndex = 0;
            dgrwCustomers.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tbxId
            // 
            tbxId.Location = new System.Drawing.Point(97, 26);
            tbxId.Name = "tbxId";
            tbxId.Size = new System.Drawing.Size(169, 34);
            tbxId.TabIndex = 1;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new System.Drawing.Point(97, 80);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new System.Drawing.Size(169, 34);
            tbxFirstName.TabIndex = 2;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new System.Drawing.Point(97, 140);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new System.Drawing.Size(169, 34);
            tbxLastName.TabIndex = 3;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new System.Drawing.Point(97, 205);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new System.Drawing.Size(169, 34);
            tbxEmail.TabIndex = 4;
            // 
            // tbxCity
            // 
            tbxCity.Location = new System.Drawing.Point(97, 266);
            tbxCity.Name = "tbxCity";
            tbxCity.Size = new System.Drawing.Size(169, 34);
            tbxCity.TabIndex = 5;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(25, 33);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(29, 28);
            lblId.TabIndex = 6;
            lblId.Text = "Id";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(25, 87);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(42, 28);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "Adı";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(25, 147);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(72, 28);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Soyadı";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(25, 212);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(50, 28);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Mail";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new System.Drawing.Point(25, 273);
            lblCity.Name = "lblCity";
            lblCity.Size = new System.Drawing.Size(56, 28);
            lblCity.TabIndex = 10;
            lblCity.Text = "Şehir";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(325, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(147, 35);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(tbxId);
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(tbxFirstName);
            gbxAdd.Controls.Add(lblCity);
            gbxAdd.Controls.Add(tbxLastName);
            gbxAdd.Controls.Add(lblEmail);
            gbxAdd.Controls.Add(tbxEmail);
            gbxAdd.Controls.Add(lblLastName);
            gbxAdd.Controls.Add(tbxCity);
            gbxAdd.Controls.Add(lblFirstName);
            gbxAdd.Controls.Add(lblId);
            gbxAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gbxAdd.Location = new System.Drawing.Point(12, 148);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new System.Drawing.Size(603, 322);
            gbxAdd.TabIndex = 12;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Ekle";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1255, 469);
            Controls.Add(gbxAdd);
            Controls.Add(dgrwCustomers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgrwCustomers;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxAdd;
    }
}
