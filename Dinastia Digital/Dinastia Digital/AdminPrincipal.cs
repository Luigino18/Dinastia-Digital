using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinastia_Digital
{
    public partial class AdminPrincipal : Form
    {
        public AdminPrincipal(string nombre)
        {
            InitializeComponent();
            LblAdmin.Text = nombre;
            //TxtApellidos.Text = apellidos;
        }

        private void AdminPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
