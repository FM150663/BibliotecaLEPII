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
        String Estante;
        int inicio = 0;
        int final = 6;
        Point np1;
        public Busqueda(string ID)
        {
            InitializeComponent();
            area = mapa.CreateGraphics();

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
                    Estante = a.Estante;
                }

            }

        }

        private void btnRuta_Click(object sender, EventArgs e)
        {

            int distancia = 0;
            int m = 0;
            int n = 0;
            int cantidadNodos = 15;
            string dato = "";

            asociarEstanteANodo();
            //Construccion del grafo a partir de sus arcos
            CGrafo grafo = new CGrafo(15);
            grafo.AdicionaArista(0, 1);
            grafo.AdicionaArista(0, 6);
            grafo.AdicionaArista(0, 7);
            grafo.AdicionaArista(0, 11);
            grafo.AdicionaArista(0, 12);

            grafo.AdicionaArista(1, 2);
            grafo.AdicionaArista(2, 3);
            grafo.AdicionaArista(4, 3);

            grafo.AdicionaArista(5, 2);
            grafo.AdicionaArista(5, 4);

            grafo.AdicionaArista(6, 5);
            grafo.AdicionaArista(6, 1);

            grafo.AdicionaArista(7, 8);

            grafo.AdicionaArista(8, 9);
            grafo.AdicionaArista(8, 4);

            grafo.AdicionaArista(9, 14);

            grafo.AdicionaArista(10, 9);
            grafo.AdicionaArista(10, 13);

            grafo.AdicionaArista(11, 12);
            grafo.AdicionaArista(11, 10);
            grafo.AdicionaArista(12, 13);
            grafo.AdicionaArista(13, 14);


            //Tabla
            //0 - visitado
            //1- Distancia
            //2- previo
            int[,] tabla = new int[cantidadNodos, 3];

            //Inicializamos la tabla;
            for (n = 0; n < cantidadNodos; n++)
            {
                tabla[n, 0] = 0;
                tabla[n, 1] = int.MaxValue;
                tabla[n, 2] = 0;
            }
            tabla[inicio, 1] = 0;

            for (distancia = 0; distancia < cantidadNodos; distancia++)
            {
                for (n = 0; n < cantidadNodos; n++)
                {
                    if ((tabla[n, 0] == 0) && (tabla[n, 1] == distancia))
                    {
                        tabla[n, 0] = 1;
                        for (m = 0; m < cantidadNodos; m++)
                        {
                            //Verificacion que el nodo sea adyacente
                            if (grafo.ObtenAdyacencia(n, m) == 1)
                            {
                                if (tabla[m, 1] == int.MaxValue)
                                {
                                    tabla[m, 1] = distancia + 1;
                                    tabla[m, 2] = n;

                                }
                            }
                        }
                    }

                }
            }

            //Obtener Ruta
            List<int> ruta = new List<int>();
            int nodo = final;
            while (nodo != inicio)
            {
                ruta.Add(nodo);
                nodo = tabla[nodo, 2];
            }
            ruta.Add(inicio);
            ruta.Reverse();
            String Ruta = "";
            foreach (int posicion in ruta)
               Ruta = Ruta + posicion + "-";

            string[] arrayRuta = Ruta.Split('-');
            dibujarRuta(arrayRuta);

            MessageBox.Show(Ruta);

        }

        public void dibujarRuta(string[] ruta)
        {
            np1 = Point.Subtract(lblP0.Location, (Size)mapa.Location);
            float x = np1.X;
            float y = np1.Y;
            Pen pen;
            PointF point1;
            PointF point2;

            for (int i= 0;i< ruta.Length-1; i++)
            {
                // Create pen.
                pen = new Pen(Color.Red, 3);

                // Create points that define line.
                point1 = new PointF(x, y);
                getCoordenadas(ref x,ref y, ruta[i + 1]);
                point2 = new PointF(x,y);

                // Draw line to screen.
                area.DrawLine(pen, point1, point2);
            }

            // Create pen.
            pen = new Pen(Color.Red, 3);

            // Create points that define line.
            point1 = new PointF(x, y);
            getEstante(ref x, ref y, lblEstante.Text.Replace("E",""));
            point2 = new PointF(x, y);

            // Draw line to screen.
            area.DrawLine(pen, point1, point2);
        }

        public void getCoordenadas(ref float x, ref float y, string valor)
        {
            switch (valor)
            {
                case "1":
                    np1 = Point.Subtract(lblP1.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "2":
                    np1 = Point.Subtract(lblP2.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;                    
                    break;
                case "3":
                    np1 = Point.Subtract(lblP3.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "4":
                    np1 = Point.Subtract(lblP4.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "5":
                    np1 = Point.Subtract(lblP5.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "6":
                    np1 = Point.Subtract(lblP6.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "7":
                    np1 = Point.Subtract(lblP7.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "8":
                    np1 = Point.Subtract(lblP8.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "9":
                    np1 = Point.Subtract(lblP9.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "10":
                    np1 = Point.Subtract(lblP10.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "11":
                    np1 = Point.Subtract(lblP11.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "12":
                    np1 = Point.Subtract(lblP12.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "13":
                    np1 = Point.Subtract(lblP13.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "14":
                    np1 = Point.Subtract(lblP14.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
            }
        }


        public void getEstante(ref float x, ref float y, string valor)
        {
            switch (valor)
            {
                case "1":
                    np1 = Point.Subtract(E1.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "2":
                    np1 = Point.Subtract(E2.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "3":
                    np1 = Point.Subtract(E3.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "4":
                    np1 = Point.Subtract(E4.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "5":
                    np1 = Point.Subtract(E5.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "6":
                    np1 = Point.Subtract(E6.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "7":
                    np1 = Point.Subtract(E7.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "8":
                    np1 = Point.Subtract(E8.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "9":
                    np1 = Point.Subtract(E9.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "10":
                    np1 = Point.Subtract(E10.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "11":
                    np1 = Point.Subtract(E11.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "12":
                    np1 = Point.Subtract(E12.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "13":
                    np1 = Point.Subtract(E13.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "14":
                    np1 = Point.Subtract(E14.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "15":
                    np1 = Point.Subtract(E15.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "16":
                    np1 = Point.Subtract(E16.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "17":
                    np1 = Point.Subtract(E17.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "18":
                    np1 = Point.Subtract(E18.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "19":
                    np1 = Point.Subtract(E19.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "20":
                    np1 = Point.Subtract(E20.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "21":
                    np1 = Point.Subtract(E21.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "22":
                    np1 = Point.Subtract(E22.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "23":
                    np1 = Point.Subtract(E23.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
                case "24":
                    np1 = Point.Subtract(E24.Location, (Size)mapa.Location);
                    x = np1.X;
                    y = np1.Y;
                    break;
            }
        }
        public void asociarEstanteANodo()
        {
             //Asociando el Estante al grafo final mas cercano :
            if (Estante == "E1" || Estante == "E5")
            {
                final = 1;
            }
            else if (Estante == "E4" || Estante == "E2")
            {
                final = 2;
            }
            else if (Estante == "E3")
            {
                final = 3;
            }
            else if (Estante == "E8")
            {
                final = 4;
            }
            else if (Estante == "E9" || Estante == "E7")
            {
                final = 5;
            }
            else if (Estante == "E10" || Estante == "E6")
            {
                final = 6;
            }
            else if (Estante == "E14" || Estante == "E11")
            {
                final = 7;
            }
            else if (Estante == "E13" || Estante == "E12")
            {
                final = 8;
            }
            else if (Estante == "E17")
            {
                final = 9;
            }
            else if (Estante == "E18" || Estante == "E16")
            {
                final = 10;
            }
            else if (Estante == "E19" || Estante == "E15")
            {
                final = 11;
            }
            else if (Estante == "E20" || Estante == "E24")
            {
                final = 12;
            }
            else if (Estante == "E23" || Estante == "E21")
            {
                final = 13;
            }
            else if (Estante == "E22" )
            {
                final = 14;
            }



        }
    }
}
