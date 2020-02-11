namespace CapaDiseño
{
    partial class Form1
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
            this.TVArbolDB = new System.Windows.Forms.TreeView();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.DGVConsultas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtHost
            // 
            this.TxtHost.Location = new System.Drawing.Point(12, 28);
            this.TxtHost.Name = "TxtHost";
            this.TxtHost.Size = new System.Drawing.Size(184, 22);
            this.TxtHost.TabIndex = 0;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(202, 28);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(185, 22);
            this.TxtUsuario.TabIndex = 1;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(393, 28);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(185, 22);
            this.TxtPass.TabIndex = 2;
            // 
            // BtnProbar
            // 
            this.BtnProbar.Location = new System.Drawing.Point(13, 57);
            this.BtnProbar.Name = "BtnProbar";
            this.BtnProbar.Size = new System.Drawing.Size(94, 38);
            this.BtnProbar.TabIndex = 3;
            this.BtnProbar.Text = "Probar";
            this.BtnProbar.UseVisualStyleBackColor = true;
            this.BtnProbar.Click += new System.EventHandler(this.BtnProbar_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(113, 57);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(94, 38);
            this.BtnConectar.TabIndex = 4;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Location = new System.Drawing.Point(1129, 284);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(94, 38);
            this.BtnEjecutar.TabIndex = 5;
            this.BtnEjecutar.Text = "Ejecutar";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbOracle);
            this.groupBox1.Controls.Add(this.RbMysql);
            this.groupBox1.Controls.Add(this.RdSQL);
            this.groupBox1.Location = new System.Drawing.Point(608, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Version de motor";
            // 
            // RbOracle
            // 
            this.RbOracle.AutoSize = true;
            this.RbOracle.Location = new System.Drawing.Point(239, 31);
            this.RbOracle.Name = "RbOracle";
            this.RbOracle.Size = new System.Drawing.Size(71, 21);
            this.RbOracle.TabIndex = 2;
            this.RbOracle.TabStop = true;
            this.RbOracle.Text = "Oracle";
            this.RbOracle.UseVisualStyleBackColor = true;
            // 
            // RbMysql
            // 
            this.RbMysql.AutoSize = true;
            this.RbMysql.Location = new System.Drawing.Point(123, 31);
            this.RbMysql.Name = "RbMysql";
            this.RbMysql.Size = new System.Drawing.Size(69, 21);
            this.RbMysql.TabIndex = 1;
            this.RbMysql.TabStop = true;
            this.RbMysql.Text = "MYSql";
            this.RbMysql.UseVisualStyleBackColor = true;
            // 
            // RdSQL
            // 
            this.RdSQL.AutoSize = true;
            this.RdSQL.Location = new System.Drawing.Point(7, 31);
            this.RdSQL.Name = "RdSQL";
            this.RdSQL.Size = new System.Drawing.Size(103, 21);
            this.RdSQL.TabIndex = 0;
            this.RdSQL.TabStop = true;
            this.RdSQL.Text = "SQL Server";
            this.RdSQL.UseVisualStyleBackColor = true;
            // 
            // TVArbolDB
            // 
            this.TVArbolDB.Location = new System.Drawing.Point(13, 102);
            this.TVArbolDB.Name = "TVArbolDB";
            this.TVArbolDB.Size = new System.Drawing.Size(194, 414);
            this.TVArbolDB.TabIndex = 7;
            this.TVArbolDB.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVArbolDB_AfterSelect);
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(229, 102);
            this.TxtConsulta.Multiline = true;
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(871, 220);
            this.TxtConsulta.TabIndex = 8;
            // 
            // DGVConsultas
            // 
            this.DGVConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsultas.Location = new System.Drawing.Point(229, 328);
            this.DGVConsultas.Name = "DGVConsultas";
            this.DGVConsultas.RowHeadersWidth = 51;
            this.DGVConsultas.RowTemplate.Height = 24;
            this.DGVConsultas.Size = new System.Drawing.Size(871, 201);
            this.DGVConsultas.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Servidor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contraseña";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(1142, 507);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(94, 38);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 557);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TreeView TVArbolDB;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.DataGridView DGVConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSalir;
    }
}

