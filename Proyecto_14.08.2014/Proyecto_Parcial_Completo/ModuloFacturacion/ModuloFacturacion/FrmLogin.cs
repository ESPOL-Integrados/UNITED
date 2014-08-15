using ModuloFacturacion.Reglas_del_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms;


namespace ModuloFacturacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            
            if(!string.IsNullOrEmpty(txtUser.Text) || !string.IsNullOrEmpty(txtPasword.Text))
            //if (txtUser.Text != null || txtPasword.Text != null)
            {
                if (txtUser.Text == "adm" & txtPasword.Text == "1234")
                {
                    FrmPrincipal a = new FrmPrincipal();
                    a.ShowDialog();
                    Dispose();

                   
                }
                else
                {
                    if (txtUser.Text == "aedr" & txtPasword.Text == "1234")
                    {
                        FrmFacturacionPrincipal b = new FrmFacturacionPrincipal();
                        b.ShowDialog();
                        Dispose();
                        
                    }
                    else
                    {
                        if (txtUser.Text == "sangargu" & txtPasword.Text == "1234")
                        {
                            frmMDI_Principal c = new frmMDI_Principal();
                            c.ShowDialog();
                            Close();
                           
                        }
                        else
                        {
                            if (txtUser.Text == "dsoledi" & txtPasword.Text == "1234")
                            {
                                frmInv_MenuPrincipal frm = new frmInv_MenuPrincipal();
                                frm.ShowDialog();
                            }
                        }
                    }
                }
            }
            else
                MessageBox.Show("No dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPasword.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
