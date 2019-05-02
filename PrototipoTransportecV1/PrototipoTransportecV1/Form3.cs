using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoTransportecV1
{
    public partial class Form3 : Form
    {
        public String currentUser = "none";

        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eFDataSet.Tabla_alumnos' table. You can move, or remove it, as needed.
            this.tabla_alumnosTableAdapter.Fill(this.eFDataSet.Tabla_alumnos);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (tabla_alumnosDataGridView.Visible == true)
            {

                tabla_alumnosDataGridView.Visible = false;

            }
            else {

                tabla_alumnosDataGridView.Visible = true;

            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 x = new PrototipoTransportecV1.Form4();

            x.registrados = tabla_alumnosDataGridView.RowCount;

            x.currentRuta = comboBox1.Text;

            x.creator = currentUser;

            x.Show();
        }

        private void tabla_alumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabla_alumnosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eFDataSet);

        }

        private void tabla_alumnosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rutaToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla_alumnosDataGridView.DataSource;
            bs.Filter = "ruta" + " like '%" + comboBox1.Text + "%'";
            tabla_alumnosDataGridView.DataSource = bs;

        }
    }
}
