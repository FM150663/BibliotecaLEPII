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
    public partial class MantenimeintoF : Form
    {
        public string usu;
        private string textoNacionalidad;
        private int idNacionalidad=0;
        private string textoEditorial;
        private int idEditorial=0;
        private string textoAutor;
        private int idAutor=0;

        public MantenimeintoF()
        {
            InitializeComponent();
        }

        private void MantenimeintoF_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            cargarEnTabla();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MenuF n = new MenuF();
            n.usu = this.usu;
            n.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(btnAgregarNacionalidad.Text == "Agregar")
            {
                using (Contexto db = new Contexto())
                {
                    NACIONALIDAD nuevaNacionalidad = new NACIONALIDAD();
                    nuevaNacionalidad.decNacionalidad = txtNacionalidad.Text;

                    db.NACIONALIDADs.Add(nuevaNacionalidad);
                    db.SaveChanges();                    
                    cargarEnTabla();
                }
            }
            else
            {
                if (idNacionalidad != 0)
                {
                    using (Contexto db = new Contexto())
                    {
                        NACIONALIDAD nacionalidadMod = db.NACIONALIDADs.Find(idNacionalidad);
                        nacionalidadMod.decNacionalidad = txtNacionalidad.Text;

                        db.Entry(nacionalidadMod).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        cargarEnTabla();
                    }
                }                
            }            
        }

        private void btnAgregarEditorial_Click(object sender, EventArgs e)
        {
            if (btnAgregarEditorial.Text == "Agregar")
            {
                using (Contexto db = new Contexto())
                {
                    EDITORIAL nuevaEditorial = new EDITORIAL();
                    nuevaEditorial.descEditorial = txtEditorial.Text;

                    db.EDITORIALs.Add(nuevaEditorial);
                    db.SaveChanges();
                    cargarTablaEditoriales();
                }
            }
            else
            {
                if (idEditorial != 0)
                {
                    using (Contexto db = new Contexto())
                    {
                        EDITORIAL editorialMod = db.EDITORIALs.Find(idEditorial);
                        editorialMod.descEditorial = txtEditorial.Text;

                        db.Entry(editorialMod).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        cargarTablaEditoriales();
                    }
                }
            }
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            if (btnAgregarAutor.Text == "Agregar")
            {
                using (Contexto db = new Contexto())
                {
                    AUTOR nuevoAutor = new AUTOR();
                    nuevoAutor.nombreAutor = txtAutor.Text;
                    nuevoAutor.idNacionalidad = (int)cmbNacionalidad.SelectedValue;

                    db.AUTORs.Add(nuevoAutor);
                    db.SaveChanges();
                    cargarTablaAutores();
                }
            }
            else
            {
                if (idAutor != 0)
                {
                    using (Contexto db = new Contexto())
                    {
                        AUTOR autorMod = db.AUTORs.Find(idAutor);
                        autorMod.nombreAutor = txtAutor.Text;
                        autorMod.idNacionalidad = (int)cmbNacionalidad.SelectedValue;

                        db.Entry(autorMod).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        cargarTablaAutores();
                    }
                }
            }
        }
        private void cargarEnTabla()
        {
            using(Contexto db = new Contexto())
            {
                DataTable tabla = new DataTable();
                List<NACIONALIDAD> lista = (from x in db.NACIONALIDADs
                                            select x).ToList();
                if (lista.Count > 0)
                {
                    tabla = db.ConvertToDataTable(lista);
                    dataGridView3.DataSource = tabla;
                    dataGridView3.Columns[0].Visible = false;
                    dataGridView3.Columns[1].Visible = false;
                    dataGridView3.Columns[3].Visible = false;                    
                }
                txtNacionalidad.Text = "_____________________________";
                btnAgregarNacionalidad.Text = "Agregar";
                idNacionalidad = 0;
            }
        }

        private void cargarTablaEditoriales()
        {
            using (Contexto db = new Contexto())
            {
                DataTable tabla = new DataTable();
                List<EDITORIAL> lista = (from x in db.EDITORIALs
                                         select x).ToList();
                if (lista.Count > 0)
                {
                    tabla = db.ConvertToDataTable(lista);
                    dataGridView1.DataSource = tabla;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                }
                txtEditorial.Text = "_____________________________";
                btnAgregarEditorial.Text = "Agregar";
                idEditorial = 0;
            }
        }

        private void cargarTablaAutores()
        {
            using (Contexto db = new Contexto())
            {
                DataTable tabla = new DataTable();
                var lista = db.NACIONALIDADs.Join(
                                    db.AUTORs,
                                    NACIONALIDAD => NACIONALIDAD.idNacionalidad,
                                    AUTOR => AUTOR.NACIONALIDAD.idNacionalidad,
                                    (NACIONALIDAD, AUTOR) => new
                                    {
                                        idAutor = AUTOR.idAutor,
                                        nombreAutor = AUTOR.nombreAutor,
                                        descnacionalidad = NACIONALIDAD.decNacionalidad,
                                        idNacionalidad = NACIONALIDAD.idNacionalidad
                                    }
                                    ).ToList();
                    
                if (lista.Count > 0)
                {
                    tabla = db.ConvertToDataTable(lista);
                    dataGridView2.DataSource = tabla;
                    dataGridView2.Columns[0].Visible = false;
                    dataGridView2.Columns[1].Visible = false;
                    dataGridView2.Columns[2].Visible = false; //idAutor
                    dataGridView2.Columns[5].Visible = false; //idNacionalidad
                }
                txtAutor.Text = "_____________________________";
                cmbNacionalidad.SelectedIndex = 0;
                btnAgregarAutor.Text = "Agregar";
                idNacionalidad = 0;
                idAutor = 0;
            }
        }

        private void txtNacionalidad_Enter(object sender, EventArgs e)
        {
            txtNacionalidad.Text = "";
        }

        private void txtEditorial_Enter(object sender, EventArgs e)
        {
            txtEditorial.Text = "";
        }

        private void txtAutor_Enter(object sender, EventArgs e)
        {
            txtAutor.Text = "";
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textoNacionalidad = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            idNacionalidad = (int)dataGridView3.Rows[e.RowIndex].Cells[1].Value;
            txtNacionalidad.Text = textoNacionalidad;
            btnAgregarNacionalidad.Text = "Modificar";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textoEditorial = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            idEditorial = (int)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            txtEditorial.Text = textoEditorial;
            btnAgregarEditorial.Text = "Modificar";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textoAutor = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            idNacionalidad = (int)dataGridView2.Rows[e.RowIndex].Cells[5].Value;
            idAutor = (int)dataGridView2.Rows[e.RowIndex].Cells[2].Value;
            txtAutor.Text = textoAutor;
            cmbNacionalidad.SelectedValue = idNacionalidad.ToString();
            btnAgregarAutor.Text = "Modificar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idNacionalidad != 0)
            {
                using (Contexto db = new Contexto())
                {
                    NACIONALIDAD nacionalidadDel = db.NACIONALIDADs.Find(idNacionalidad);

                    db.NACIONALIDADs.Remove(nacionalidadDel);
                    db.SaveChanges();

                    cargarEnTabla();
                }
            }
        }

        private void btnEliminarEditorial_Click(object sender, EventArgs e)
        {
            if (idEditorial != 0)
            {
                using (Contexto db = new Contexto())
                {
                    EDITORIAL editorialDel = db.EDITORIALs.Find(idEditorial);

                    db.EDITORIALs.Remove(editorialDel);
                    db.SaveChanges();

                    cargarTablaEditoriales();
                }
            }
        }

        private void btnEliminarAutor_Click(object sender, EventArgs e)
        {
            if (idAutor != 0)
            {
                using (Contexto db = new Contexto())
                {
                    AUTOR autorDel = db.AUTORs.Find(idAutor);

                    db.AUTORs.Remove(autorDel);
                    db.SaveChanges();

                    cargarTablaAutores();
                }
            }
        }

        private void btnRecargarNacionalidad_Click(object sender, EventArgs e)
        {
            cargarEnTabla();
        }

        private void btnRecargarEditorial_Click(object sender, EventArgs e)
        {
            cargarTablaEditoriales();
        }

        private void btnRecargarAutor_Click(object sender, EventArgs e)
        {
            cargarTablaAutores();
        }

        private void tabNacionalidad_Enter(object sender, EventArgs e)
        {
            cargarEnTabla();
        }

        private void tabEditorial_Enter(object sender, EventArgs e)
        {
            cargarTablaEditoriales();          
        }

        private void tabAutor_Enter(object sender, EventArgs e)
        {
            using (Contexto db = new Contexto())
            {
                DataTable tabla = new DataTable();
                List<NACIONALIDAD> lista = (from x in db.NACIONALIDADs
                                            select x).ToList();
                if (lista.Count > 0)
                {
                    //cmbNacionalidad.Items.Clear();
                    Dictionary<int, string> comboSource = new Dictionary<int, string>();
                    foreach (NACIONALIDAD n in lista)
                    {
                        comboSource.Add(n.idNacionalidad, n.decNacionalidad);
                    }

                    cmbNacionalidad.DataSource = new BindingSource(comboSource, null);
                    cmbNacionalidad.DisplayMember = "Value";
                    cmbNacionalidad.ValueMember = "Key";                    
                }
            }
            cargarTablaAutores();
        }        
    }
}
