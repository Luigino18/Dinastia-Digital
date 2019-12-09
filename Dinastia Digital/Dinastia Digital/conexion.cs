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
    public class conexion
    {
        SqlConnection cn = new SqlConnection("Data Source=localhost;Initial Catalog=Dinastia;Integrated Security=True"); /*Conexion a la base de datos*/

        public DataTable CargarCombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_cargardepartamentos",cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

            }
}