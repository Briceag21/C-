using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Models;
using WindowsFormsApp2.Conectare;
using System.Windows.Forms;

namespace WindowsFormsApp2.Form1
{ public partial class CursaNoua : Form
    { public CursaNoua()
        {InitializeComponent(); }
        //fields
        private IEnumerable<CursaModel> CursaList;
        private BindingSource CursaBindingSource;
        Conectar connect;
        private void CursaNoua_Load(object sender, EventArgs e)
        { }
        private void label1_Click(object sender, EventArgs e)
        {}
      private void label5_Click(object sender, EventArgs e)
        {}
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {}
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {}
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {}
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {}
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {}
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {}
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
        private void button1_Click(object sender, EventArgs e)
        {
            //variabila de tip model
            var model = new CursaModel();
            if (numericUpDown1.Value == numericUpDown2.Value)
            {
                MessageBox.Show("Cursa nu poate fi inceputa si finisata in aceiasi gara .Reintroduceti datele va rog ");
            }
            else { 
                //adaugarea in model datele necesare
                //  model.Id = (int)numericUpDown4.Value;
                model.IdGara1 = (int)numericUpDown1.Value;
            model.IdGara2 = (int)numericUpDown2.Value;
            model.Pret = Convert.ToInt16(comboBox1.Text);
            model.IdOrar = (int)numericUpDown3.Value;
            model.COmfort = Convert.ToInt16(comboBox2.Text);
            model.IDTren = Convert.ToInt16(comboBox3.Text);
            if (radioButton1.Checked)
                model.Stare = "Anulata";
            else if (radioButton2.Checked)
                model.Stare = "Neanulata";

            int maxIdTren = 10;
            int minIdTren = 1;
            int maxIdOrar = 40;
            int minIdOrar = 1;
            int maxIdGara1 = 20;
            int minIdGara1 = 1;
            int minIdGara2 = 1;
            int maxIdGara2 = 20;
            int minComfort = 1;
            int maxComfort = 10;

            //conectarea la baza de date
            CursaBindingSource = new BindingSource();
            string stringConnection = "Data Source=(local);Initial Catalog=Garaferoviara;Integrated Security=True";
            connect = new Conectar(stringConnection);
            //afisam un messageBox daca vrem sa afisam toate tabelele
            if (MessageBox.Show("Afisati toate tabelele?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               connect.Add(model);
                CursaList = connect.GetAll();
                CursaBindingSource.DataSource = CursaList; //set data source
                dataGridView1.DataSource = CursaBindingSource;
                dataGridView1.Visible = true;
            }}}

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CursaBindingSource = new BindingSource();
            string stringConnection = "Data Source=(local);Initial Catalog=Garaferoviara;Integrated Security=True";
            connect = new Conectar(stringConnection);
            if (MessageBox.Show("Afisati toate tabelele?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { connect.Delete((int)numericUpDown4.Value);
                CursaList = connect.GetAll();
                CursaBindingSource.DataSource = CursaList; //set data source
                dataGridView1.DataSource = CursaBindingSource;
             dataGridView1.Visible = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {panel3.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
            else panel1.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {panel1.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
            else panel3.Visible = true;
       }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {}
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new Home();
            form1.ShowDialog();
            this.Close();
        }
    }
}
