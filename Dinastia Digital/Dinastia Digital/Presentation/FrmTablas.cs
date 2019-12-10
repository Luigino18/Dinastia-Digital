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
using System.Data.SqlClient;  /*obligatoria para la conexion a la db*/

namespace Dinastia_Digital.Presentation
{
    public partial class FrmTablas : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=localhost;Initial Catalog=Dinastia;Integrated Security=True"); /*Conexion a la base de datos*/

        public int? Identificacion;
        Usuarios oUsuarios = null;
        public FrmTablas(int? Identificacion=null)
        {
            InitializeComponent();
            CargarDepartamento();
            this.Identificacion = Identificacion;

            if(Identificacion != null)
            {
                CargaDatos();
            }
        }

        public void CargarDepartamento()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT idDepartamento,Departamento FROM Departamentos",cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();

            DataRow fila = dt.NewRow();
            fila["Departamento"] = "Selecciona un Departamento";
            dt.Rows.InsertAt(fila,0);

            CbDepartamento.ValueMember = "idDepartamento";
            CbDepartamento.DisplayMember = "Departamento"; /*Es lo que se mostrara en el combobox*/
            CbDepartamento.DataSource = dt;
        }

        public void CargarCiudad(string idDepartamento)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT idCiudad, Ciudad FROM ciudad WHERE idDepartamento = @idDepartamento",cn);
            cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();

            DataRow dr = dt.NewRow();
            dr["Ciudad"] = "Selecciona una Ciudad";
            dt.Rows.InsertAt(dr, 0);

            CbCiudad.ValueMember = "idCiudad";
            CbCiudad.DisplayMember = "Ciudad";
            CbCiudad.DataSource = dt;
                }

        private void CargaDatos()
        {
            using (DinastiaEntities3 db = new DinastiaEntities3())
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
            using (DinastiaEntities3 db = new DinastiaEntities3())
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
            {

            }
        }

        private void Ciudad(object sender, EventArgs e)
        {
        }
        private void dropDepartamento(object sender, EventArgs e)
        {
        }

        private void CbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbDepartamento.SelectedValue.ToString() != null)
            {
                string id_departamento = CbDepartamento.SelectedValue.ToString();
                CargarCiudad(id_departamento);
            }
        }
    }
}