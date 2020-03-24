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
    public partial class Busqueda : Form
    {
        Graphics area;
        public Busqueda()
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

        private void mapa_Click(object sender, EventArgs e)
        {
            area = mapa.CreateGraphics();

            Pen lapicero = new Pen(Color.Black);
            lapicero = new Pen(Color.Black);

            //area.DrawLine(lapicero,inicioX,puntoinicio + (espacio*i),finX,puntoinicio + (espacio * i));
            //area.DrawLine(lapicero, inicioX + (espacio * i), inicioY + (espacio * i), finX + (espacio * i), finY + (espacio * i));
            area.DrawLine(lapicero, 730, 325, 730, 75);
            area.DrawLine(lapicero, 425, 325, 425, 350);
            area.DrawLine(lapicero, 425, 325, 730, 325);
            //area.DrawEllipse(lapicero, 325, 750, 10, 10);
        }
    }
}
