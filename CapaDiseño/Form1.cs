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
using CapaNegocio;





namespace CapaDiseño
{
     
    public partial class frmBases : Form
    {
        vistaExcel Excel = new vistaExcel();
        archivos ar = new archivos();



        public string servidor, usuario, contraseña, consulta, stringCN, bd, BaseDatos;
        public Boolean motorSql, motorMysql, motorOracle;
        
        public void TVArbolDB_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // switch ejecuta la accion para mostrar la bases de datos disponibles 
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
        //************************************************************************************************************
        private void BtnGuardarTxt_Click(object sender, EventArgs e)
        {
            //validacion de datos 
            try
            {
                //si guardar es igual al dialogo de resultado. ok entonces 
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //si el archivo existe entonces 
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
        //************************************************************************************************
        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            //validacion de datos 
            try
            {
                //buscar la consulta
                openFileDialog1.Title = "Busca tu consulta";
                openFileDialog1.ShowDialog();
                String text = openFileDialog1.FileName;

                //si existe el archivo entonces 
                if (File.Exists(openFileDialog1.FileName))
                {
                    
                    TextReader leer = new StreamReader(text);
                    TxtConsulta.Text = leer.ReadToEnd();
                    leer.Close();

                }
            }
            catch(Exception)
            {
                //en caso de error se muestra un mensaje 
                MessageBox.Show("no se pudo abrir el archivo","Error al abrir",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void frmBases_Load(object sender, EventArgs e)
        {
            BtnEjecutar.Enabled = false;
            btndesconectar.Enabled = false;
           
            TxtConsulta.Enabled = false;
        }

        private void btndesconectar_Click(object sender, EventArgs e)
        {
            //validacion de datos 
            try
            {

                //se habilitan los campos para conectarse
                TxtHost.Enabled = true;
                TxtPass.Enabled = true;
                TxtUsuario.Enabled = true;

                //se desabilita el campo para realizar consultas 
                TxtConsulta.Enabled = false;
                TVArbolDB.Nodes.Clear();

                TxtConsulta.Clear();

                //limpieza de datos 
                TxtHost.Clear();
                TxtPass.Clear();
                TxtUsuario.Clear();

                //limpieza de los datos 
                DGVConsultas.Columns.Clear();

                btndesconectar.Enabled = false;
                BtnEjecutar.Enabled = false;

                //se deselecciona las opcion que escogiste 
                RdSQL.Checked = false;
                RbMysql.Checked = false;
                RbOracle.Checked = false;

            }
            catch
            {
                //en caso de no poder desconectar los datos se muestra un mensaje 
                MessageBox.Show("no se pudo desconectar el usuario", "Error de desconexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //*******************************************************************
        private void btnCreateQuery_Click(object sender, EventArgs e)
        {
            
        }
        //**********************************************************************
        private void BtnGuadarExc_Click(object sender, EventArgs e)
        {
            Excel.Vista(DGVConsultas);
        }
        //***********************************************************************
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

        //***********************************************************************
        private void BtnConectar_Click(object sender, EventArgs e)
        {
            servidor = Convert.ToString(TxtHost.Text);
            usuario = Convert.ToString(TxtUsuario.Text);
            contraseña = Convert.ToString(TxtPass.Text);
            motorSql = Convert.ToBoolean(RdSQL.Checked);
            motorMysql = Convert.ToBoolean(RbMysql.Checked);
            motorOracle = Convert.ToBoolean(RbOracle.Checked);

   
            //si no ha escogido una base de datos entonces 
            if (motorSql==false)
            {
                //en caso de que no escoja la base de datos le da error 
                MessageBox.Show("Seleccione cual base de datos se va a conectar","Error al no seleccionar la base de datos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //se limpian los campos 
                TxtHost.Clear();
                TxtPass.Clear();
                TxtUsuario.Clear();
                
            }
            else if (motorSql == true)
            {
                CapaNegocio.ManejoCN prueba = new CapaNegocio.ManejoCN();
                string cn = prueba.SQLCn(servidor, usuario, contraseña);
                var cnsql = new SqlConnection(cn);

                //validacion de datos 
                try
                {
                    cnsql.Open();
                    //informacion de la entrada a la conexion de la base de datos 
                    MessageBox.Show("Conexion exitosa! ","Conexion de base de datos",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    //se habilitan los espacios y campo
                    BtnEjecutar.Enabled = true;
                    btndesconectar.Enabled = true;
                    TxtConsulta.Enabled = true;

                    //campos desabilitados para editar 
                    TxtHost.Enabled = false;
                    TxtPass.Enabled = false;
                    TxtUsuario.Enabled = false;
                    
                    //botones habilitados
                    BtnConectar.Enabled = false;
                    BtnProbar.Enabled = false;


                      stringCN = cn.ToString();
                    var datos = CapaNegocio.ManejoCN.obBD(consulta, stringCN);
                    datos.ForEach((bd) =>
                    {
                        var tablas = CapaNegocio.ManejoCN.bdTablas(bd.Nombre, stringCN);
                        bd.Tablas = tablas;
                    });


                    //procesamiento del arbol (metodo)
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
        //*************************************************************************************************
        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            //si colocas los datos sin antes de seleccionar que base de datos usar entonces  
            if (motorSql == true)
            {
                //validacion de datos 
                try
                {
                    //conexion por medio de la referncia desde la capa de negocios 
                    CapaNegocio.ManejoCN query = new CapaNegocio.ManejoCN();

                    //string de conexion para entrar a la base de datos 
                    string cn = query.SQLCn2(servidor, usuario, contraseña,BaseDatos);
                    consulta = Convert.ToString(TxtConsulta.Text);

                    
                    var _ = new SqlConnection(cn);
                    
                    //abre y cierra la conexion 
                    _.Open();
                    DGVConsultas.DataSource = CapaNegocio.ManejoCN.ejecutar(consulta, cn);
                    _.Close();
                }
                catch (Exception exs)
                {
                    //sale un mensaja de error 
                    MessageBox.Show("error en consulta por " + exs.Message);
                }
            }
            else
            {
                //si el motor mysql es verdadero al entrar entonces  
                if (motorMysql == true)
                {
                    //validacion de datos 
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
                        //se muestra un mensaje en caso de error 
                        MessageBox.Show("error en consulta por " + exs.Message);
                    }

                }
                else
                {
                    //si motor de oracle es verdadero entonces 
                    if (motorOracle==true)
                    {
                        //validacion de dattos 
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
        //****************************************************************************************************
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //****************************************************************************************************
        public frmBases()
        {
            InitializeComponent();
            //colocar en el centro 
            this.CenterToScreen();
        }
        //*******************************************************************************
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //si desea salir del progarama 
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        //********************************************************************************
        private void BtnProbar_Click(object sender, EventArgs e)
        {
            
            servidor = Convert.ToString(TxtHost.Text);
            usuario = Convert.ToString(TxtUsuario.Text);
            contraseña = Convert.ToString(TxtPass.Text);
            motorSql = Convert.ToBoolean(RdSQL.Checked);
            motorMysql = Convert.ToBoolean(RbMysql.Checked);
            motorOracle = Convert.ToBoolean(RbOracle.Checked);

            //en caso de que no escojiera la base de datos entonces 
            if (motorSql==false)
            {
                //se muestra un mensaje de los datos 
                MessageBox.Show("no se pudo realizar la prueba sin escojer la base de datos", "Error de prueba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtHost.Clear();
                TxtPass.Clear();
                TxtUsuario.Clear();
            
            }
            else if  (motorSql == true)
            {
                CapaNegocio.ManejoCN prueba = new CapaNegocio.ManejoCN();
                string cn = prueba.SQLCn(servidor, usuario, contraseña);
                var cnsql = new SqlConnection(cn);
                
                //validacion de datos 
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
                    //si es oracle entonces 
                    if (motorOracle==true)
                    {
                        CapaNegocio.ManejoCN prueba = new CapaNegocio.ManejoCN();
                        string cn = prueba.ORACLECn(servidor, usuario, contraseña);
                       var cnsql = new OracleConnection (cn);

                        //validacion de datos 
                        try
                        {
                            //abre la conexion 
                            cnsql.Open();

                            MessageBox.Show("Conexion exitosa al entrar con Oracle"," has entrado ",MessageBoxButtons.OK,MessageBoxIcon.Information);

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
