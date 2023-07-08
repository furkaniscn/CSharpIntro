namespace Project3
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
            lbxStudentList = new System.Windows.Forms.ListBox();
            lblStudentList = new System.Windows.Forms.Label();
            lblStudentName = new System.Windows.Forms.Label();
            tbxStudentName = new System.Windows.Forms.TextBox();
            btnAddStudent = new System.Windows.Forms.Button();
            btnRemoveStudent = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbxStudentList
            // 
            lbxStudentList.FormattingEnabled = true;
            lbxStudentList.ItemHeight = 20;
            lbxStudentList.Location = new System.Drawing.Point(32, 85);
            lbxStudentList.Name = "lbxStudentList";
            lbxStudentList.Size = new System.Drawing.Size(150, 284);
            lbxStudentList.TabIndex = 0;
            // 
            // lblStudentList
            // 
            lblStudentList.AutoSize = true;
            lblStudentList.Location = new System.Drawing.Point(32, 53);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new System.Drawing.Size(105, 20);
            lblStudentList.TabIndex = 1;
            lblStudentList.Text = "Öğrenci Listesi";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new System.Drawing.Point(249, 134);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new System.Drawing.Size(88, 20);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Öğrenci Adı";
            // 
            // tbxStudentName
            // 
            tbxStudentName.Location = new System.Drawing.Point(343, 134);
            tbxStudentName.Name = "tbxStudentName";
            tbxStudentName.Size = new System.Drawing.Size(266, 27);
            tbxStudentName.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new System.Drawing.Point(504, 178);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new System.Drawing.Size(105, 32);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "Ekle";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Location = new System.Drawing.Point(32, 384);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new System.Drawing.Size(150, 29);
            btnRemoveStudent.TabIndex = 5;
            btnRemoveStudent.Text = "Sil";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(tbxStudentName);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentList);
            Controls.Add(lbxStudentList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudentList;
        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
    }
}
