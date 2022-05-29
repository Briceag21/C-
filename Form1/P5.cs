using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;
using WindowsFormsApp2.Conectare;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2.Conectare
{ public partial class P5 : Form
    { public P5()
        {
            InitializeComponent();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}
        private void P5_Load(object sender, EventArgs e)
        { this.orarTableAdapter.Fill(this.garaferoviaraDataSet1.Orar);}
        private IEnumerable<CursaModel> CursaList;
        private BindingSource CursaBindingSource;
        Conectar connect;
  private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {}

        private void panel3_Paint(object sender, PaintEventArgs e)
        {}
        private void button1_Click(object sender, EventArgs e)
        {  int Gara2 = (int)numericUpDown1.Value;
            int Orar = (int)numericUpDown2.Value;
            //conectarea la baza de date
            CursaBindingSource = new BindingSource();
            string stringConnection = "Data Source=(local);Initial Catalog=Garaferoviara;Integrated Security=True";
            connect = new Conectar(stringConnection);
            CursaList = connect.TryOrar(Gara2, Orar);
            CursaBindingSource.DataSource = CursaList;
            if (CursaList == null)
            {
                MessageBox.Show("Nu exista curse spre punctul destinatiei cu acest orar");
            }
            else
            { dataGridView1.DataSource = CursaBindingSource;
                dataGridView1.Visible = true;}}
       private void button2_Click(object sender, EventArgs e)
        { this.Hide();
            Form form1 = new Home();
            form1.ShowDialog();
            this.Close();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {} }} 
