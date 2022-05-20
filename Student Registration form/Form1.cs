using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
            label3.Text = textBox2.Text;
            label4.Text = textBox3.Text;

            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Student name: " + textBox2.Text + " " + textBox3.Text + " " + textBox1.Text + " \n Gender: " + radioButton1.Text + " \n Birthday: " + comboBox2.Text + "/" + comboBox1.Text + "/" + comboBox3.Text + " \n Program: " + comboBox4.Text, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Student name: " + textBox2.Text + " " + textBox3.Text + " " + textBox1.Text + " \n Gender: " + radioButton2.Text + " \n Birthday: " + comboBox2.Text + "/" + comboBox1.Text + "/" + comboBox3.Text + " \n Program: " + comboBox4.Text, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " (*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                textBox4.Text = openFileDialog1.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
