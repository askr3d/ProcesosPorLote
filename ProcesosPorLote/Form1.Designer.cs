namespace ProcesosPorLote
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumProcesos = new System.Windows.Forms.TextBox();
            this.timerGlobal = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerarProcesos = new System.Windows.Forms.Button();
            this.lblValidacionNumProcesos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.listEspera = new System.Windows.Forms.ListView();
            this.Lote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Operacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tiempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listEjecucion = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listTerminados = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObtenerResultados = new System.Windows.Forms.Button();
            this.lblReporteMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Procesos";
            // 
            // txtNumProcesos
            // 
            this.txtNumProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumProcesos.Location = new System.Drawing.Point(183, 47);
            this.txtNumProcesos.Name = "txtNumProcesos";
            this.txtNumProcesos.Size = new System.Drawing.Size(118, 26);
            this.txtNumProcesos.TabIndex = 1;
            this.txtNumProcesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerGlobal
            // 
            this.timerGlobal.Interval = 1000;
            this.timerGlobal.Tick += new System.EventHandler(this.timerGlobal_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "En Espera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "En Ejecucion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(882, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Terminados";
            // 
            // btnGenerarProcesos
            // 
            this.btnGenerarProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnGenerarProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarProcesos.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarProcesos.ForeColor = System.Drawing.Color.White;
            this.btnGenerarProcesos.Location = new System.Drawing.Point(317, 39);
            this.btnGenerarProcesos.Name = "btnGenerarProcesos";
            this.btnGenerarProcesos.Size = new System.Drawing.Size(98, 43);
            this.btnGenerarProcesos.TabIndex = 4;
            this.btnGenerarProcesos.Text = "Generar";
            this.btnGenerarProcesos.UseVisualStyleBackColor = false;
            this.btnGenerarProcesos.Click += new System.EventHandler(this.btnGenerarProcesos_Click);
            // 
            // lblValidacionNumProcesos
            // 
            this.lblValidacionNumProcesos.AutoSize = true;
            this.lblValidacionNumProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValidacionNumProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidacionNumProcesos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblValidacionNumProcesos.Location = new System.Drawing.Point(179, 108);
            this.lblValidacionNumProcesos.Name = "lblValidacionNumProcesos";
            this.lblValidacionNumProcesos.Size = new System.Drawing.Size(103, 20);
            this.lblValidacionNumProcesos.TabIndex = 5;
            this.lblValidacionNumProcesos.Text = "mensaje aqui";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(772, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tiempo: ";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTiempo.Location = new System.Drawing.Point(871, 53);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(43, 20);
            this.lblTiempo.TabIndex = 0;
            this.lblTiempo.Text = "segs";
            // 
            // listEspera
            // 
            this.listEspera.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lote,
            this.Nombre,
            this.Operacion,
            this.Tiempo});
            this.listEspera.HideSelection = false;
            this.listEspera.Location = new System.Drawing.Point(23, 191);
            this.listEspera.Name = "listEspera";
            this.listEspera.Size = new System.Drawing.Size(316, 380);
            this.listEspera.TabIndex = 6;
            this.listEspera.UseCompatibleStateImageBehavior = false;
            this.listEspera.View = System.Windows.Forms.View.Details;
            // 
            // Lote
            // 
            this.Lote.Tag = "";
            this.Lote.Text = "Lote";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 94;
            // 
            // Operacion
            // 
            this.Operacion.Text = "Operacion";
            this.Operacion.Width = 80;
            // 
            // Tiempo
            // 
            this.Tiempo.Text = "Tiempo";
            this.Tiempo.Width = 77;
            // 
            // listEjecucion
            // 
            this.listEjecucion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listEjecucion.HideSelection = false;
            this.listEjecucion.Location = new System.Drawing.Point(380, 331);
            this.listEjecucion.Name = "listEjecucion";
            this.listEjecucion.Size = new System.Drawing.Size(321, 146);
            this.listEjecucion.TabIndex = 6;
            this.listEjecucion.UseCompatibleStateImageBehavior = false;
            this.listEjecucion.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Lote";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Operacion";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tiempo";
            this.columnHeader4.Width = 77;
            // 
            // listTerminados
            // 
            this.listTerminados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listTerminados.HideSelection = false;
            this.listTerminados.Location = new System.Drawing.Point(776, 193);
            this.listTerminados.Name = "listTerminados";
            this.listTerminados.Size = new System.Drawing.Size(316, 380);
            this.listTerminados.TabIndex = 6;
            this.listTerminados.UseCompatibleStateImageBehavior = false;
            this.listTerminados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Tag = "";
            this.columnHeader5.Text = "Lote";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nombre";
            this.columnHeader6.Width = 94;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Operacion";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tiempo";
            this.columnHeader8.Width = 77;
            // 
            // btnObtenerResultados
            // 
            this.btnObtenerResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(179)))), ((int)(((byte)(8)))));
            this.btnObtenerResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObtenerResultados.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnObtenerResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObtenerResultados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenerResultados.ForeColor = System.Drawing.Color.White;
            this.btnObtenerResultados.Location = new System.Drawing.Point(776, 599);
            this.btnObtenerResultados.Name = "btnObtenerResultados";
            this.btnObtenerResultados.Size = new System.Drawing.Size(316, 43);
            this.btnObtenerResultados.TabIndex = 4;
            this.btnObtenerResultados.Text = "Obtener Resultados";
            this.btnObtenerResultados.UseVisualStyleBackColor = false;
            this.btnObtenerResultados.Click += new System.EventHandler(this.btnObtenerResultados_Click);
            // 
            // lblReporteMsg
            // 
            this.lblReporteMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReporteMsg.AutoSize = true;
            this.lblReporteMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteMsg.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblReporteMsg.Location = new System.Drawing.Point(20, 665);
            this.lblReporteMsg.Name = "lblReporteMsg";
            this.lblReporteMsg.Size = new System.Drawing.Size(121, 16);
            this.lblReporteMsg.TabIndex = 0;
            this.lblReporteMsg.Text = "Mensaje Exitoso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 704);
            this.Controls.Add(this.listEjecucion);
            this.Controls.Add(this.listTerminados);
            this.Controls.Add(this.listEspera);
            this.Controls.Add(this.lblValidacionNumProcesos);
            this.Controls.Add(this.btnObtenerResultados);
            this.Controls.Add(this.btnGenerarProcesos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumProcesos);
            this.Controls.Add(this.lblReporteMsg);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Procesamiento Por Lotes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumProcesos;
        private System.Windows.Forms.Timer timerGlobal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerarProcesos;
        private System.Windows.Forms.Label lblValidacionNumProcesos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.ListView listEspera;
        private System.Windows.Forms.ColumnHeader Lote;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Operacion;
        private System.Windows.Forms.ColumnHeader Tiempo;
        private System.Windows.Forms.ListView listEjecucion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listTerminados;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnObtenerResultados;
        private System.Windows.Forms.Label lblReporteMsg;
    }
}

