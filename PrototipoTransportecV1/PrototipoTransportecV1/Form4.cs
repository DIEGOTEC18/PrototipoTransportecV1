using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace PrototipoTransportecV1
{
    public partial class Form4 : Form
    {

        public String currentRuta = "Z";

        public int registrados = 0;
        public int activos = 0;
        public String IdReporte = "-1";

        public String creator = "none";

        public int favorite = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 x = new PrototipoTransportecV1.Form5();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 x = new PrototipoTransportecV1.Form2();
            x.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 x = new PrototipoTransportecV1.Form6();

            x.currentReport = IdReporte;

            x.currentUser = creator;

            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 x = new PrototipoTransportecV1.Form3();
            x.Show();
        }

        private void tabla_rutasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabla_rutasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eFDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
     
            // TODO: This line of code loads data into the 'eFDataSet.Tabla_asistencias' table. You can move, or remove it, as needed.
            this.tabla_asistenciasTableAdapter.Fill(this.eFDataSet.Tabla_asistencias);
            // TODO: This line of code loads data into the 'eFDataSet.Tabla_rutas' table. You can move, or remove it, as needed.
            this.tabla_rutasTableAdapter.Fill(this.eFDataSet.Tabla_rutas);

            if (favorite == 0)
            {

                button4.BackgroundImage = PrototipoTransportecV1.Properties.Resources.unlikedStar;

            }
            else
            {

                button4.BackgroundImage = PrototipoTransportecV1.Properties.Resources.likedStar;

            }

            if (IdReporte.Equals("-1")) {

                IdReporte = "R" + new Random().Next(1000, 9999);

            }

            label2.Text = "Ruta: " + currentRuta;

            label3.Text = registrados.ToString();

            label7.Text = ((new Random().Next(20, 100)).ToString()) + "%";

            textBox1.Text = "Reporte " + IdReporte;

            try
            {
                this.tabla_rutasTableAdapter.SearchRuta1(this.eFDataSet.Tabla_rutas, currentRuta);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            //Table:

            try
            {
                this.tabla_asistenciasTableAdapter.SearchAsistencias(this.eFDataSet.Tabla_asistencias, currentRuta);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            label5.Text = tabla_asistenciasDataGridView.RowCount.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iDrutaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void origenLabel1_Click(object sender, EventArgs e)
        {

        }

        private void searchrutaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabla_rutasTableAdapter.searchruta(this.eFDataSet.Tabla_rutas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchrutaToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void searchRuta1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabla_rutasTableAdapter.SearchRuta1(this.eFDataSet.Tabla_rutas, iDrutaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchAsistenciasToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabla_asistenciasTableAdapter.SearchAsistencias(this.eFDataSet.Tabla_asistencias, iDrutaToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabla_asistenciasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Screenshot:
            /*
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                bitmap.Save("c://My_Img.jpeg", ImageFormat.Jpeg);
            }
            */
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
            //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
            SqlConnection con = new SqlConnection("Data Source=ALIENPUAS;Initial Catalog=EF;Integrated Security=True");

            String query = "INSERT INTO dbo.Tabla_reporte (IDreporte,creador,nombreReporte,favorito,filtros) VALUES (@IDreporte,@creador,@nombreReporte,@favorito,@filtros)";

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.Add("@IDreporte", IdReporte);
            command.Parameters.Add("@creador", creator);
            command.Parameters.Add("@nombreReporte", textBox1.Text);
            command.Parameters.Add("@favorito", favorite);
            command.Parameters.Add("@filtros", currentRuta);
            //command.Parameters.Add("@email", "a01027322@itesm.mx,santi@itesm.mx");


            con.Open();
            int i = command.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                //MessageBox.Show(i + "Data Saved");

                MessageBox.Show("Reporte Guardado Exitosamente", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (favorite == 0)
            {

                favorite = 1;
                button4.BackgroundImage = PrototipoTransportecV1.Properties.Resources.likedStar;

            }
            else {

                favorite = 0;
                button4.BackgroundImage = PrototipoTransportecV1.Properties.Resources.unlikedStar;

            }

        }
    }
}
