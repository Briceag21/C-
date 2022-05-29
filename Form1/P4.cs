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
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.Form1
{
    public partial class P4 : Form
    {
        public P4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}
        protected string stringConnection;
        private IEnumerable<CursaModel> CursaList;
        private BindingSource CursaBindingSource;
        Conectar connect;
        private void button1_Click(object sender, EventArgs e)
        {
            int Comfort = Convert.ToInt16(comboBox1.Text);
            CursaBindingSource = new BindingSource();
            string stringConnection = "Data Source=DESKTOP-OEI8MF6;Initial Catalog=Garaferoviara;Integrated Security=True";
            connect = new Conectar(stringConnection);
             CursaList = connect.TryComfort(Comfort);
            CursaBindingSource.DataSource = CursaList; //set data source
            if (CursaList == null)
            {
                MessageBox.Show("Nu exista trenuri cu asa nivel de comfort");
            }
            else
            { dataGridView1.DataSource = CursaBindingSource; }  }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new Home();
            form1.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {}
        private void button3_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
                panel2.Visible = false;
            else panel2.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            CursaBindingSource = new BindingSource();
            string stringConnection = "Data Source=(local);Initial Catalog=Garaferoviara;Integrated Security=True";
            connect = new Conectar(stringConnection);
            CursaList = connect.CMCursa();
            CursaBindingSource.DataSource = CursaList; //set data source
           dataGridView1.DataSource = CursaBindingSource;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CursaBindingSource = new BindingSource();
            string stringConnection = "Data Source=(local);Initial Catalog=Garaferoviara;Integrated Security=True";
            connect = new Conectar(stringConnection);
         CursaList = connect.PretulMediu();
      dataGridView1.DataSource = CursaBindingSource;
 }}}
