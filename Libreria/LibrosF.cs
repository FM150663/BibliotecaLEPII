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
    public partial class LibrosF : Form
    {
        public LibrosF()
        {
            InitializeComponent();
        }

        private void LibrosF_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            MenuF n = new MenuF();
            n.Show();
            this.Hide();
        }


    }
}
