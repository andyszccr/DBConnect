using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.IO;


namespace CapaNegocio
{
    public class ManejoCN
    {
        public string servidor, usuario, contraseña;
        public string SQLCn(string servidor, string usuario, string contraseña) // utilizar el string conexion para conectarse a motor y meterle paramtros
        {
            string cn = CapaDatos.Conexiones.conexionSQL(servidor, usuario, contraseña);
            //SqlConnection conexion = new SqlConnection(cn);
            return cn;

            
        }

        public static List<CapaNegocio.BD> obBD(string consulta, string cn)
        {
            var query = "select name from sys.databases";
            var da = CapaDatos.metaData.obtenerBDs(query, cn);

            var BD = new List<CapaNegocio.BD>();

            da.ForEach((bb) =>
            {
                BD.Add(new CapaNegocio.BD()
                {
                    Nombre = bb
                });
            });

            return BD;

        }

        public static List<CapaNegocio.BD> obBDMYSQL(string consulta, string cn)
        {
            var query = "show databases";
            var da = CapaDatos.metaData.obtenerBDsMYSQL(query, cn);

            var BD = new List<CapaNegocio.BD>();

            da.ForEach((bb) =>
            {
                BD.Add(new CapaNegocio.BD()
                {
                    Nombre = bb
                });
            });

            return BD;

        }

        public static List<CapaNegocio.Tablas> bdTablas(string tabla, string cn)
        {
            var query = String.Format("select TABLE_NAME from {0}.INFORMATION_SCHEMA.TABLES", tabla);
            var da = CapaDatos.metaData.obtenerBDs(query, cn);

            var BD = new List<CapaNegocio.Tablas>();

            da.ForEach((bb) =>
            {
                BD.Add(new CapaNegocio.Tablas()
                {
                    Nombre = bb
                });
            });

            return BD;

        }

        public static List<CapaNegocio.Tablas> bdTablasMYSQL(string tabla, string cn)
        {
            var query = String.Format("SELECT  TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE table_schema='{0}'", tabla);
            var da = CapaDatos.metaData.obtenerBDsMYSQL(query, cn);

            var BD = new List<CapaNegocio.Tablas>();

            da.ForEach((bb) =>
            {
                BD.Add(new CapaNegocio.Tablas()
                {
                    Nombre = bb
                });
            });

            return BD;

        }

        public string SQLCn2(string servidor, string usuario, string contraseña, string bd) // utilizar el string conexion para conectarse a motor y meterle paramtros
        {
            string cn = CapaDatos.Conexiones.conexionSQLQ(servidor, usuario, contraseña,bd);
            return cn;


        }
        public string MYSQLCn(string servidor, string usuario, string contraseña) // utilizar el string conexion para conectarse a motor y meterle paramtros
        {
            string cn = CapaDatos.Conexiones.ConexionMysql(servidor, usuario, contraseña);

            return cn;
        }

        public string MYSQLCn2(string servidor, string usuario, string contraseña, string bd) // utilizar el string conexion para conectarse a motor y meterle paramtros
        {
            string cn = CapaDatos.Conexiones.ConexionMysqlQ(servidor, usuario, contraseña, bd);

            return cn;
        }
        public string ORACLECn(string servidor, string usuario, string contraseña) // utilizar el string conexion para conectarse a motor y meterle paramtros
        {
            string cn = CapaDatos.Conexiones.ConexionOracle(servidor, usuario, contraseña);

            return cn;
        }

        public string ORACLECn2(string servidor, string usuario, string contraseña, string bd) // utilizar el string conexion para conectarse a motor y meterle paramtros
        {
            string cn = CapaDatos.Conexiones.ConexionOracleQ(servidor, usuario, contraseña, bd);

            return cn;
        }

        public static DataTable ejecutar(string consulta, string cn)
        {
            var da = CapaDatos.consultas.Query(consulta, cn);
            return da;

        }

        public static DataTable QueryMYSQL(string consulta, string cn)
        {
            
            var da = CapaDatos.consultas.QueryMYSQL(consulta, cn);
            return da;
        }

        public static DataTable QueryOracle(string consulta, string cn)
        {

            var da = CapaDatos.consultas.QueryOracle(consulta, cn);
            return da;
        }
    }
   public class arbol
    {

    }

    public class archivos
    {
        public static void txt( String texto, string ruta)
        {
            StreamWriter textoaguardar = File.CreateText(ruta);
            textoaguardar.Write(texto);
            textoaguardar.Flush();
            textoaguardar.Close();

        }

 
        
    }

}
