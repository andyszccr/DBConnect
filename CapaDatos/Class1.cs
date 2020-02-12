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
using Oracle.ManagedDataAccess.Client;

namespace CapaDatos
{
    public class Conexiones
    {
        public static String conexionSQL(string servidor, string usuario, string contraseña)// crear string de conexion apartir de parametros SQL SERVER
        {
            var cadena = new SqlConnectionStringBuilder();
            cadena.DataSource = servidor;
            cadena.IntegratedSecurity = false;
            cadena.UserID = usuario;
            cadena.Password = contraseña;
            //cadena.InitialCatalog = "QVET"; // parametro de base de datos 

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
    public static class consultas
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

        public static DataTable QueryOracle(string consulta, string conexionBD)
        {
           OracleConnection ap = new OracleConnection(conexionBD);
            OracleCommand ds = new OracleCommand(consulta, ap);
            OracleDataAdapter daM = new OracleDataAdapter(ds);
            DataTable dt = new DataTable();
            daM.Fill(dt);
            return dt;
        }

        



    }

    public static class metaData
    {
        public static IEnumerable<T> Select<T>(this IDataReader reader,
                                       Func<IDataReader, T> projection)
        {
            while (reader.Read())
            {
                yield return projection(reader);
            }
        }

        public static List<string> obtenerBDs(string consulta, string conexionBD)
        {
            SqlConnection ap = new SqlConnection(conexionBD);
            var command = new SqlCommand(consulta, ap);
            ap.Open();
            SqlDataReader reader = command.ExecuteReader();
            var lista = new List<string>();
            while (reader.Read())
            {
                var e = reader[0];
                lista.Add(reader[0].ToString());
            }

            return lista;

        }

        public static List<string> obtenerBDsMYSQL(string consulta, string conexionBD)
        {
            MySqlConnection ap = new MySqlConnection(conexionBD);
            var command = new MySqlCommand(consulta, ap);
            ap.Open();
            MySqlDataReader reader = command.ExecuteReader();
            var lista = new List<string>();
            while (reader.Read())
            {
                var e = reader[0];
                lista.Add(reader[0].ToString());
            }

            return lista;

        }

    }
}
