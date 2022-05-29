using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Form1;

namespace WindowsFormsApp2.Conectare
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (panel4.Visible == true)
                    panel4.Visible = false;
                else panel4.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (panel4.Visible == true)
                panel4.Visible = false;
            else panel4.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == true)
                panel5.Visible = false;
            else panel5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form form1 = new CursaNoua();
            form1.ShowDialog();

            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form form1 = new P5();
            form1.ShowDialog();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form form1 = new P4();
            form1.ShowDialog();

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
           // panel2.BackgroundImage = Image.FromFile(fast);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel6.Hide();
        }
    }
}
