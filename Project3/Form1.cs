using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> students;


        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>()
            {"Engin Demiroğ","Derin Demiroğ","Salih Demiroğ"};

            foreach (string student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (tbxStudentName.Text.Length >= 2)
            {
                students.Add(tbxStudentName.Text);
                lbxStudentList.Items.Clear();

                foreach (string student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
                MessageBox.Show("Öğrenci Ekleme Başarılı.");
            }
            else
            {
                MessageBox.Show("Öğrenci İsmi En Az İki Karakter Olmalıdır.");
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lbxStudentList.SelectedItem != null)
            {
                students.Remove(lbxStudentList.SelectedItem.ToString());

                lbxStudentList.Items.Clear();

                foreach (string student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
                MessageBox.Show("Öğrenci Silme Başarılı.");
            }
            else
            {
                MessageBox.Show("Herhangi Bir Öğrenciyi Seçmediniz. Lütfen Öğrenci Seçiniz.");
            }


        }
    }
}
