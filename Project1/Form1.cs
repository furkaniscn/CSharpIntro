using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string productsText = "Ürünler";
            lblProducts.Text = productsText;

            string addToCartButtonText = "Sepete Ekle";
            btnAddToCart.Text = addToCartButtonText;

            string cartText = "Sepetiniz";
            lblCart.Text = cartText;

            var removeFromCartButtonText = "Sepetten Çıkar";
            btnRemoveFromCart.Text = removeFromCartButtonText;

            string[] products = new string[]
            { "Laptop", "Masaüstü PC", "Klavye" };

            foreach (string product in products)
            {
                lbxProducts.Items.Add(product);
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }

            //for(int i = 0; i < products.Length; i++)
            //{
            //    lbxProducts.Items.Add(products[i]);
            //}

            //lbxProducts.Items.Add("Laptop");
            //lbxProducts.Items.Add("Masaüstü PC");
            //lbxProducts.Items.Add("Klavye");
        }

        private void lblCart_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                MessageBox.Show("Seçilen ürün sepete eklenmiştir.");
                btnRemoveFromCart.Enabled = true;
            }
            else
            {
                MessageBox.Show("Herhangi bir ürünü seçmediniz. Lütfen ürünü seçip sepete ekleyiniz.");
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if(lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
                MessageBox.Show("Seçilen ürün başarıyla sepetten çıkarılmıştır.");
                if (lbxCart.Items.Count == 0)
                {
                    btnRemoveFromCart.Enabled=false;
                }
            }
            //else if(lbxCart.Items.Count==0)
            //{
            //    btnRemoveFromCart.Enabled=false;
                
            //}
            else
            {
                MessageBox.Show("Herhangi bir ürünü seçmediniz. Lütfen ürünü seçtikten sonra butona tıklayınız.");
            }

            
        }
    }
}
