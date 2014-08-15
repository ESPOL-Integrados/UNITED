namespace Sistema_compras.Formularios
{
    partial class frm_Proveedor
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tss_lbl_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_lbl_fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_tipo_producto = new System.Windows.Forms.ComboBox();
            this.iNRTIPOPRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAV_INVENTARIO_DataSet = new ModuloFacturacion.SAV_INVENTARIO_DataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.grb_DatosProveedor = new System.Windows.Forms.GroupBox();
            this.btn_consultar_Proveedor = new System.Windows.Forms.Button();
            this.txt_fecha_ingreso = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.txt_responsable = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_razonSocial = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_cdigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_RUC = new System.Windows.Forms.Label();
            this.txt_ruc = new System.Windows.Forms.TextBox();
            this.gpb_tipoProveedor = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdb_Contabilidad_NO = new System.Windows.Forms.RadioButton();
            this.rdb_Contabilidad_YES = new System.Windows.Forms.RadioButton();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iN_R_TIPO_PRODUCTOTableAdapter = new ModuloFacturacion.SAV_INVENTARIO_DataSetTableAdapters.IN_R_TIPO_PRODUCTOTableAdapter();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNRTIPOPRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAV_INVENTARIO_DataSet)).BeginInit();
            this.grb_DatosProveedor.SuspendLayout();
            this.gpb_tipoProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_lbl_user,
            this.tss_lbl_fecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(665, 22);
            this.statusStrip1.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_tipo_producto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(337, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos que despacha";
            // 
            // cbx_tipo_producto
            // 
            this.cbx_tipo_producto.DataSource = this.iNRTIPOPRODUCTOBindingSource;
            this.cbx_tipo_producto.DisplayMember = "DescripcionTipoProducto";
            this.cbx_tipo_producto.FormattingEnabled = true;
            this.cbx_tipo_producto.Location = new System.Drawing.Point(115, 38);
            this.cbx_tipo_producto.Name = "cbx_tipo_producto";
            this.cbx_tipo_producto.Size = new System.Drawing.Size(121, 21);
            this.cbx_tipo_producto.TabIndex = 1;
            this.cbx_tipo_producto.ValueMember = "DescripcionTipoProducto";
            // 
            // iNRTIPOPRODUCTOBindingSource
            // 
            this.iNRTIPOPRODUCTOBindingSource.DataMember = "IN_R_TIPO_PRODUCTO";
            this.iNRTIPOPRODUCTOBindingSource.DataSource = this.sAV_INVENTARIO_DataSet;
            // 
            // sAV_INVENTARIO_DataSet
            // 
            this.sAV_INVENTARIO_DataSet.DataSetName = "SAV_INVENTARIO_DataSet";
            this.sAV_INVENTARIO_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de producto";
            // 
            // grb_DatosProveedor
            // 
            this.grb_DatosProveedor.Controls.Add(this.btn_consultar_Proveedor);
            this.grb_DatosProveedor.Controls.Add(this.txt_fecha_ingreso);
            this.grb_DatosProveedor.Controls.Add(this.txt_direccion);
            this.grb_DatosProveedor.Controls.Add(this.txt_telefono);
            this.grb_DatosProveedor.Controls.Add(this.txt_razon_social);
            this.grb_DatosProveedor.Controls.Add(this.txt_responsable);
            this.grb_DatosProveedor.Controls.Add(this.txt_codigo);
            this.grb_DatosProveedor.Controls.Add(this.txt_nombre);
            this.grb_DatosProveedor.Controls.Add(this.lbl_direccion);
            this.grb_DatosProveedor.Controls.Add(this.label2);
            this.grb_DatosProveedor.Controls.Add(this.lbl_telefono);
            this.grb_DatosProveedor.Controls.Add(this.lbl_razonSocial);
            this.grb_DatosProveedor.Controls.Add(this.label3);
            this.grb_DatosProveedor.Controls.Add(this.lbl_cdigo);
            this.grb_DatosProveedor.Controls.Add(this.label1);
            this.grb_DatosProveedor.Location = new System.Drawing.Point(36, 29);
            this.grb_DatosProveedor.Name = "grb_DatosProveedor";
            this.grb_DatosProveedor.Size = new System.Drawing.Size(612, 165);
            this.grb_DatosProveedor.TabIndex = 4;
            this.grb_DatosProveedor.TabStop = false;
            this.grb_DatosProveedor.Text = "Datos Generales:";
            // 
            // btn_consultar_Proveedor
            // 
            this.btn_consultar_Proveedor.Location = new System.Drawing.Point(276, 30);
            this.btn_consultar_Proveedor.Name = "btn_consultar_Proveedor";
            this.btn_consultar_Proveedor.Size = new System.Drawing.Size(39, 20);
            this.btn_consultar_Proveedor.TabIndex = 5;
            this.btn_consultar_Proveedor.Text = "...";
            this.btn_consultar_Proveedor.UseVisualStyleBackColor = true;
            this.btn_consultar_Proveedor.Click += new System.EventHandler(this.btn_consultar_Proveedor_Click);
            // 
            // txt_fecha_ingreso
            // 
            this.txt_fecha_ingreso.Enabled = false;
            this.txt_fecha_ingreso.Location = new System.Drawing.Point(467, 31);
            this.txt_fecha_ingreso.Name = "txt_fecha_ingreso";
            this.txt_fecha_ingreso.Size = new System.Drawing.Size(127, 20);
            this.txt_fecha_ingreso.TabIndex = 5;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(467, 96);
            this.txt_direccion.MaxLength = 50;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(130, 51);
            this.txt_direccion.TabIndex = 4;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(137, 127);
            this.txt_telefono.MaxLength = 15;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(130, 20);
            this.txt_telefono.TabIndex = 3;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Location = new System.Drawing.Point(137, 97);
            this.txt_razon_social.MaxLength = 20;
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(130, 20);
            this.txt_razon_social.TabIndex = 2;
            // 
            // txt_responsable
            // 
            this.txt_responsable.Location = new System.Drawing.Point(467, 62);
            this.txt_responsable.MaxLength = 20;
            this.txt_responsable.Name = "txt_responsable";
            this.txt_responsable.Size = new System.Drawing.Size(127, 20);
            this.txt_responsable.TabIndex = 6;
            this.txt_responsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_responsable_KeyPress);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(136, 30);
            this.txt_codigo.MaxLength = 5;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(130, 20);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(136, 62);
            this.txt_nombre.MaxLength = 20;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(130, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(370, 99);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(55, 13);
            this.lbl_direccion.TabIndex = 0;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Ingreso:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(40, 130);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefono.TabIndex = 0;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_razonSocial
            // 
            this.lbl_razonSocial.AutoSize = true;
            this.lbl_razonSocial.Location = new System.Drawing.Point(40, 100);
            this.lbl_razonSocial.Name = "lbl_razonSocial";
            this.lbl_razonSocial.Size = new System.Drawing.Size(73, 13);
            this.lbl_razonSocial.TabIndex = 0;
            this.lbl_razonSocial.Text = "Razon Social:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Responsable";
            // 
            // lbl_cdigo
            // 
            this.lbl_cdigo.AutoSize = true;
            this.lbl_cdigo.Location = new System.Drawing.Point(40, 30);
            this.lbl_cdigo.Name = "lbl_cdigo";
            this.lbl_cdigo.Size = new System.Drawing.Size(43, 13);
            this.lbl_cdigo.TabIndex = 0;
            this.lbl_cdigo.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(337, 301);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 5;
            this.btn_Nuevo.Text = "&Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(337, 332);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 5;
            this.btn_consultar.Text = "&Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(517, 301);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 5;
            this.btn_Modificar.Text = "&Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(429, 332);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "&Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(429, 301);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_RUC
            // 
            this.lbl_RUC.AutoSize = true;
            this.lbl_RUC.Location = new System.Drawing.Point(5, 137);
            this.lbl_RUC.Name = "lbl_RUC";
            this.lbl_RUC.Size = new System.Drawing.Size(33, 13);
            this.lbl_RUC.TabIndex = 0;
            this.lbl_RUC.Text = "RUC:";
            // 
            // txt_ruc
            // 
            this.txt_ruc.Location = new System.Drawing.Point(125, 134);
            this.txt_ruc.MaxLength = 13;
            this.txt_ruc.Name = "txt_ruc";
            this.txt_ruc.Size = new System.Drawing.Size(130, 20);
            this.txt_ruc.TabIndex = 9;
            this.txt_ruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ruc_KeyPress);
            // 
            // gpb_tipoProveedor
            // 
            this.gpb_tipoProveedor.Controls.Add(this.label5);
            this.gpb_tipoProveedor.Controls.Add(this.rdb_Contabilidad_NO);
            this.gpb_tipoProveedor.Controls.Add(this.rdb_Contabilidad_YES);
            this.gpb_tipoProveedor.Controls.Add(this.txt_cedula);
            this.gpb_tipoProveedor.Controls.Add(this.txt_ruc);
            this.gpb_tipoProveedor.Controls.Add(this.label6);
            this.gpb_tipoProveedor.Controls.Add(this.lbl_RUC);
            this.gpb_tipoProveedor.Location = new System.Drawing.Point(36, 200);
            this.gpb_tipoProveedor.Name = "gpb_tipoProveedor";
            this.gpb_tipoProveedor.Size = new System.Drawing.Size(270, 171);
            this.gpb_tipoProveedor.TabIndex = 6;
            this.gpb_tipoProveedor.TabStop = false;
            this.gpb_tipoProveedor.Text = "Tipo de Provedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "¿Esta Obligado a llevar Contabilidad?";
            // 
            // rdb_Contabilidad_NO
            // 
            this.rdb_Contabilidad_NO.AutoSize = true;
            this.rdb_Contabilidad_NO.Checked = true;
            this.rdb_Contabilidad_NO.Location = new System.Drawing.Point(111, 64);
            this.rdb_Contabilidad_NO.Name = "rdb_Contabilidad_NO";
            this.rdb_Contabilidad_NO.Size = new System.Drawing.Size(39, 17);
            this.rdb_Contabilidad_NO.TabIndex = 1;
            this.rdb_Contabilidad_NO.TabStop = true;
            this.rdb_Contabilidad_NO.Text = "&No";
            this.rdb_Contabilidad_NO.UseVisualStyleBackColor = true;
            // 
            // rdb_Contabilidad_YES
            // 
            this.rdb_Contabilidad_YES.AutoSize = true;
            this.rdb_Contabilidad_YES.Location = new System.Drawing.Point(43, 62);
            this.rdb_Contabilidad_YES.Name = "rdb_Contabilidad_YES";
            this.rdb_Contabilidad_YES.Size = new System.Drawing.Size(34, 17);
            this.rdb_Contabilidad_YES.TabIndex = 0;
            this.rdb_Contabilidad_YES.TabStop = true;
            this.rdb_Contabilidad_YES.Text = "&Si";
            this.rdb_Contabilidad_YES.UseVisualStyleBackColor = true;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(125, 108);
            this.txt_cedula.MaxLength = 10;
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(130, 20);
            this.txt_cedula.TabIndex = 8;
            this.txt_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cedula_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cedula o Pasaporte:";
            // 
            // iN_R_TIPO_PRODUCTOTableAdapter
            // 
            this.iN_R_TIPO_PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(517, 331);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "&Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // frm_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 407);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.gpb_tipoProveedor);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.grb_DatosProveedor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frm_Proveedor";
            this.Text = "Mantenimiento - Proveedor";
            this.Load += new System.EventHandler(this.frm_Proveedor_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNRTIPOPRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAV_INVENTARIO_DataSet)).EndInit();
            this.grb_DatosProveedor.ResumeLayout(false);
            this.grb_DatosProveedor.PerformLayout();
            this.gpb_tipoProveedor.ResumeLayout(false);
            this.gpb_tipoProveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_user;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_fecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grb_DatosProveedor;
        private System.Windows.Forms.TextBox txt_fecha_ingreso;
        private System.Windows.Forms.TextBox txt_responsable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_consultar_Proveedor;
        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.Label lbl_razonSocial;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.ComboBox cbx_tipo_producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ruc;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_RUC;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.GroupBox gpb_tipoProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdb_Contabilidad_NO;
        private System.Windows.Forms.RadioButton rdb_Contabilidad_YES;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label label6;
        private ModuloFacturacion.SAV_INVENTARIO_DataSet sAV_INVENTARIO_DataSet;
        private System.Windows.Forms.BindingSource iNRTIPOPRODUCTOBindingSource;
        private ModuloFacturacion.SAV_INVENTARIO_DataSetTableAdapters.IN_R_TIPO_PRODUCTOTableAdapter iN_R_TIPO_PRODUCTOTableAdapter;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_cdigo;
        private System.Windows.Forms.Button btn_eliminar;
    }
}