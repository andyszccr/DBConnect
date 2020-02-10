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
using System.Data.OracleClient;

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
            builder.Database = "Mysql";
            var d = builder.ToString();
            return d;
        }

        
        public static String ConexionOracle(String servidor, string usuario, string contraseña)
        {
            string conex;
            conex = "Data Source= " + servidor + "; User Id= " + usuario + " ;Password= " + contraseña;
            

            return conex;
        }



    }
    public class consultas
    {
        public static DataTable Query(string consulta, string conexionBD)
        {
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexionBD);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }

    public class metaData
    {

    }
}
