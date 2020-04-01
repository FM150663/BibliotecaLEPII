using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Libreria
{
    public partial class LoginF : Form
    {
        public LoginF()
        {
            InitializeComponent();

            lblUsuario.BackColor = Color.Transparent;
            lblPassword.BackColor = Color.Transparent;
            //txtUsuario.BackColor = Color.Transparent;
            //txtPassword.BackColor = Color.Transparent;
        }

        private void LoginF_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            picBoxFondo.BackColor = Color.FromArgb(100, 0, 0, 0);
            lblPassword.BackColor = Color.FromArgb(100, 0, 0, 0);
            lblTittle.BackColor = Color.FromArgb(100, 0, 0, 0);
            lblUsuario.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (contexto db = new contexto())
            {
                List<Libreria.VALIDAR_USUARIO_Result> lista = new List<Libreria.VALIDAR_USUARIO_Result>();
                lista = db.VALIDAR_USUARIO(txtUsuario.Text, txtPassword.Text).ToList();
                if (lista.Count > 0)
                {
                    MenuF n = new MenuF();
                    n.usu = txtUsuario.Text;
                    n.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                }
            }
        }


        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnIngresar_Click(sender, e);
            }
        }
    }
}
