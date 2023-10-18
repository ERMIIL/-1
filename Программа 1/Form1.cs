using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Программа_1
{
    public partial class Form1 : Form
    {
        string year;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date1;
            

            date1 = DateTime.Now.ToString().Substring(6, 4);
            int cif1 = Convert.ToInt32(date1);
            int cif2 = Convert.ToInt32(year);
            int otvet = cif1 - cif2;
            date1 = Convert.ToString(otvet);

            textBox6.Text =  textBox4.Text + " " + textBox5.Text + " в возрасте " + date1 + " Лет";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            year = e.Start.ToString().Substring(6,4);
        }
    }
}
