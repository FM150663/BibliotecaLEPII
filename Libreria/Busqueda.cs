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
        public Busqueda(string ID)
        {
            InitializeComponent();

            if (ID != null)
            {
                ingresoDatos(ID);
            }
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
        public void ingresoDatos(String ID)
        {
            int id = Int32.Parse(ID);
            using (contexto db = new contexto())
            {
                DataTable tabla = new DataTable();
                var lista = (from l in db.LIBROes
                             join a in db.AUTORs on l.idAutor equals a.idAutor
                             join e in db.EDITORIALs on l.idEditorial equals e.idEditorial
                             join u in db.UBICACIONs on l.idLibro equals u.idLibro
                             where
                             l.idLibro == id
                             select new
                             {
                                 Titulo = l.titulo,
                                 ISBN = l.isbn,
                                 Publicacion = l.publicacion,
                                 IdAutor = a.idAutor,
                                 Autor = a.nombreAutor,
                                 IdEditorial = e.idEditorial,
                                 Editorial = e.descEditorial,
                                 Existencias = l.existencias,
                                 IdUbicacion = u.idUbicacion,
                                 Pasillo = u.pasillo,
                                 Estante = u.estante,
                                 ID = l.idLibro
                             }).ToList();
                if (lista.Count > 0)
                {
                    var a = lista.First();
                    lblTitulo.Text = a.Titulo;
                    lblIsbn.Text = a.ISBN;
                    lblAnioPublicacion.Text = a.Publicacion + "";
                    lblExistencias.Text = a.Existencias + "";
                    lblPasillo.Text = a.Pasillo;
                    lblEstante.Text = a.Estante;
                    lblEditorial.Text = a.Editorial;
                }

            }
        }
    }
}
