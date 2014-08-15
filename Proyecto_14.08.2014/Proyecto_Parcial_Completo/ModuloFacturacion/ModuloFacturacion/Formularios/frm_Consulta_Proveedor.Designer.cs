namespace ModuloFacturacion.Formularios
{
    partial class frm_Consulta_Proveedor
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
            this.dgv_ConsultaProveedor = new System.Windows.Forms.DataGridView();
            this.codigoProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaingresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsablelegalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contabilidadDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulapassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPMPROVEEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAV_COMPRAS_DataSet = new ModuloFacturacion.SAV_COMPRAS_DataSet();
            this.cP_M_PROVEEDORTableAdapter = new ModuloFacturacion.SAV_COMPRAS_DataSetTableAdapters.CP_M_PROVEEDORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultaProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMPROVEEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAV_COMPRAS_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ConsultaProveedor
            // 
            this.dgv_ConsultaProveedor.AllowUserToAddRows = false;
            this.dgv_ConsultaProveedor.AllowUserToDeleteRows = false;
            this.dgv_ConsultaProveedor.AutoGenerateColumns = false;
            this.dgv_ConsultaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ConsultaProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProveedorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.razonSocialDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.fechaingresoDataGridViewTextBoxColumn,
            this.responsablelegalDataGridViewTextBoxColumn,
            this.contabilidadDataGridViewCheckBoxColumn,
            this.rucDataGridViewTextBoxColumn,
            this.cedulapassDataGridViewTextBoxColumn,
            this.idtipoproductoDataGridViewTextBoxColumn});
            this.dgv_ConsultaProveedor.DataSource = this.cPMPROVEEDORBindingSource;
            this.dgv_ConsultaProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ConsultaProveedor.Location = new System.Drawing.Point(0, 0);
            this.dgv_ConsultaProveedor.Name = "dgv_ConsultaProveedor";
            this.dgv_ConsultaProveedor.ReadOnly = true;
            this.dgv_ConsultaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ConsultaProveedor.Size = new System.Drawing.Size(1145, 184);
            this.dgv_ConsultaProveedor.TabIndex = 0;
            this.dgv_ConsultaProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ConsultaProveedor_CellContentClick);
            // 
            // codigoProveedorDataGridViewTextBoxColumn
            // 
            this.codigoProveedorDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Proveedor";
            this.codigoProveedorDataGridViewTextBoxColumn.HeaderText = "Codigo_Proveedor";
            this.codigoProveedorDataGridViewTextBoxColumn.Name = "codigoProveedorDataGridViewTextBoxColumn";
            this.codigoProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "razonSocial";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "razonSocial";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            this.razonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaingresoDataGridViewTextBoxColumn
            // 
            this.fechaingresoDataGridViewTextBoxColumn.DataPropertyName = "fecha_ingreso";
            this.fechaingresoDataGridViewTextBoxColumn.HeaderText = "fecha_ingreso";
            this.fechaingresoDataGridViewTextBoxColumn.Name = "fechaingresoDataGridViewTextBoxColumn";
            this.fechaingresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responsablelegalDataGridViewTextBoxColumn
            // 
            this.responsablelegalDataGridViewTextBoxColumn.DataPropertyName = "responsable_legal";
            this.responsablelegalDataGridViewTextBoxColumn.HeaderText = "responsable_legal";
            this.responsablelegalDataGridViewTextBoxColumn.Name = "responsablelegalDataGridViewTextBoxColumn";
            this.responsablelegalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contabilidadDataGridViewCheckBoxColumn
            // 
            this.contabilidadDataGridViewCheckBoxColumn.DataPropertyName = "contabilidad";
            this.contabilidadDataGridViewCheckBoxColumn.HeaderText = "contabilidad";
            this.contabilidadDataGridViewCheckBoxColumn.Name = "contabilidadDataGridViewCheckBoxColumn";
            this.contabilidadDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // rucDataGridViewTextBoxColumn
            // 
            this.rucDataGridViewTextBoxColumn.DataPropertyName = "ruc";
            this.rucDataGridViewTextBoxColumn.HeaderText = "ruc";
            this.rucDataGridViewTextBoxColumn.Name = "rucDataGridViewTextBoxColumn";
            this.rucDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulapassDataGridViewTextBoxColumn
            // 
            this.cedulapassDataGridViewTextBoxColumn.DataPropertyName = "cedula_pass";
            this.cedulapassDataGridViewTextBoxColumn.HeaderText = "cedula_pass";
            this.cedulapassDataGridViewTextBoxColumn.Name = "cedulapassDataGridViewTextBoxColumn";
            this.cedulapassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtipoproductoDataGridViewTextBoxColumn
            // 
            this.idtipoproductoDataGridViewTextBoxColumn.DataPropertyName = "id_tipo_producto";
            this.idtipoproductoDataGridViewTextBoxColumn.HeaderText = "id_tipo_producto";
            this.idtipoproductoDataGridViewTextBoxColumn.Name = "idtipoproductoDataGridViewTextBoxColumn";
            this.idtipoproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPMPROVEEDORBindingSource
            // 
            this.cPMPROVEEDORBindingSource.DataMember = "CP_M_PROVEEDOR";
            this.cPMPROVEEDORBindingSource.DataSource = this.sAV_COMPRAS_DataSet;
            // 
            // sAV_COMPRAS_DataSet
            // 
            this.sAV_COMPRAS_DataSet.DataSetName = "SAV_COMPRAS_DataSet";
            this.sAV_COMPRAS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cP_M_PROVEEDORTableAdapter
            // 
            this.cP_M_PROVEEDORTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Consulta_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 184);
            this.Controls.Add(this.dgv_ConsultaProveedor);
            this.Name = "frm_Consulta_Proveedor";
            this.Text = "Consulta de Proveedor";
            this.Load += new System.EventHandler(this.frm_Consulta_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultaProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMPROVEEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAV_COMPRAS_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ConsultaProveedor;
        private SAV_COMPRAS_DataSet sAV_COMPRAS_DataSet;
        private System.Windows.Forms.BindingSource cPMPROVEEDORBindingSource;
        private SAV_COMPRAS_DataSetTableAdapters.CP_M_PROVEEDORTableAdapter cP_M_PROVEEDORTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaingresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsablelegalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn contabilidadDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulapassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipoproductoDataGridViewTextBoxColumn;
    }
}