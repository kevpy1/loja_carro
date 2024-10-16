using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace loja_carro
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
            textBox1.Clear();
            txbprec3.Checked = false; 
            txbprec2.Checked = false; 
            txbprec1.Checked = false; 
            txbPicape.Checked = false;
            txbSUV.Checked = false;
            txbSedã.Checked = false;
            txbcat1.Checked = false;
            txbToyotaCross.Checked = false;
            txbSubarufor.Checked = false;
            txbFordMaverick.Checked = false;
            txbNissanleaf.Checked = false;
            txbtoyot.Checked = false;
            txbprec4.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void objetivo_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbObjetivo_Click(object sender, EventArgs e)
        {

        }

        private void cbxmodelo_Click(object sender, EventArgs e)
        {

        }

        private void txbpreço_Click(object sender, EventArgs e)
        {

        }

        private void txbcar2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string marca = cbxMarca.Text;
           

        }
    }
}
