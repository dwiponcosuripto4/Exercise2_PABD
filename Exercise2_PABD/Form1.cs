using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_PABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagrid.Form1 formPanggil = new datagrid.Form1();
            formPanggil.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataBinding.Form1 formPanggil = new DataBinding.Form1();
            formPanggil.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
