namespace ModuloFacturacion
{
    partial class FrmFacturacionProducto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturacionProducto));
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.dgPro = new System.Windows.Forms.DataGridView();
            this.sAV = new ModuloFacturacion.SAV();
            this.iNMPRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iN_M_PRODUCTOTableAdapter = new ModuloFacturacion.SAVTableAdapters.IN_M_PRODUCTOTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMPRODUCTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(40, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.EditValueChanged += new System.EventHandler(this.txtNombre_EditValueChanged);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(50, 12);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdbCodigo.TabIndex = 3;
            this.rdbCodigo.Text = "Codigo";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.rdbCodigo_CheckedChanged);
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(50, 35);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(62, 17);
            this.rdbNombre.TabIndex = 4;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(209, 12);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 5;
            // 
            // dgPro
            // 
            this.dgPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPro.Location = new System.Drawing.Point(12, 115);
            this.dgPro.Name = "dgPro";
            this.dgPro.ShowCellErrors = false;
            this.dgPro.Size = new System.Drawing.Size(430, 136);
            this.dgPro.TabIndex = 6;
            this.dgPro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // sAV
            // 
            this.sAV.DataSetName = "SAV";
            this.sAV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNMPRODUCTOBindingSource
            // 
            this.iNMPRODUCTOBindingSource.DataMember = "IN_M_PRODUCTO";
            this.iNMPRODUCTOBindingSource.DataSource = this.sAV;
            // 
            // iN_M_PRODUCTOTableAdapter
            // 
            this.iN_M_PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad:";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(317, 79);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(37, 20);
            this.txtCant.TabIndex = 8;
            // 
            // FrmFacturacionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 255);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPro);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.rdbNombre);
            this.Controls.Add(this.rdbCodigo);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFacturacionProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FrmFacturacionProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMPRODUCTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNombre;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private SAV sAV;
        private System.Windows.Forms.BindingSource iNMPRODUCTOBindingSource;
        private SAVTableAdapters.IN_M_PRODUCTOTableAdapter iN_M_PRODUCTOTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCant;
        public System.Windows.Forms.DataGridView dgPro;
    }
}