using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
//using MySql.Data.MySqlClient;
//using MySql.Data.Common;
using Oracle.ManagedDataAccess.Client;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;





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

            //devuelve la variable de conexion 
            return conexionBD;


        }

        public static String conexionSQLQ(string servidor, string usuario, string contraseña, string bd)// crear string de conexion apartir de parametros SQL SERVER
        {
            var cadena = new SqlConnectionStringBuilder();
            cadena.DataSource = servidor;
            cadena.IntegratedSecurity = false;
            cadena.UserID = usuario;
            cadena.Password = contraseña;
            cadena.InitialCatalog = bd; // parametro de base de datos 

            var conexionBD = cadena.ToString();


            return conexionBD;


        }

        //public static String ConexionMysql(String servidor, string usuario, string contraseña)
        //{
        //    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        //    builder.Server = servidor;
        //    builder.UserID = usuario;
        //    builder.Password = contraseña;
        //    builder.PersistSecurityInfo = true;
        //    //builder.Database = "prueba";
        //    var d = builder.ToString();
        //    return d;
        //}

        //public static String ConexionMysqlQ(String servidor, string usuario, string contraseña, string bd)
        //{
        //    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        //    builder.Server = servidor;
        //    builder.UserID = usuario;
        //    builder.Password = contraseña;
        //    builder.PersistSecurityInfo = true;
        //    builder.Database = bd;
        //    var d = builder.ToString();
        //    return d;
        //}


        public static String ConexionOracle(String servidor, string usuario, string contraseña)
        {
            OracleConnectionStringBuilder OracleBD = new OracleConnectionStringBuilder();
            OracleBD.Password = contraseña;
            OracleBD.UserID = usuario;
            OracleBD.DataSource = servidor;
            var da = OracleBD.ToString();
            return da;
        }

        public static String ConexionOracleQ(String servidor, string usuario, string contraseña, string bd)
        {
            OracleConnectionStringBuilder OracleBD = new OracleConnectionStringBuilder();
            OracleBD.Password = contraseña;
            OracleBD.UserID = usuario;
            OracleBD.DataSource = servidor;
            OracleBD.DBAPrivilege = bd;
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

       

        //public static DataTable QueryMYSQL(string consulta, string conexionBD)
        //{
        //    MySqlConnection ap = new MySqlConnection(conexionBD);
        //    MySqlCommand ds = new MySqlCommand(consulta, ap);
        //    MySqlDataAdapter daM = new MySqlDataAdapter(ds);
        //    DataTable dt = new DataTable();
        //    daM.Fill(dt);
        //    return dt;
        //}

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
    //*****************************************************************************
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
        //**********************************************************************************
        //public static List<string> obtenerBDsMYSQL(string consulta, string conexionBD)
        //{
        //    MySqlConnection ap = new MySqlConnection(conexionBD);
        //    var command = new MySqlCommand(consulta, ap);
        //    ap.Open();
        //    MySqlDataReader reader = command.ExecuteReader();
        //    var lista = new List<string>();
        //    while (reader.Read())
        //    {
        //        var e = reader[0];
        //        lista.Add(reader[0].ToString());
        //    }

        //    return lista;

        //}
    }
    //**************************************************************************
    //  Region de Archivos 
    //**************************************************************************
    #region Archivos 
  public class files
    {
        //**********************************************
        public void Archivos(DataGridView table)
        {
            //****************************************
            //validacion de datos 
            try
            {
                int IndicaColumna = 0;
                int IndicaFila = 0;


                //microsoft para la aplicacion de excel
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                

                
                //por cada columna del data grid view 
                // recorre las columnas 
                foreach (DataGridViewColumn col in table.Columns)
                {
                    //aumenta 
                    IndicaColumna++;
                    excel.Cells[1, IndicaColumna] = col.Name;
                }


                // recorre las filas 
                foreach (DataGridViewRow row in table.Rows)
                {
                    IndicaFila++;
                    IndicaColumna = 0;
                    foreach (DataGridViewColumn col in table.Columns)
                    {
                        IndicaColumna++;
                        excel.Cells[IndicaFila + 1, IndicaColumna] = row.Cells[col.Name].Value;
                    }
                }
                //se muestra el excel
                excel.Visible = true;
            }
            catch
            {
                //**************************************************************************************************
                //mensaje de error en caso de que no se guarde el archivo  
                MessageBox.Show("Error para guardar datos en excel","Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //***********************************************************************************************************
    #endregion
  
    }
}
