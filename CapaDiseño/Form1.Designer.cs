namespace CapaDiseño
{
    partial class frmBases
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtHost = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.BtnProbar = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbOracle = new System.Windows.Forms.RadioButton();
            this.RbMysql = new System.Windows.Forms.RadioButton();
            this.RdSQL = new System.Windows.Forms.RadioButton();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.DGVConsultas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TVArbolDB = new System.Windows.Forms.TreeView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.BtnGuadarExc = new System.Windows.Forms.Button();
            this.BtnGuardarTxt = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btndesconectar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtHost
            // 
            this.TxtHost.Location = new System.Drawing.Point(9, 23);
            this.TxtHost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtHost.Name = "TxtHost";
            this.TxtHost.Size = new System.Drawing.Size(139, 20);
            this.TxtHost.TabIndex = 0;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(152, 23);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(140, 20);
            this.TxtUsuario.TabIndex = 1;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(295, 23);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(140, 20);
            this.TxtPass.TabIndex = 2;
            // 
            // BtnProbar
            // 
            this.BtnProbar.Location = new System.Drawing.Point(10, 46);
            this.BtnProbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnProbar.Name = "BtnProbar";
            this.BtnProbar.Size = new System.Drawing.Size(70, 31);
            this.BtnProbar.TabIndex = 3;
            this.BtnProbar.Text = "Probar";
            this.BtnProbar.UseVisualStyleBackColor = true;
            this.BtnProbar.Click += new System.EventHandler(this.BtnProbar_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(85, 46);
            this.BtnConectar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(70, 31);
            this.BtnConectar.TabIndex = 4;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Location = new System.Drawing.Point(172, 47);
            this.BtnEjecutar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(70, 31);
            this.BtnEjecutar.TabIndex = 5;
            this.BtnEjecutar.Text = "Ejecutar";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.RbOracle);
            this.groupBox1.Controls.Add(this.RbMysql);
            this.groupBox1.Controls.Add(this.RdSQL);
            this.groupBox1.Location = new System.Drawing.Point(456, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(271, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Version de motor";
            // 
            // RbOracle
            // 
            this.RbOracle.AutoSize = true;
            this.RbOracle.Location = new System.Drawing.Point(179, 25);
            this.RbOracle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbOracle.Name = "RbOracle";
            this.RbOracle.Size = new System.Drawing.Size(56, 17);
            this.RbOracle.TabIndex = 2;
            this.RbOracle.TabStop = true;
            this.RbOracle.Text = "Oracle";
            this.RbOracle.UseVisualStyleBackColor = true;
            // 
            // RbMysql
            // 
            this.RbMysql.AutoSize = true;
            this.RbMysql.Location = new System.Drawing.Point(92, 25);
            this.RbMysql.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbMysql.Name = "RbMysql";
            this.RbMysql.Size = new System.Drawing.Size(56, 17);
            this.RbMysql.TabIndex = 1;
            this.RbMysql.TabStop = true;
            this.RbMysql.Text = "MYSql";
            this.RbMysql.UseVisualStyleBackColor = true;
            // 
            // RdSQL
            // 
            this.RdSQL.AutoSize = true;
            this.RdSQL.Location = new System.Drawing.Point(5, 25);
            this.RdSQL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RdSQL.Name = "RdSQL";
            this.RdSQL.Size = new System.Drawing.Size(80, 17);
            this.RdSQL.TabIndex = 0;
            this.RdSQL.TabStop = true;
            this.RdSQL.Text = "SQL Server";
            this.RdSQL.UseVisualStyleBackColor = true;
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(172, 83);
            this.TxtConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtConsulta.Multiline = true;
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(654, 180);
            this.TxtConsulta.TabIndex = 8;
            // 
            // DGVConsultas
            // 
            this.DGVConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsultas.Location = new System.Drawing.Point(172, 266);
            this.DGVConsultas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVConsultas.Name = "DGVConsultas";
            this.DGVConsultas.RowHeadersWidth = 51;
            this.DGVConsultas.RowTemplate.Height = 24;
            this.DGVConsultas.Size = new System.Drawing.Size(653, 163);
            this.DGVConsultas.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Servidor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contraseña";
            // 
            // TVArbolDB
            // 
            this.TVArbolDB.Location = new System.Drawing.Point(10, 83);
            this.TVArbolDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TVArbolDB.Name = "TVArbolDB";
            this.TVArbolDB.Size = new System.Drawing.Size(146, 348);
            this.TVArbolDB.TabIndex = 7;
            this.TVArbolDB.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVArbolDB_AfterSelect);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.BackColor = System.Drawing.SystemColors.Info;
            this.BtnAbrir.Image = global::CapaDiseño.Properties.Resources.documento;
            this.BtnAbrir.Location = new System.Drawing.Point(830, 113);
            this.BtnAbrir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(41, 43);
            this.BtnAbrir.TabIndex = 16;
            this.BtnAbrir.UseVisualStyleBackColor = false;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // BtnGuadarExc
            // 
            this.BtnGuadarExc.BackColor = System.Drawing.Color.Green;
            this.BtnGuadarExc.Image = global::CapaDiseño.Properties.Resources.sobresalir;
            this.BtnGuadarExc.Location = new System.Drawing.Point(830, 266);
            this.BtnGuadarExc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGuadarExc.Name = "BtnGuadarExc";
            this.BtnGuadarExc.Size = new System.Drawing.Size(41, 45);
            this.BtnGuadarExc.TabIndex = 15;
            this.BtnGuadarExc.UseVisualStyleBackColor = false;
            this.BtnGuadarExc.Click += new System.EventHandler(this.BtnGuadarExc_Click);
            // 
            // BtnGuardarTxt
            // 
            this.BtnGuardarTxt.Image = global::CapaDiseño.Properties.Resources.salvar__2_;
            this.BtnGuardarTxt.Location = new System.Drawing.Point(875, 113);
            this.BtnGuardarTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGuardarTxt.Name = "BtnGuardarTxt";
            this.BtnGuardarTxt.Size = new System.Drawing.Size(40, 43);
            this.BtnGuardarTxt.TabIndex = 14;
            this.BtnGuardarTxt.UseVisualStyleBackColor = true;
            this.BtnGuardarTxt.Click += new System.EventHandler(this.BtnGuardarTxt_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Salmon;
            this.BtnSalir.Image = global::CapaDiseño.Properties.Resources.cerrar;
            this.BtnSalir.Location = new System.Drawing.Point(911, 2);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(52, 38);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btndesconectar
            // 
            this.btndesconectar.Location = new System.Drawing.Point(248, 47);
            this.btndesconectar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndesconectar.Name = "btndesconectar";
            this.btndesconectar.Size = new System.Drawing.Size(77, 29);
            this.btndesconectar.TabIndex = 17;
            this.btndesconectar.Text = "Desconectar";
            this.btndesconectar.UseVisualStyleBackColor = true;
            this.btndesconectar.Click += new System.EventHandler(this.btndesconectar_Click);
            // 
            // frmBases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 457);
            this.ControlBox = false;
            this.Controls.Add(this.btndesconectar);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.BtnGuadarExc);
            this.Controls.Add(this.BtnGuardarTxt);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVConsultas);
            this.Controls.Add(this.TxtConsulta);
            this.Controls.Add(this.TVArbolDB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.BtnProbar);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtHost);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBases";
            this.Text = "Herramienta de Ejecucion de Consultas";
            this.Load += new System.EventHandler(this.frmBases_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHost;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Button BtnProbar;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Button BtnEjecutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbOracle;
        private System.Windows.Forms.RadioButton RbMysql;
        private System.Windows.Forms.RadioButton RdSQL;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.DataGridView DGVConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardarTxt;
        private System.Windows.Forms.Button BtnGuadarExc;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TreeView TVArbolDB;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btndesconectar;
        //private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
    }
}

