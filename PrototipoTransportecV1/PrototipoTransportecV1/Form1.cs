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

    public partial class Form1 : Form
    {
        //Data (Just for test porpuses because this is unacceptably unsafe):

        public String[] usersEmails = new String[] { "a01027322@itesm.mx", "santi@itesm.mx", "tester@itesm.mx", "karla@tec.mx"};
        public String[] usersPass = new String[] { "testDiego1", "testSanti1", "test", "testKarla1"};
        public String[] userNames = new String[] { "Diego", "Santi", "Tester", "Karla"};

        public String currentUser = "Usuario";
        public String currentMail = "none";

        public Form1()
        {
            InitializeComponent();
        }

        public String getCurrentUser() {

            return currentUser;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool userExists = false;
            bool userCorrect = false;
            int userIndex = -1;

            for (var i = 0; i < usersEmails.Length; i++) {

                if (usersEmails[i].Equals(textBox1.Text)) {

                    userExists = true;
                    userIndex = i;

                }

            }

            if (userExists) {

                if (usersPass[userIndex].Equals(textBox2.Text)) {

                    userCorrect = true;
                    currentUser = userNames[userIndex];
                    currentMail = usersEmails[userIndex];

                }

            }

            if (userCorrect)
            {

                Form2 x = new PrototipoTransportecV1.Form2();

                x.userName = currentUser;
                x.userEmail = currentMail;

                x.Show();

            }
            else if (userExists)
            {

                MessageBox.Show("Contraseña incorrecta. Vuélvalo a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {

                MessageBox.Show("El usuario " + textBox1.Text + " no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
