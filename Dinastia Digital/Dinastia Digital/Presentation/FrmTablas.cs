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
using System.Data.SqlClient;

namespace Dinastia_Digital.Presentation
{
    public partial class FrmTablas : Form
    {
        public int? Identificacion;
        Usuarios oUsuarios = null;
        public FrmTablas(int? Identificacion=null)
        {
            InitializeComponent();
            this.Identificacion = Identificacion;

            if(Identificacion != null)
            {
                CargaDatos();
            }
        }

        conexion con = new conexion();

        private void CargaDatos()
        {
            using (DinastiaEntities2 db = new DinastiaEntities2())
            {
                
                oUsuarios = db.Usuarios.Find(Identificacion);
                CbTipoIdentificacion.Text = oUsuarios.TipoIdentificacion;
                TxtIdentificacion.Text = Convert.ToString(oUsuarios.Identificacion);
                TxtNombres.Text = oUsuarios.Nombres;
                TxtPassword.Text = oUsuarios.Password;
                TxtCorreo.Text = oUsuarios.Correo;
                CbDepartamento.Text = oUsuarios.Departamento;
                CbCiudad.Text = oUsuarios.Ciudad;
                CbCargo.Text = oUsuarios.Cargo;
                TxtTelefono.Text = oUsuarios.Telefono;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (DinastiaEntities2 db = new DinastiaEntities2())
            {
                if(Identificacion==null)
                oUsuarios = new Usuarios();
                oUsuarios.TipoIdentificacion = CbTipoIdentificacion.Text;
                oUsuarios.Identificacion = Convert.ToInt32(TxtIdentificacion.Text);
                oUsuarios.Nombres = TxtNombres.Text;
                oUsuarios.Password = TxtPassword.Text;
                oUsuarios.Correo = TxtCorreo.Text;
                oUsuarios.Departamento = CbDepartamento.Text;
                oUsuarios.Ciudad = CbCiudad.Text;
                oUsuarios.Cargo = CbCargo.Text;
                oUsuarios.Telefono = TxtTelefono.Text;

                if(Identificacion == null)
                db.Usuarios.Add(oUsuarios);
                else
                {
                    db.Entry(oUsuarios).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();

                this.Close();

            }
        }

        private void FrmTablas_Load(object sender, EventArgs e)
        {
            CbDepartamento.DataSource = con.CargarCombo();
            CbDepartamento.DisplayMember = "Departamento";
            CbDepartamento.ValueMember = "IdDepartamento";
        }

        private void Ciudad(object sender, EventArgs e)
        {
        }

        private void dropDepartamento(object sender, EventArgs e)
        {

        }
    }
}