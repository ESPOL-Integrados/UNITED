namespace Sistema_compras.Formularios
{
    partial class frm_ConsultarGenerales
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_lbl_Fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_Solicitudes = new System.Windows.Forms.RadioButton();
            this.rdb_cotizaciones = new System.Windows.Forms.RadioButton();
            this.rdb_ordenCompra = new System.Windows.Forms.RadioButton();
            this.btn_GenerarReporte = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.tss_lbl_Fecha});
            this.statusStrip.Location = new System.Drawing.Point(0, 208);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(310, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // tss_lbl_Fecha
            // 
            this.tss_lbl_Fecha.Name = "tss_lbl_Fecha";
            this.tss_lbl_Fecha.Size = new System.Drawing.Size(54, 17);
            this.tss_lbl_Fecha.Text = "lbl_fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_ordenCompra);
            this.groupBox1.Controls.Add(this.rdb_cotizaciones);
            this.groupBox1.Controls.Add(this.rdb_Solicitudes);
            this.groupBox1.Location = new System.Drawing.Point(34, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Reporte:";
            // 
            // rdb_Solicitudes
            // 
            this.rdb_Solicitudes.AutoSize = true;
            this.rdb_Solicitudes.Location = new System.Drawing.Point(32, 33);
            this.rdb_Solicitudes.Name = "rdb_Solicitudes";
            this.rdb_Solicitudes.Size = new System.Drawing.Size(76, 17);
            this.rdb_Solicitudes.TabIndex = 0;
            this.rdb_Solicitudes.TabStop = true;
            this.rdb_Solicitudes.Text = "Solicitudes";
            this.rdb_Solicitudes.UseVisualStyleBackColor = true;
            // 
            // rdb_cotizaciones
            // 
            this.rdb_cotizaciones.AutoSize = true;
            this.rdb_cotizaciones.Location = new System.Drawing.Point(32, 56);
            this.rdb_cotizaciones.Name = "rdb_cotizaciones";
            this.rdb_cotizaciones.Size = new System.Drawing.Size(85, 17);
            this.rdb_cotizaciones.TabIndex = 0;
            this.rdb_cotizaciones.TabStop = true;
            this.rdb_cotizaciones.Text = "Cotizaciones";
            this.rdb_cotizaciones.UseVisualStyleBackColor = true;
            // 
            // rdb_ordenCompra
            // 
            this.rdb_ordenCompra.AutoSize = true;
            this.rdb_ordenCompra.Location = new System.Drawing.Point(32, 79);
            this.rdb_ordenCompra.Name = "rdb_ordenCompra";
            this.rdb_ordenCompra.Size = new System.Drawing.Size(124, 17);
            this.rdb_ordenCompra.TabIndex = 0;
            this.rdb_ordenCompra.TabStop = true;
            this.rdb_ordenCompra.Text = "Ordenes de Compras";
            this.rdb_ordenCompra.UseVisualStyleBackColor = true;
            // 
            // btn_GenerarReporte
            // 
            this.btn_GenerarReporte.Location = new System.Drawing.Point(85, 164);
            this.btn_GenerarReporte.Name = "btn_GenerarReporte";
            this.btn_GenerarReporte.Size = new System.Drawing.Size(120, 23);
            this.btn_GenerarReporte.TabIndex = 5;
            this.btn_GenerarReporte.Text = "Generar Reporte";
            this.btn_GenerarReporte.UseVisualStyleBackColor = true;
            // 
            // frm_ConsultarGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 230);
            this.Controls.Add(this.btn_GenerarReporte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Name = "frm_ConsultarGenerales";
            this.Text = "Consultas Generales";
            this.Load += new System.EventHandler(this.frm_ConsultarGenerales_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_Fecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_ordenCompra;
        private System.Windows.Forms.RadioButton rdb_cotizaciones;
        private System.Windows.Forms.RadioButton rdb_Solicitudes;
        private System.Windows.Forms.Button btn_GenerarReporte;
    }
}