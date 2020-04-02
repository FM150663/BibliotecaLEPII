using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class MenuF : Form
    {
        public string usu;
        public MenuF()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
        }

        private void MenuF_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MantenimeintoF n = new MantenimeintoF();
            n.usu = this.usu;
            n.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LibrosF n = new LibrosF(null);
            n.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            VerLibrosF n = new VerLibrosF();
            n.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Busqueda n = new Busqueda();
            n.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginF n = new LoginF();
            n.Show();
            this.Hide();
        }
    }
}
