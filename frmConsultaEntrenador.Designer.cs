namespace pryGordilloDeporteTp
{
    partial class frmConsultaEntrenador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvConsultaEntrenadores = new System.Windows.Forms.DataGridView();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEntrenadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaEntrenadores
            // 
            this.dgvConsultaEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaEntrenadores.Location = new System.Drawing.Point(13, 14);
            this.dgvConsultaEntrenadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvConsultaEntrenadores.Name = "dgvConsultaEntrenadores";
            this.dgvConsultaEntrenadores.RowHeadersWidth = 62;
            this.dgvConsultaEntrenadores.Size = new System.Drawing.Size(1026, 231);
            this.dgvConsultaEntrenadores.TabIndex = 28;
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.White;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(13, 268);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(102, 40);
            this.cmdSalir.TabIndex = 31;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.BackColor = System.Drawing.Color.White;
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(908, 268);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(113, 40);
            this.cmdConsultar.TabIndex = 32;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = false;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // frmConsultaEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1052, 329);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.dgvConsultaEntrenadores);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaEntrenador";
            this.Text = "Consulta De Entrenadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEntrenadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvConsultaEntrenadores;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdConsultar;
    }
}