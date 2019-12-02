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
    public partial class AdminSecundario : Form
    {
        public AdminSecundario(string nombre)
        {
            InitializeComponent();
            LblAdministrador.Text = nombre;

        }

        private void AdminSecundario_Load(object sender, EventArgs e)
        {

        }
    }
}
