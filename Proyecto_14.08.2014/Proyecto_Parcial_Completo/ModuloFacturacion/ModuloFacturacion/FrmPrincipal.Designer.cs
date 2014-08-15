namespace ModuloFacturacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btncom = new System.Windows.Forms.Button();
            this.btninv = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnfact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncom
            // 
            this.btncom.Location = new System.Drawing.Point(27, 12);
            this.btncom.Name = "btncom";
            this.btncom.Size = new System.Drawing.Size(75, 23);
            this.btncom.TabIndex = 0;
            this.btncom.Text = "Compras";
            this.btncom.UseVisualStyleBackColor = true;
            this.btncom.Click += new System.EventHandler(this.btncom_Click);
            // 
            // btninv
            // 
            this.btninv.Location = new System.Drawing.Point(27, 51);
            this.btninv.Name = "btninv";
            this.btninv.Size = new System.Drawing.Size(75, 23);
            this.btninv.TabIndex = 0;
            this.btninv.Text = "Inventario";
            this.btninv.UseVisualStyleBackColor = true;
            this.btninv.Click += new System.EventHandler(this.btninv_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(27, 129);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 0;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnfact
            // 
            this.btnfact.Location = new System.Drawing.Point(27, 91);
            this.btnfact.Name = "btnfact";
            this.btnfact.Size = new System.Drawing.Size(75, 23);
            this.btnfact.TabIndex = 1;
            this.btnfact.Text = "Facturacion";
            this.btnfact.UseVisualStyleBackColor = true;
            this.btnfact.Click += new System.EventHandler(this.btnfact_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(132, 166);
            this.Controls.Add(this.btnfact);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btninv);
            this.Controls.Add(this.btncom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrativo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncom;
        private System.Windows.Forms.Button btninv;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnfact;
    }
}