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

namespace PrototipoTransportecV1
{
    public partial class Form6 : Form
    {
        public String currentReport = "none";

        public String currentUser = "none";

        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
            SqlConnection con = new SqlConnection("Data Source=ALIENPUAS;Initial Catalog=EF;Integrated Security=True");

            String query = "INSERT INTO dbo.Tabla_comentarios (IDcomentario,usuario,texto,fecha,hora,IDreporte) VALUES (@IDcomentario,@usuario,@texto,@fecha,@hora,@IDreporte)";

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.Add("@IDcomentario", "R" + new Random().Next(100, 999));
            command.Parameters.Add("@usuario", currentUser);
            command.Parameters.Add("@texto", textBox1.Text);
            command.Parameters.Add("@fecha", DateTime.Now.ToString("yyyy-MM-dd"));
            command.Parameters.Add("@hora", DateTime.Now.ToString("HH:mm"));
            command.Parameters.Add("@IDreporte", currentReport);
            //command.Parameters.Add("@email", "a01027322@itesm.mx,santi@itesm.mx");


            con.Open();
            int i = command.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                //MessageBox.Show(i + "Data Saved");

                MessageBox.Show("Comentario publicado exitosamente", "Comentario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            //this.Close();
        }

        private void tabla_comentariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabla_comentariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eFDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eFDataSet.Tabla_comentarios' table. You can move, or remove it, as needed.
            this.tabla_comentariosTableAdapter.Fill(this.eFDataSet.Tabla_comentarios);

            //Load Tabla Comentarios:
            try
            {
                this.tabla_comentariosTableAdapter.SearchComentario(this.eFDataSet.Tabla_comentarios, currentReport);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void iDcomentarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void textoLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchComentarioToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabla_comentariosTableAdapter.SearchComentario(this.eFDataSet.Tabla_comentarios, iDreporteToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
