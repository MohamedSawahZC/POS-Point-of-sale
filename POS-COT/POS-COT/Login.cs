using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSawah
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
            pictureBox2.Image = Properties.Resources.user2;
            panel1.ForeColor = Color.Cyan;
            textBox1.ForeColor = Color.Cyan;
            //----------------------------------------------
            pictureBox3.Image = Properties.Resources.pass;
            panel2.ForeColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            
               
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            pictureBox3.Image = Properties.Resources.pass2;
            panel1.ForeColor = Color.Cyan;
            textBox1.ForeColor = Color.Cyan;
            //----------------------------------------------
            pictureBox2.Image = Properties.Resources.user;
            panel1.ForeColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/MohamedSawahZC/");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "MohamedSawah" || textBox2.Text != "@Sawah.142001")
            {
                label2.Text = "Invalid Username or password";

            }
            else
            {
                Dashboard f = new Dashboard();
                f.Show();
            }
        }
    }
}   
