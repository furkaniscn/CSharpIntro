using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //List<string> isimler = new List<string>()
            //{ "Engin", "Derin", "Salih"};
            //List<int> yaslar = new List<int>()
            //{35,36,23};
            //List<string> mail = new List<string>()
            //{"engin@outlook.com", "derin@outlook.com", "salih@outlook.com" };

            //for(int i = 0; i < 3; i++)
            //{
            //    MessageBox.Show(isimler[i] + " " + yaslar[i] + " " + mail[i]);
            //}


            Student student1 = new Student();
            student1.FirstName = "Furkan";
            student1.Age = 22;
            student1.Mail = "furkan@outlook.com";

            Student student2 = new Student();
            student2.FirstName = "Engin";
            student2.Age = 29;
            student2.Mail = "engin@outlook.com";

            Student student3 = new Student();
            student3.FirstName = "Derin";
            student3.Age = 12;
            student3.Mail = "derin@outlook.com";

            List<Student> students = new List<Student>()
            {student1, student2, student3 };

            foreach (Student student in students)
            {
                //MessageBox.Show(student.FirstName + " " + student.Age + " " + student.Mail);
                lbxStudents.Items.Add(student.FirstName);
            }

            dgrwStudents.DataSource = students;

        }
    }
}
