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
    public partial class Form2 : Form
    {
        public String userName = "Jeje";
        public String userEmail = "none";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 x = new PrototipoTransportecV1.Form3();

            x.currentUser = userEmail;

            x.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eFDataSet.Tabla_alumnos' table. You can move, or remove it, as needed.
            this.tabla_alumnosTableAdapter.Fill(this.eFDataSet.Tabla_alumnos);
            // TODO: This line of code loads data into the 'eFDataSet.Tabla_reporte' table. You can move, or remove it, as needed.
            this.tabla_reporteTableAdapter.Fill(this.eFDataSet.Tabla_reporte);

            //Form1 form1 = new Form1();

            label1.Text = "Bienvenido " + userName;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabla_reporteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabla_reporteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eFDataSet);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla_reporteDataGridView.DataSource;
            bs.Filter = "nombreReporte" + " like '%" + textBox1.Text + "%'";
            tabla_reporteDataGridView.DataSource = bs;

        }

        private void Tabla_reporteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            String value = tabla_reporteDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

            //MessageBox.Show(value);

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla_alumnosDataGridView.DataSource;
            bs.Filter = "ruta" + " like '%" + value + "%'";
            tabla_alumnosDataGridView.DataSource = bs;

            Form4 x = new PrototipoTransportecV1.Form4();

            x.registrados = tabla_alumnosDataGridView.RowCount;

            x.currentRuta = value;

            x.creator = userEmail;

            x.IdReporte = tabla_reporteDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            x.favorite = Convert.ToInt32(tabla_reporteDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());

            x.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void alumniSearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabla_alumnosTableAdapter.AlumniSearch(this.eFDataSet.Tabla_alumnos, rutaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
