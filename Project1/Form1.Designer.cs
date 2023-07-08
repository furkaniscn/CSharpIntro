namespace Project1
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
            lbxProducts = new System.Windows.Forms.ListBox();
            lblProducts = new System.Windows.Forms.Label();
            btnAddToCart = new System.Windows.Forms.Button();
            lbxCart = new System.Windows.Forms.ListBox();
            lblCart = new System.Windows.Forms.Label();
            btnRemoveFromCart = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbxProducts
            // 
            lbxProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbxProducts.FormattingEnabled = true;
            lbxProducts.ItemHeight = 28;
            lbxProducts.Location = new System.Drawing.Point(30, 86);
            lbxProducts.Name = "lbxProducts";
            lbxProducts.Size = new System.Drawing.Size(192, 256);
            lbxProducts.TabIndex = 0;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblProducts.Location = new System.Drawing.Point(30, 53);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new System.Drawing.Size(77, 28);
            lblProducts.TabIndex = 1;
            lblProducts.Text = "Ürünler";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new System.Drawing.Point(228, 86);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new System.Drawing.Size(143, 33);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "button1";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lbxCart
            // 
            lbxCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbxCart.FormattingEnabled = true;
            lbxCart.ItemHeight = 28;
            lbxCart.Location = new System.Drawing.Point(404, 84);
            lbxCart.Name = "lbxCart";
            lbxCart.Size = new System.Drawing.Size(181, 256);
            lbxCart.TabIndex = 3;
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCart.Location = new System.Drawing.Point(404, 53);
            lblCart.Name = "lblCart";
            lblCart.Size = new System.Drawing.Size(92, 28);
            lblCart.TabIndex = 4;
            lblCart.Text = "Sepetiniz";
            lblCart.Click += lblCart_Click;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new System.Drawing.Point(591, 86);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new System.Drawing.Size(124, 29);
            btnRemoveFromCart.TabIndex = 5;
            btnRemoveFromCart.Text = "button1";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(lblCart);
            Controls.Add(lbxCart);
            Controls.Add(btnAddToCart);
            Controls.Add(lblProducts);
            Controls.Add(lbxProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbxProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.ListBox lbxCart;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
    }
}
