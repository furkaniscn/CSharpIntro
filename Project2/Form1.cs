using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string petsText = "Hayvanlar";
            string cartText = "Seçilen Hayvanlar";
            string btnAddPetText = "Sahiplenmek İstediğin Hayvanı Seç";
            string btnRemovePetText = "Çıkarmak İstediğin Hayvanı Seç";

            lblPet.Text = petsText;
            lblCart.Text = cartText;
            btnAddPet.Text = btnAddPetText;
            btnRemovePet.Text = btnRemovePetText;

            string[] pets = { "Kedi", "Köpek", "Fil", "Maymun", "Yarasa" };

            foreach (string pet in pets)
            {
                lbxPet.Items.Add(pet);
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemovePet.Enabled = false;
            }

        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            if (lbxPet.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxPet.SelectedItem);
                MessageBox.Show("Seçilen Hayvan Listeye Eklenmiştir");
                lbxPet.Items.Remove(lbxPet.SelectedItem);
                btnRemovePet.Enabled = true;

            }
            else
            {
                MessageBox.Show("Herhangi Bir Hayvan Seçmediniz. Lütfen Hayvan Seçiniz.");
            }          
        }

        private void btnRemovePet_Click(object sender, EventArgs e)
        {
            if(lbxCart.SelectedItem != null)
            {
                lbxPet.Items.Add(lbxCart.SelectedItem);
                //string seciliHayvan = lbxCart.SelectedItem.ToString();
                lbxCart.Items.Remove(lbxCart.SelectedItem);
                MessageBox.Show("Seçilen Hayvan Listeden Çıkarılmıştır");
            }
            else
            {
                MessageBox.Show("Herhangi Bir Hayvanı Seçmediniz. Lütfen Listeden Çıkartacağınız Hayvanı Seçiniz");
            }

            if (lbxPet.Items.Count <= 0)
            {
                btnAddPet.Enabled = false;
            }
            else
            {
                btnAddPet.Enabled = true;
            }
        }

        private void lbxCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxCart.Items.Count == 0)
            {
                btnRemovePet.Enabled = false;
            }
        }

        private void lbxPet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxPet.Items.Count == 0)
            {
                btnAddPet.Enabled = false;
            }
        }
    }
}
