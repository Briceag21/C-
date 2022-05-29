using Google.Apis.Admin.Directory.directory_v1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Conectare;

namespace WindowsFormsApp2.Form1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {}
  private void button1_Click(object sender, EventArgs e)
        { string login = textBox1.Text;
            string password = textBox2.Text;
   string stringConnection= "Data Source=(local);Initial Catalog=Garaferoviara;Integrated Security=True";
            RepositoriuSql.Sql rep = new RepositoriuSql.Sql(stringConnection);
         //tryLogin bool
            bool succes = rep.tryLogin(login, password);
            //daca username si login exista
            if (succes)
            {
                this.Hide();

                Form form1 = new Home();
                form1.ShowDialog();

                this.Close();
            }
            //in caz contrar mesaj de avertizare
            else
                MessageBox.Show("Username or Password incorect!");  }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {}
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {} }
}
