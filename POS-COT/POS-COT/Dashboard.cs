using System;
using System.Windows.Forms;
using Bunifu;

namespace POSSawah
{
    public partial class Dashboard : Form
    {

        private bool isCollapsed;
        public Dashboard()
        {
            InitializeComponent();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Rows.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuToggleSwitch1_OnValuechange(object sender, EventArgs e)
        {
           
        }

        private void bunifuShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void analysis1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            bunifuTextBox1.Clear();
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                bunifuFlatButton1.Iconimage_right = Properties.Resources.UpArrow;
                panelDropdown.Height += 10;
                if (panelDropdown.Size==panelDropdown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                bunifuFlatButton1.Iconimage_right = Properties.Resources.DownArrow;
                panelDropdown.Height -= 10;
                if (panelDropdown.Size == panelDropdown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(4);

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            Adduser f = new Adduser();
            f.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AddCustomer f = new AddCustomer();
            f.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
