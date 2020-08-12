using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator(100);

            calc.Add(155);

            listBoxData.Items.Add(calc.ToString() + " = 0x" + calc.Hex);

            calc.Multiply(16);
            listBoxData.Items.Add(calc.ToString() + " = 0x" + calc.Hex);
            if (calc.Value > 256)
            {
                calc.Clear();
            }
            calc.Add(7);
            calc.Multiply(256);
            calc.Add(7);
            listBoxData.Items.Add(calc.ToString() + " = 0x" + calc.Binary);
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            Pen pen1 = new Pen(Color.Blue, 2);
            Student s1 = new Student(103, "Brown", "Smoke");
            Student s2 = new Student(101, "Doe", "John");
            Student s3 = new Student(102, "Brown", "Mark");
            Student s4 = null;

            //listBoxData.Items.Add(s2.Id + " " + s2.Firstname + " " + s2.Surname + " " + s2.Haspaid);
            //listBoxData.Items.Add(s1.ToString());
            //listBoxData.Items.Add(s2.ToString());
            //listBoxData.Items.Add(s3.ToString());

            //check if s4 has an object
            //if(s4 !=null)
            //{
            //    MessageBox.Show("It is point ing to an object");
            //}
            //else
            //{
            //    MessageBox.Show("s4 is null");
            //}
        }
    }
}
