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
    public partial class VerLibrosF : Form
    {
        public VerLibrosF()
        {
            InitializeComponent();
        }

        private void VerLibrosF_Load(object sender, EventArgs e)
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
