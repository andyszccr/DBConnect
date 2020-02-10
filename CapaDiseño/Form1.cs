using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;


namespace CapaDiseño
{
     
    public partial class Form1 : Form
    {
        public string servidor, usuario, contraseña, consulta, stringCN;
        public Boolean motorSql, motorMysql, motorOracle;

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            servidor = Convert.ToString(TxtHost.Text);
            usuario = Convert.ToString(TxtUsuario.Text);
            contraseña = Convert.ToString(TxtPass.Text);
            motorSql = Convert.ToBoolean(RdSQL.Checked);
            motorMysql = Convert.ToBoolean(RbMysql.Checked);
            motorOracle = Convert.ToBoolean(RbOracle.Checked);

            if (motorSql == true)
            {
                CapaNegocio.ManejoCN prueba = new CapaNegocio.ManejoCN();
                string cn = prueba.SQLCn(servidor, usuario, contraseña);
                var cnsql = new SqlConnection(cn);

                try
                {
                    
                    MessageBox.Show("Conexion exitosa! ");
                    stringCN = cn.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Conexion Fallida por " + ex.Message);
                }

            }
            else
            {
                if (motorMysql == true)
                {
                    CapaNegocio.ManejoCN prueba = new CapaNegocio.ManejoCN();
                    string cn = prueba.MYSQLCn(servidor, usuario, contraseña);
                    var cnsql = new SqlConnection(cn);

                    try
                    {
                        stringCN = cn;
                        MessageBox.Show("Conexion exitosa! ");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Conexion Fallida por " + ex.Message);
                    }
                }
                else
                {
                    if (motorOracle == true)
                    {
                        CapaNegocio.ManejoCN prueba = new CapaNegocio.ManejoCN();
                        string cn = prueba.ORACLECn(servidor, usuario, contraseña);
                        var cnsql = new SqlConnection(cn);

                        try
                        {
                            stringCN = cn;
                            MessageBox.Show("Conexion exitosa! ");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Conexion Fallida por " + ex.Message);
                        }
                    }
                }
            }

        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                consulta = Convert.ToString(TxtConsulta.Text);
                var _ = new SqlConnection(stringCN);
                _.Open();
                DGVConsultas.DataSource = CapaNegocio.ManejoCN.ejecutar(consulta, stringCN);
            }
            catch (Exception exs)
            {
                MessageBox.Show("error en consulta por " + exs.Message);
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnProbar_Click(object sender, EventArgs e)
        {
            
            servidor = Convert.ToString(TxtHost.Text);
            usuario = Convert.ToString(TxtUsuario.Text);
            contraseña = Convert.ToString(TxtPass.Text);
            motorSql = Convert.ToBoolean(RdSQL.Checked);
            motorMysql = Convert.ToBoolean(RbMysql.Checked);
            motorOracle = Convert.ToBoolean(RbOracle.Checked);

            if  (motorSql == true)
            {
                CapaNegocio.ManejoCN prueba = new CapaNegocio.ManejoCN();
                string cn = prueba.SQLCn(servidor, usuario, contraseña);
                var cnsql = new SqlConnection(cn);

                try
                {
                    cnsql.Open();
                    MessageBox.Show("Conexion exitosa! ");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Conexion Fallida por " + ex.Message);
                }

            }
            else
            {
                if (motorMysql == true)
                {
                    CapaNegocio.ManejoCN prueba = new CapaNegocio.ManejoCN();
                    string cn = prueba.MYSQLCn(servidor, usuario, contraseña);
                    var cnsql = new SqlConnection(cn);

                    try
                    {
                        cnsql.Open();
                        MessageBox.Show("Conexion exitosa! ");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Conexion Fallida por " + ex.Message);
                    }
                }
                else
                {
                    if (motorOracle==true)
                    {
                        CapaNegocio.ManejoCN prueba = new CapaNegocio.ManejoCN();
                        string cn = prueba.ORACLECn(servidor, usuario, contraseña);
                        var cnsql = new SqlConnection(cn);

                        try
                        {
                            cnsql.Open();
                            MessageBox.Show("Conexion exitosa! ");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Conexion Fallida por " + ex.Message);
                        }
                    }
                }
            }




        }
    }
}
