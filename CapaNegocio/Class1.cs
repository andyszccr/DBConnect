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

        public string SQLCn2(string servidor, string usuario, string contraseña) // utilizar el string conexion para conectarse a motor y meterle paramtros
        {
            string cn = CapaDatos.Conexiones.conexionSQL(servidor, usuario, contraseña);
            string cn2 = cn + "nombre de la base de datos";
            return cn2;


        }
        public string MYSQLCn(string servidor, string usuario, string contraseña) // utilizar el string conexion para conectarse a motor y meterle paramtros
        {
            string cn = CapaDatos.Conexiones.ConexionMysql(servidor, usuario, contraseña);

            return cn;
        }
        public string ORACLECn(string servidor, string usuario, string contraseña) // utilizar el string conexion para conectarse a motor y meterle paramtros
        {
            string cn = CapaDatos.Conexiones.ConexionOracle(servidor, usuario, contraseña);

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

        public void excel()
        { 
        }
    }

}
