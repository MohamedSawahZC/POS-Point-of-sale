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
    public partial class Adduser : Form
    {
        private bool isAdmin;
        public Adduser()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {
            bunifuTextBox3.PasswordChar = '*';
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Users.Insert(bunifuTextBox1.Text, bunifuTextBox2.Text, bunifuTextBox3.Text, bunifuTextBox4.Text,isAdmin, bunifuTextBox5.Text, bunifuTextBox6.Text);
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if(bunifuCheckbox1.Checked)
            {
                isAdmin = true;
            }
            else
            {
                isAdmin = false;
            }
            
        }
    }
}
