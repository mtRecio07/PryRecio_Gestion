using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PryRecio_Gestion
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        string usuarioCorrecto = ConfigurationManager.AppSettings["Usuario"];
        string contraseñaCorrecta = ConfigurationManager.AppSettings["Contraseña"];

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            if (usuario != usuarioCorrecto)
            {
                MessageBox.Show("Usuario incorrecto", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (contraseña != contraseñaCorrecta)
            {
                MessageBox.Show("Contraseña incorrecta", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;
            }

            // Si usuario y contraseña son correctos
            FrmPrincipal frmMenu = new FrmPrincipal();
            frmMenu.Show();
            this.Hide();
        }
    }
}
