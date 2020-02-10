using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

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
    }
}
