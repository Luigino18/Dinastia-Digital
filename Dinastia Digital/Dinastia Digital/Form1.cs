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

namespace Dinastia_Digital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conex = new SqlConnection ("Data Source=localhost;Initial Catalog=Dinastia;Integrated Security=True"); /*Conexion a la base de datos*/

        public void logear (string identificacion, string contrasena)
        {
            try
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombres, Identificacion FROM usuarios WHERE identificacion = @identificacion AND Password = @pas",conex);
                cmd.Parameters.AddWithValue("identificacion", identificacion); /*lo que se ingresa por el formulario de logueo*/
                cmd.Parameters.AddWithValue("pas",contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

            if(dt.Rows.Count == 1)
                {
                    this.Hide();        /*Oculta el formulario de logueo*/
                    if (dt.Rows[0][1].ToString() == "1") /*[0][1] accede a select nombres, identificacion*/
                    {
                        new AdminPrincipal(dt.Rows[0][0].ToString()).Show();
                    } 
                    else if(dt.Rows[0][1].ToString() == "2")
                    {
                        new AdminSecundario(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Identificacion y/o Password Incorrecta");
                }           
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conex.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtIdentificacion.Clear();
            TxtPassword.Clear();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            logear(this.TxtIdentificacion.Text, this.TxtPassword.Text);
        }
    }
}
