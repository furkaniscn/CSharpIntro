namespace Project2
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
            lbxPet = new System.Windows.Forms.ListBox();
            lbxCart = new System.Windows.Forms.ListBox();
            lblPet = new System.Windows.Forms.Label();
            lblCart = new System.Windows.Forms.Label();
            btnAddPet = new System.Windows.Forms.Button();
            btnRemovePet = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbxPet
            // 
            lbxPet.FormattingEnabled = true;
            lbxPet.ItemHeight = 20;
            lbxPet.Location = new System.Drawing.Point(44, 56);
            lbxPet.Name = "lbxPet";
            lbxPet.Size = new System.Drawing.Size(328, 304);
            lbxPet.TabIndex = 0;
            lbxPet.SelectedIndexChanged += lbxPet_SelectedIndexChanged;
            // 
            // lbxCart
            // 
            lbxCart.FormattingEnabled = true;
            lbxCart.ItemHeight = 20;
            lbxCart.Location = new System.Drawing.Point(449, 56);
            lbxCart.Name = "lbxCart";
            lbxCart.Size = new System.Drawing.Size(339, 304);
            lbxCart.TabIndex = 1;
            lbxCart.SelectedIndexChanged += lbxCart_SelectedIndexChanged;
            // 
            // lblPet
            // 
            lblPet.AutoSize = true;
            lblPet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPet.Location = new System.Drawing.Point(44, 9);
            lblPet.Name = "lblPet";
            lblPet.Size = new System.Drawing.Size(66, 28);
            lblPet.TabIndex = 2;
            lblPet.Text = "lblPet";
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCart.Location = new System.Drawing.Point(462, 9);
            lblCart.Name = "lblCart";
            lblCart.Size = new System.Drawing.Size(76, 28);
            lblCart.TabIndex = 3;
            lblCart.Text = "lblCart";
            // 
            // btnAddPet
            // 
            btnAddPet.Location = new System.Drawing.Point(44, 375);
            btnAddPet.Name = "btnAddPet";
            btnAddPet.Size = new System.Drawing.Size(269, 29);
            btnAddPet.TabIndex = 4;
            btnAddPet.Text = "btnAddPet";
            btnAddPet.UseVisualStyleBackColor = true;
            btnAddPet.Click += btnAddPet_Click;
            // 
            // btnRemovePet
            // 
            btnRemovePet.Location = new System.Drawing.Point(449, 375);
            btnRemovePet.Name = "btnRemovePet";
            btnRemovePet.Size = new System.Drawing.Size(290, 29);
            btnRemovePet.TabIndex = 5;
            btnRemovePet.Text = "btnRemovePet";
            btnRemovePet.UseVisualStyleBackColor = true;
            btnRemovePet.Click += btnRemovePet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnRemovePet);
            Controls.Add(btnAddPet);
            Controls.Add(lblCart);
            Controls.Add(lblPet);
            Controls.Add(lbxCart);
            Controls.Add(lbxPet);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbxPet;
        private System.Windows.Forms.ListBox lbxCart;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Button btnRemovePet;
    }
}
