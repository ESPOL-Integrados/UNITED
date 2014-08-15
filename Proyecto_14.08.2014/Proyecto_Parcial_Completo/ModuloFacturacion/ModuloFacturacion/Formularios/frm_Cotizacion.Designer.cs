namespace Sistema_compras.Formularios
{
    partial class frm_Cotizacion
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tss_lbl_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_lbl_fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.cbx_Estado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmfecha_entraga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.grb_controles = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb_controles.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_lbl_user,
            this.tss_lbl_fecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(644, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tss_lbl_user
            // 
            this.tss_lbl_user.Name = "tss_lbl_user";
            this.tss_lbl_user.Size = new System.Drawing.Size(47, 17);
            this.tss_lbl_user.Text = "lbl_user";
            // 
            // tss_lbl_fecha
            // 
            this.tss_lbl_fecha.Name = "tss_lbl_fecha";
            this.tss_lbl_fecha.Size = new System.Drawing.Size(54, 17);
            this.tss_lbl_fecha.Text = "lbl_fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de Pedido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.AutoSize = true;
            this.btn_Consultar.Location = new System.Drawing.Point(276, 37);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(31, 23);
            this.btn_Consultar.TabIndex = 4;
            this.btn_Consultar.Text = "...";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(386, 43);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(90, 13);
            this.lbl_fecha.TabIndex = 2;
            this.lbl_fecha.Text = "Fecha de pedido:";
            // 
            // cbx_Estado
            // 
            this.cbx_Estado.FormattingEnabled = true;
            this.cbx_Estado.Location = new System.Drawing.Point(496, 39);
            this.cbx_Estado.Name = "cbx_Estado";
            this.cbx_Estado.Size = new System.Drawing.Size(121, 21);
            this.cbx_Estado.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(36, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 207);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmfecha_entraga,
            this.clm_Proveedor,
            this.clm_Total});
            this.dataGridView1.Location = new System.Drawing.Point(16, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmfecha_entraga
            // 
            this.clmfecha_entraga.HeaderText = "Fecha de Entrega";
            this.clmfecha_entraga.Name = "clmfecha_entraga";
            // 
            // clm_Proveedor
            // 
            this.clm_Proveedor.HeaderText = "Provedor";
            this.clm_Proveedor.Name = "clm_Proveedor";
            // 
            // clm_Total
            // 
            this.clm_Total.HeaderText = "Total";
            this.clm_Total.Name = "clm_Total";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(389, 317);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.Text = "&Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(284, 317);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 8;
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(177, 317);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 9;
            this.btn_Nuevo.Text = "&Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // grb_controles
            // 
            this.grb_controles.Controls.Add(this.btnQuitar);
            this.grb_controles.Controls.Add(this.btn_imprimir);
            this.grb_controles.Controls.Add(this.button1);
            this.grb_controles.Location = new System.Drawing.Point(453, 90);
            this.grb_controles.Name = "grb_controles";
            this.grb_controles.Size = new System.Drawing.Size(167, 150);
            this.grb_controles.TabIndex = 15;
            this.grb_controles.TabStop = false;
            this.grb_controles.Text = "Proveedores: Controles";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(29, 60);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(112, 23);
            this.btnQuitar.TabIndex = 0;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(29, 89);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(112, 23);
            this.btn_imprimir.TabIndex = 0;
            this.btn_imprimir.Text = "&Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 386);
            this.Controls.Add(this.grb_controles);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbx_Estado);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frm_Cotizacion";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.frm_Cotizacion_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grb_controles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_user;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.ComboBox cbx_Estado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfecha_entraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Total;
        private System.Windows.Forms.GroupBox grb_controles;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button button1;
    }
}