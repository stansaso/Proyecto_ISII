using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

using MetroFramework.Forms;
using System.Data;
using MetroFramework;

namespace Proyecto
{
    public partial class Login : MetroForm
    {
        int intentos = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (text_usuario.Text == "Admi" && double.Parse(text_contraseña.Text) == 1234)
            {
                MetroMessageBox.Show(this, "BIENVENIDO   AL  SISTEMA :)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                this.Hide();
                ADMINISTRACION frm = new ADMINISTRACION();
                frm.Show();
            }
            else
            {
                intentos--;
               
                MetroMessageBox.Show(this, "Clave/Usuario, Erroneo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (intentos == 0)
                {
                   
                    MetroMessageBox.Show(this, "SUPERASTE LA CANTIDAD DE INTENTOS, chao", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();

                }
            }
        }


    }
}
