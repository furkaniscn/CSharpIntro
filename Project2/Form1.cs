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

            Pet pet1 = new Pet();
            pet1.PetName = "Köpek";
            Pet pet2 = new Pet();
            pet2.PetName = "Kedi";
            Pet pet3 = new Pet();
            pet3.PetName = "Maymun";
            Pet pet4 = new Pet();
            pet4.PetName = "Yılan";
            Pet pet5 = new Pet();
            pet5.PetName = "Koyun";
            Pet pet6 = new Pet();
            pet6.PetName = "İnek";


            List<Pet> pets = new List<Pet>()
            {
                pet1, pet2, pet3, pet4, pet5, pet6
            };
            //string[] pets = { "Kedi", "Köpek", "Fil", "Maymun", "Yarasa" };

            foreach (Pet pet in pets)
            {
                lbxPet.Items.Add(pet.PetName);
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
