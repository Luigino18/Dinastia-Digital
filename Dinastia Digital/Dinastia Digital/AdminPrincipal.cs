using System;
using System.Windows.Forms;

namespace Dinastia_Digital
{
    public partial class AdminPrincipal : Form
    {
        public AdminPrincipal(string nombre)
        {
            InitializeComponent();
            LblNombres.Text = nombre;
            //TxtApellidos.Text = apellidos;
        }

        private void AdminPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            Form formulario = new Usuario();
            formulario.Show();
        }

        private void AdminPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            Form formulario = new Productos();
            formulario.Show();
        }
    }
}