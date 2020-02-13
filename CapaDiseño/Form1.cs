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
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Oracle.ManagedDataAccess.Client;






namespace CapaDiseño
{
     
    public partial class Form1 : Form
    {
        public string servidor, usuario, contraseña, consulta, stringCN, bd, BaseDatos;
        public Boolean motorSql, motorMysql, motorOracle;
        public void excel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndicaColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)// recorre las columnas 
            {
                IndicaColumna++;
                excel.Cells[1, IndicaColumna] = col.Name;
            }
            int IndicaFila = 0;
            foreach (DataGridViewRow row in tabla.Rows)// recorre las filas 
            {
                IndicaFila++;
                IndicaColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndicaColumna++;
                    excel.Cells[IndicaFila + 1, IndicaColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;

        }


        public void TVArbolDB_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch ((e.Action))
            {
                case TreeViewAction.ByKeyboard:
                    BaseDatos = e.Node.Text;
                    MessageBox.Show("Ha seleccionado el elemento "+ e.Node.Text + " para trabajar");
                    break;
                case TreeViewAction.ByMouse:
                    BaseDatos = e.Node.Text;
                    MessageBox.Show("Ha seleccionado el elemento " + e.Node.Text + " para trabajar");
                    break;
            }

        }

        private void BtnGuardarTxt_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        string txt = saveFileDialog1.FileName;


                        CapaNegocio.archivos.txt(TxtConsulta.Text, txt);

                       
                    }
                    else
                    {
                        string txt = saveFileDialog1.FileName;
                        CapaNegocio.archivos.txt(TxtConsulta.Text, txt);

                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Busca tu consulta";
                openFileDialog1.ShowDialog();
                String text = openFileDialog1.FileName;

                if (File.Exists(openFileDialog1.FileName))
                {
                    TextReader leer = new StreamReader(text);
                    TxtConsulta.Text = leer.ReadToEnd();
                    leer.Close();

                }
            }
            catch(Exception)
            {
                MessageBox.Show("error al abrir el archivo");
            }

        }

        private void BtnGuadarExc_Click(object sender, EventArgs e)
        {
            excel(DGVConsultas);
        }

        private void ProcesarArbol(List<CapaNegocio.BD> Bases)
        {
            Bases.ForEach((bd) =>
            {

                var cantidadTablas = bd.Tablas.Count;
                var treeNodes = new TreeNode[cantidadTablas];
                var index = 0;
                bd.Tablas.ForEach((tabla) =>
                {
                    treeNodes[index] = new TreeNode(tabla.Nombre);
                    index++;
                });
                var Tree = new TreeNode(bd.Nombre, treeNodes);
                TVArbolDB.Nodes.Add(Tree);
            });
        }


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
                    cnsql.Open();
                    MessageBox.Show("Conexion exitosa! ");
                    stringCN = cn.ToString();
                    var datos = CapaNegocio.ManejoCN.obBD(consulta, stringCN);
                    datos.ForEach((bd) =>
                    {
                        var tablas = CapaNegocio.ManejoCN.bdTablas(bd.Nombre, stringCN);
                        bd.Tablas = tablas;
                    });
                    ProcesarArbol(datos);
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
                    var cnsql = new MySqlConnection(cn);

                    try
                    {
                        cnsql.Open();
                        MessageBox.Show("Conexion exitosa! ");
                        stringCN = cn.ToString();
                        var datos = CapaNegocio.ManejoCN.obBDMYSQL(consulta, stringCN);
                        datos.ForEach((bd) =>
                        {
                            var tablas = CapaNegocio.ManejoCN.bdTablasMYSQL(bd.Nombre, stringCN);
                            bd.Tablas = tablas;
                        });
                        ProcesarArbol(datos);


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
                        var cnsql = new OracleConnection(cn);

                        try
                        {
                            cnsql.Open();
                            
                            MessageBox.Show("Conexion exitosa! ");
                            stringCN = cn.ToString();

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
            if (motorSql == true)
            {
                try
                {
                    CapaNegocio.ManejoCN query = new CapaNegocio.ManejoCN();
                    string cn = query.SQLCn2(servidor, usuario, contraseña,BaseDatos);
                    consulta = Convert.ToString(TxtConsulta.Text);

                    var _ = new SqlConnection(cn);
                    _.Open();
                    DGVConsultas.DataSource = CapaNegocio.ManejoCN.ejecutar(consulta, cn);
                    _.Close();
                }
                catch (Exception exs)
                {
                    MessageBox.Show("error en consulta por " + exs.Message);
                }
            }
            else
            {
                if (motorMysql == true)
                {
                    try
                    {
                        CapaNegocio.ManejoCN query = new CapaNegocio.ManejoCN();
                        string cn = query.MYSQLCn2(servidor, usuario, contraseña, BaseDatos);
                        consulta = Convert.ToString(TxtConsulta.Text);
                        var _ = new MySqlConnection(cn);
                        _.Open();

                        DGVConsultas.DataSource = CapaNegocio.ManejoCN.QueryMYSQL(consulta,cn);
                    }
                    catch (Exception exs)
                    {
                        MessageBox.Show("error en consulta por " + exs.Message);
                    }

                }
                else
                {
                    if (motorOracle==true)
                    {
                        try
                        {
                            CapaNegocio.ManejoCN query = new CapaNegocio.ManejoCN();
                            string cn = query.ORACLECn2(servidor, usuario, contraseña, BaseDatos);
                            consulta = Convert.ToString(TxtConsulta.Text);
                            var _ = new OracleConnection(cn);
                            _.Open();

                            DGVConsultas.DataSource = CapaNegocio.ManejoCN.QueryOracle(consulta, cn);
                        }
                        catch (Exception exs)
                        {
                            MessageBox.Show("error en consulta por " + exs.Message);
                        }

                    }
                }

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
                    var cnsql = new MySqlConnection(cn);

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
                       var cnsql = new OracleConnection (cn);

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
