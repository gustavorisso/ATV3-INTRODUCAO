using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btCorrigir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Conectado, boa sorte!");
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;

            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
    }


