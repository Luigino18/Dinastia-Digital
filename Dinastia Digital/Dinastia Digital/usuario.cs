using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dinastia_Digital.Models;

namespace Dinastia_Digital
{
    public partial class Usuario : Form
    {

        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        private void Refrescar()
        {
            using (DinastiaEntities3 db = new DinastiaEntities3())
            {
                var lst = from d in db.Usuarios
                          select d;
                Dtg.DataSource = lst.ToList();  /*Muestra en dtg la lista que tengo en sql server*/
            }
        }

        private int? GetIdentificacion()
        {
            try
            {
                return int.Parse(Dtg.Rows[Dtg.CurrentRow.Index].Cells[1].Value.ToString());
            }
            catch
            {
                return null;
            }

        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Presentation.FrmTablas ofrmTablas = new Presentation.FrmTablas();
            ofrmTablas.ShowDialog();

            Refrescar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int? Identificacion = GetIdentificacion();
            if (Identificacion != null)
            {
                Presentation.FrmTablas oFrmTablas = new Presentation.FrmTablas(Identificacion);
                oFrmTablas.ShowDialog();

                Refrescar();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? Identificacion = GetIdentificacion();
            if (Identificacion != null)
            {
                using (DinastiaEntities3 db = new DinastiaEntities3())
                {
                    Usuarios oUsuarios = db.Usuarios.Find(Identificacion);
                    db.Usuarios.Remove(oUsuarios);

                    db.SaveChanges();
                }
                Refrescar();
            }
        }
    }
}