namespace Sistema_compras.Formularios
{
    partial class frm_Solicitud_Pedido
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_fechapedido = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_tipo_articulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clm_Asignacion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clm_Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clm_Codigo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_descripcion_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_cantidad_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_precio_unitario_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_lbl_user,
            this.tss_lbl_fecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(742, 22);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_fechapedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lbl_estado);
            this.groupBox1.Controls.Add(this.lbl_numero);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbl_tipo_articulo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del pedido";
            // 
            // dtp_fechapedido
            // 
            this.dtp_fechapedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechapedido.Location = new System.Drawing.Point(438, 25);
            this.dtp_fechapedido.Name = "dtp_fechapedido";
            this.dtp_fechapedido.Size = new System.Drawing.Size(122, 20);
            this.dtp_fechapedido.TabIndex = 16;
            this.dtp_fechapedido.Value = new System.DateTime(2014, 7, 14, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha de Pedido:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(144, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(23, 107);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 13;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(23, 28);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(47, 13);
            this.lbl_numero.TabIndex = 9;
            this.lbl_numero.Text = "Numero:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lbl_tipo_articulo
            // 
            this.lbl_tipo_articulo.AutoSize = true;
            this.lbl_tipo_articulo.Location = new System.Drawing.Point(23, 64);
            this.lbl_tipo_articulo.Name = "lbl_tipo_articulo";
            this.lbl_tipo_articulo.Size = new System.Drawing.Size(92, 13);
            this.lbl_tipo_articulo.TabIndex = 11;
            this.lbl_tipo_articulo.Text = "Tipo de Producto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Asignacion,
            this.clm_Eliminar,
            this.clm_Codigo_producto,
            this.clm_descripcion_producto,
            this.clm_cantidad_producto,
            this.clm_precio_unitario_producto});
            this.dataGridView1.Location = new System.Drawing.Point(27, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 94);
            this.dataGridView1.TabIndex = 3;
            // 
            // clm_Asignacion
            // 
            this.clm_Asignacion.HeaderText = "Añadir";
            this.clm_Asignacion.Name = "clm_Asignacion";
            // 
            // clm_Eliminar
            // 
            this.clm_Eliminar.HeaderText = "Eliminar";
            this.clm_Eliminar.Name = "clm_Eliminar";
            // 
            // clm_Codigo_producto
            // 
            this.clm_Codigo_producto.HeaderText = "Codigo";
            this.clm_Codigo_producto.Name = "clm_Codigo_producto";
            // 
            // clm_descripcion_producto
            // 
            this.clm_descripcion_producto.HeaderText = "Descripcion";
            this.clm_descripcion_producto.Name = "clm_descripcion_producto";
            // 
            // clm_cantidad_producto
            // 
            this.clm_cantidad_producto.HeaderText = "Cantidad";
            this.clm_cantidad_producto.Name = "clm_cantidad_producto";
            // 
            // clm_precio_unitario_producto
            // 
            this.clm_precio_unitario_producto.HeaderText = "Precio Unitario";
            this.clm_precio_unitario_producto.Name = "clm_precio_unitario_producto";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(411, 314);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "&Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(306, 314);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(199, 314);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 6;
            this.btn_Nuevo.Text = "&Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // frm_Solicitud_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 383);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frm_Solicitud_Pedido";
            this.Text = "Solicitud de Pedido";
            this.Load += new System.EventHandler(this.frm_Solicitud_Pedido_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_user;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_fecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_tipo_articulo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtp_fechapedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn clm_Asignacion;
        private System.Windows.Forms.DataGridViewButtonColumn clm_Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Codigo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_descripcion_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_cantidad_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_precio_unitario_producto;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Nuevo;

    }
}