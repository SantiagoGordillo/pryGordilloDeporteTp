namespace pryGordilloDeporteTp
{
    partial class frmPrincipal
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
            this.msPantallaDeInicio = new System.Windows.Forms.MenuStrip();
            this.tsiRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiRegistroDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiRegistroEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiConsultaDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiConsultaEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiModificarDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiModificarEntrenadores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEliminarDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEliminarEntrenadores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.msPantallaDeInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPantallaDeInicio
            // 
            this.msPantallaDeInicio.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msPantallaDeInicio.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msPantallaDeInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiRegistro,
            this.tsiConsulta,
            this.tsiModificar,
            this.tsiEliminar,
            this.tsiSalir});
            this.msPantallaDeInicio.Location = new System.Drawing.Point(0, 0);
            this.msPantallaDeInicio.Name = "msPantallaDeInicio";
            this.msPantallaDeInicio.Size = new System.Drawing.Size(530, 33);
            this.msPantallaDeInicio.TabIndex = 8;
            this.msPantallaDeInicio.Text = "menuStrip1";
            // 
            // tsiRegistro
            // 
            this.tsiRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiRegistroDeportista,
            this.tsiRegistroEntrenador});
            this.tsiRegistro.Name = "tsiRegistro";
            this.tsiRegistro.Size = new System.Drawing.Size(93, 29);
            this.tsiRegistro.Text = "Registro";
            // 
            // tsiRegistroDeportista
            // 
            this.tsiRegistroDeportista.Name = "tsiRegistroDeportista";
            this.tsiRegistroDeportista.Size = new System.Drawing.Size(201, 34);
            this.tsiRegistroDeportista.Text = "Deportista";
            this.tsiRegistroDeportista.Click += new System.EventHandler(this.TSMRegistroDeportista_Click);
            // 
            // tsiRegistroEntrenador
            // 
            this.tsiRegistroEntrenador.Name = "tsiRegistroEntrenador";
            this.tsiRegistroEntrenador.Size = new System.Drawing.Size(201, 34);
            this.tsiRegistroEntrenador.Text = "Entrenador";
            this.tsiRegistroEntrenador.Click += new System.EventHandler(this.TSMRegistroEntrenador_Click);
            // 
            // tsiConsulta
            // 
            this.tsiConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiConsultaDeportista,
            this.tsiConsultaEntrenador});
            this.tsiConsulta.Name = "tsiConsulta";
            this.tsiConsulta.Size = new System.Drawing.Size(97, 29);
            this.tsiConsulta.Text = "Consulta";
            // 
            // tsiConsultaDeportista
            // 
            this.tsiConsultaDeportista.Name = "tsiConsultaDeportista";
            this.tsiConsultaDeportista.Size = new System.Drawing.Size(201, 34);
            this.tsiConsultaDeportista.Text = "Deportista";
            this.tsiConsultaDeportista.Click += new System.EventHandler(this.TSMConsultaDeportista_Click);
            // 
            // tsiConsultaEntrenador
            // 
            this.tsiConsultaEntrenador.Name = "tsiConsultaEntrenador";
            this.tsiConsultaEntrenador.Size = new System.Drawing.Size(201, 34);
            this.tsiConsultaEntrenador.Text = "Entrenador";
            this.tsiConsultaEntrenador.Click += new System.EventHandler(this.TSMConsultaEntrenador_Click);
            // 
            // tsiModificar
            // 
            this.tsiModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiModificarDeportista,
            this.tsiModificarEntrenadores});
            this.tsiModificar.Name = "tsiModificar";
            this.tsiModificar.Size = new System.Drawing.Size(103, 29);
            this.tsiModificar.Text = "Modificar";
            // 
            // tsiModificarDeportista
            // 
            this.tsiModificarDeportista.Name = "tsiModificarDeportista";
            this.tsiModificarDeportista.Size = new System.Drawing.Size(218, 34);
            this.tsiModificarDeportista.Text = "Deportista";
            this.tsiModificarDeportista.Click += new System.EventHandler(this.TSMModificarDeportista_Click);
            // 
            // tsiModificarEntrenadores
            // 
            this.tsiModificarEntrenadores.Name = "tsiModificarEntrenadores";
            this.tsiModificarEntrenadores.Size = new System.Drawing.Size(218, 34);
            this.tsiModificarEntrenadores.Text = "Entrenadores";
            this.tsiModificarEntrenadores.Click += new System.EventHandler(this.TSMModificarEntrenadores_Click);
            // 
            // tsiEliminar
            // 
            this.tsiEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiEliminarDeportista,
            this.tsiEliminarEntrenadores});
            this.tsiEliminar.Name = "tsiEliminar";
            this.tsiEliminar.Size = new System.Drawing.Size(90, 29);
            this.tsiEliminar.Text = "Eliminar";
            // 
            // tsiEliminarDeportista
            // 
            this.tsiEliminarDeportista.Name = "tsiEliminarDeportista";
            this.tsiEliminarDeportista.Size = new System.Drawing.Size(218, 34);
            this.tsiEliminarDeportista.Text = "Deportista";
            this.tsiEliminarDeportista.Click += new System.EventHandler(this.TSMEliminarDeportista_Click);
            // 
            // tsiEliminarEntrenadores
            // 
            this.tsiEliminarEntrenadores.Name = "tsiEliminarEntrenadores";
            this.tsiEliminarEntrenadores.Size = new System.Drawing.Size(218, 34);
            this.tsiEliminarEntrenadores.Text = "Entrenadores";
            this.tsiEliminarEntrenadores.Click += new System.EventHandler(this.TSMEliminarEntrenadores_Click);
            // 
            // tsiSalir
            // 
            this.tsiSalir.Name = "tsiSalir";
            this.tsiSalir.Size = new System.Drawing.Size(61, 29);
            this.tsiSalir.Text = "Salir";
            this.tsiSalir.Click += new System.EventHandler(this.TSMSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(530, 174);
            this.Controls.Add(this.msPantallaDeInicio);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Bienvenidos al Club";
            this.msPantallaDeInicio.ResumeLayout(false);
            this.msPantallaDeInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPantallaDeInicio;
        private System.Windows.Forms.ToolStripMenuItem tsiRegistro;
        private System.Windows.Forms.ToolStripMenuItem tsiRegistroDeportista;
        private System.Windows.Forms.ToolStripMenuItem tsiRegistroEntrenador;
        private System.Windows.Forms.ToolStripMenuItem tsiConsulta;
        private System.Windows.Forms.ToolStripMenuItem tsiConsultaDeportista;
        private System.Windows.Forms.ToolStripMenuItem tsiConsultaEntrenador;
        private System.Windows.Forms.ToolStripMenuItem tsiModificar;
        private System.Windows.Forms.ToolStripMenuItem tsiModificarDeportista;
        private System.Windows.Forms.ToolStripMenuItem tsiModificarEntrenadores;
        private System.Windows.Forms.ToolStripMenuItem tsiEliminar;
        private System.Windows.Forms.ToolStripMenuItem tsiEliminarDeportista;
        private System.Windows.Forms.ToolStripMenuItem tsiEliminarEntrenadores;
        private System.Windows.Forms.ToolStripMenuItem tsiSalir;
    }
}

