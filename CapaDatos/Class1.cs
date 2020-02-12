using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Conexiones
    {
        public static String conexionSQL(string servidor, string usuario, string contraseña)// crear string de conexion apartir de parametros
        {
            var cadena = new SqlConnectionStringBuilder();
            cadena.DataSource = servidor;
            cadena.IntegratedSecurity = false;
            cadena.UserID = usuario;
            cadena.Password = contraseña;
            cadena.InitialCatalog = "QVET";

            var conexionBD = cadena.ToString();


            return conexionBD;


        }

        public static String ConexionMysql(String servidor, string usuario, string contraseña)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = servidor;
            builder.UserID = usuario;
            builder.Password = contraseña;
            builder.PersistSecurityInfo = true;
            //builder.Database = "prueba";
            var d = builder.ToString();
            return d;
        }

        
        public static String ConexionOracle(String servidor, string usuario, string contraseña)
        {
            OracleConnectionStringBuilder OracleBD = new OracleConnectionStringBuilder();
            OracleBD.Password = contraseña;
            OracleBD.UserID = usuario;
            OracleBD.DataSource = servidor;
            var da = OracleBD.ToString();
            return da;
        }



    }
    public class consultas
    {
        public static DataTable Query(string consulta, string conexionBD)
        {
            SqlConnection ap = new SqlConnection(conexionBD);
            SqlCommand cm = new SqlCommand(consulta, ap);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable QueryMYSQL(string consulta, string conexionBD)
        {
            MySqlConnection ap = new MySqlConnection(conexionBD);
            MySqlCommand ds = new MySqlCommand(consulta, ap);
            MySqlDataAdapter daM = new MySqlDataAdapter(ds);
            DataTable dt = new DataTable();
            daM.Fill(dt);
            return dt;
        }

    }

    public class metaData
    {

    }
}
