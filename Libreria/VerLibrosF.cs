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
            cargarEnTabla();
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
        private void cargarEnTabla()
        {
            using (contexto db = new contexto())
            {
                DataTable tabla = new DataTable();
                var lista = (from l in db.LIBROes
                                     join a in db.AUTORs on l.idAutor equals a.idAutor
                                     join e in db.EDITORIALs on l.idEditorial equals e.idEditorial
                                     join u in db.UBICACIONs on l.idLibro equals u.idLibro
                                     select new {
                                                 Titulo = l.titulo, 
                                                 ISBN = l.isbn,
                                                 Publicación = l.publicacion,
                                                 Autor = a.nombreAutor, 
                                                 Editorial = e.descEditorial ,
                                                 Existencias=l.existencias,
                                                 Pasillo =u.pasillo,
                                                 Estante=u.estante,
                                                 ID = l.idLibro 
                                                    }).ToList();
                if (lista.Count > 0)
                {
                    tabla = Utilidades.ConvertToDataTable(lista);
                    dgvLibros.DataSource = tabla;
                    dgvLibros.Columns[0].Visible = false;
                    dgvLibros.Columns[1].Visible = false;
                    dgvLibros.Columns[2].Visible = false;
                    dgvLibros.Columns[3].Visible = false;
                    dgvLibros.Columns[4].Visible = false;
                    dgvLibros.Columns[5].Visible = false;
                    dgvLibros.Columns[6].Visible = false;
                    dgvLibros.Columns[7].Visible = false;


                }

            }
        }

        private void buscar(String buscar)
        {
            if (!string.IsNullOrEmpty(buscar.Trim()))
            {
                using (contexto db = new contexto())
                {
                    DataTable tabla = new DataTable();
                    var lista = (from l in db.LIBROes
                                 join a in db.AUTORs on l.idAutor equals a.idAutor
                                 join e in db.EDITORIALs on l.idEditorial equals e.idEditorial
                                 join u in db.UBICACIONs on l.idLibro equals u.idLibro
                                 where 
                                 l.titulo.Contains(buscar.Trim()) ||
                                 l.isbn.Contains(buscar.Trim())||
                                 a.nombreAutor.Contains(buscar.Trim())||
                                 u.pasillo.Contains(buscar.Trim())||
                                 e.descEditorial.Contains(buscar.Trim()) ||
                                 u.estante.Contains(buscar.Trim()) 
                                 select new
                                 {
                                     Titulo = l.titulo,
                                     ISBN = l.isbn,
                                     Publicación = l.publicacion,
                                     Autor = a.nombreAutor,
                                     Editorial = e.descEditorial,
                                     Existencias = l.existencias,
                                     Pasillo = u.pasillo,
                                     Estante = u.estante,
                                     ID = l.idLibro
                                 }).ToList();
                    if (lista.Count > 0)
                    {
                        tabla = Utilidades.ConvertToDataTable(lista);
                        dgvLibros.DataSource = tabla;
                        dgvLibros.Columns[0].Visible = false;
                        dgvLibros.Columns[1].Visible = false;
                        dgvLibros.Columns[2].Visible = false;
                        dgvLibros.Columns[3].Visible = false;
                        dgvLibros.Columns[4].Visible = false;
                        dgvLibros.Columns[5].Visible = false;
                        dgvLibros.Columns[6].Visible = false;
                        dgvLibros.Columns[7].Visible = false;


                    }

                }
            }
            else
            {
                cargarEnTabla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            buscar(txtBuscar.Text);
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dgvLibros.Rows[e.RowIndex].Cells[16].Value + "";
            LibrosF n = new LibrosF(id);
            n.Show();
            this.Hide();
        }
    }
}
