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
        validation valid = new validation();//Clase validacion
        //En caso de modificacion estos valores cambiaran
        int IdLibro = 0;
        int IdUbicacion = 0;

        public struct cboItem{
            public string Text { get; set; }
            public string Value { get; set; }

        }

        public LibrosF(string ID)
        {

            InitializeComponent();
            cargarTablas(0,0);

            llenarCBO();
            if (ID != null)
            {
                modoModificar(ID);
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

        private void cargarTablas(int idEditorial,int IdAutor)
        {
            using (contexto db = new contexto())
            {
                //Llenando editoriales
                List<EDITORIAL> lista = (from x in db.EDITORIALs
                                         select x).ToList();
                if (lista.Count > 0)
                {
                    int i = 0;
                    cboEditorial.DataSource = null;
                    cboEditorial.Items.Clear();
                    cboEditorial.DisplayMember = "Text";
                    cboEditorial.ValueMember = "Value";
                    bool bandera = true;
                    foreach (var item in lista)
                    {
                        i = 0;
                        cboEditorial.Items.Add(new cboItem { Text = item.descEditorial, Value = item.idEditorial+"" });
                        if(idEditorial == item.idEditorial)
                        {
                            cboEditorial.SelectedIndex = i;
                            bandera = true;
                        }
                        i++;
                    }
                    if (bandera)
                    {
                        cboEditorial.SelectedIndex = 0;
                    }

                }
                //Llenando Autores
                List<AUTOR> listaAutor = (from x in db.AUTORs
                                         select x).ToList();
                if (listaAutor.Count > 0)
                {
                    int j = 0;
                    cboAutor.DataSource = null;
                    cboAutor.Items.Clear();

                    cboAutor.DisplayMember = "Text";
                    cboAutor.ValueMember = "Value";
                    bool bandera = true;
                    foreach (var item in listaAutor)
                    { 
                        j = 0;
                        cboAutor.Items.Add(new cboItem { Text = item.nombreAutor, Value = item.idAutor+"" });
                        if (IdAutor == item.idAutor)
                        {
                            cboAutor.SelectedIndex = j;
                            bandera = false;
                        }
                        j++;
                    }
                    if (bandera == true)
                    {
                        cboAutor.SelectedIndex = 0;
                    }

                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAnioPublicacion.Text) ||
                    string.IsNullOrEmpty(txtISBN.Text) ||
                    string.IsNullOrEmpty(txtTitulo.Text) ||
                    nupExistencias.Value <1 )
                {
                    MessageBox.Show("No se pueden dejar campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    bool bandera=true;
                    if (!validation.validarAnio(txtAnioPublicacion.Text))
                    {
                        MessageBox.Show("Formato de año no valido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bandera = false;
                    }
                    if (bandera)
                    {
                        using (contexto db = new contexto())
                        {
                            bool bandera1 = false;
                            if (btnAgregar.Text == "Modificar")
                            {
                                bandera1 = true;

                            }
                            LIBRO newlibro = new LIBRO();

                            if (bandera1)
                            {
                                 newlibro = db.LIBROes.Find(IdLibro);

                            }

                            newlibro.isbn = txtISBN.Text;
                            newlibro.titulo = txtTitulo.Text;
                            newlibro.publicacion = int.Parse( txtAnioPublicacion.Text);
                            newlibro.existencias = Decimal.ToInt32(nupExistencias.Value);
                            newlibro.idAutor = Int32.Parse( ((cboItem)cboAutor.SelectedItem).Value);
                            newlibro.idEditorial = Int32.Parse(((cboItem)cboEditorial.SelectedItem).Value);
                            if (bandera1)
                            {

                                db.Entry(newlibro).State = System.Data.Entity.EntityState.Modified;
                                int i = db.SaveChanges();

                                if (i > 0)
                                {
                                   UBICACION newUbicacion = db.UBICACIONs.Find(IdUbicacion);
                                    newUbicacion.idLibro = newlibro.idLibro;
                                    newUbicacion.pasillo = ((cboItem)cboPasillo.SelectedItem).Value;
                                    newUbicacion.estante = ((cboItem)cboEstante.SelectedItem).Value;
                                    db.Entry(newlibro).State = System.Data.Entity.EntityState.Modified;
                                    i = db.SaveChanges();
                                }
                                if (i > 0)
                                    MessageBox.Show("Libro modificado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {


                                db.LIBROes.Add(newlibro);
                                int i = db.SaveChanges();
                                if (i > 0)
                                {
                                    UBICACION newUbicacion = new UBICACION();
                                    newUbicacion.idLibro = newlibro.idLibro;
                                    newUbicacion.pasillo = ((cboItem)cboPasillo.SelectedItem).Value;
                                    newUbicacion.estante = ((cboItem)cboEstante.SelectedItem).Value;
                                    db.UBICACIONs.Add(newUbicacion);
                                    i = db.SaveChanges();
                                }
                                if (i > 0)
                                    MessageBox.Show("Libro ingresado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            VerLibrosF n = new VerLibrosF();
                            n.Show();
                            this.Hide();
                        }
                    }

                }

            } catch (Exception)
            {
                MessageBox.Show("ERROR// Error de validacion del sistema, revise su formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.soloNumeros(e);

        }

        private void txtAnioPublicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.soloNumeros(e);
        }

        private void txtEstante_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.letrasNumeros(e);
        }

        private void txtPasillo_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.letrasNumeros(e);
        }

        private void nupExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.soloNumeros(e);

        }

        private void btnVerRegistros_Click(object sender, EventArgs e)
        {
            VerLibrosF n = new VerLibrosF();
            n.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPasillo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            valid.letrasNumeros(e);

        }

        private void txtEstante_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            valid.letrasNumeros(e);

        }
        public void llenarCBO()
        {
            List<string> Pasillos = new List<string>();
            Pasillos.Add("P1");
            Pasillos.Add("P2");
            Pasillos.Add("P3");
            Pasillos.Add("P4");
            Pasillos.Add("P5");
            cboPasillo.DisplayMember = "Text";
            cboPasillo.ValueMember = "Value";
            foreach (var pasillo in Pasillos)
            {
                cboPasillo.Items.Add(new cboItem { Text = pasillo, Value = pasillo });

            }
            cboPasillo.SelectedIndex = 0;

            List<string> Estantes = new List<string>();
            Estantes.Add("E1");
            Estantes.Add("E2");
            Estantes.Add("E3");
            Estantes.Add("E4");
            Estantes.Add("E5");
            Estantes.Add("E6");
            Estantes.Add("E7");
            Estantes.Add("E8");
            Estantes.Add("E9");
            Estantes.Add("E10");
            Estantes.Add("E11");
            Estantes.Add("E12");
            Estantes.Add("E13");
            Estantes.Add("E14");
            Estantes.Add("E15");
            Estantes.Add("E16");
            Estantes.Add("E17");
            Estantes.Add("E18");
            Estantes.Add("E19");
            Estantes.Add("E20");
            Estantes.Add("E21");
            Estantes.Add("E22");
            Estantes.Add("E23");
            Estantes.Add("E24");
            cboEstante.DisplayMember = "Text";
            cboEstante.ValueMember = "Value";
            foreach (var estante in Estantes)
            {
                cboEstante.Items.Add(new cboItem { Text = estante, Value = estante });

            }
            cboEstante.SelectedIndex = 0;

        }
        public void modoModificar(String ID)
        {
            btnAgregar.Text = "Modificar";
            int id =Int32.Parse(ID);
            using (contexto db = new contexto())
            {
                DataTable tabla = new DataTable();
                var lista = (from l in db.LIBROes
                             join a in db.AUTORs on l.idAutor equals a.idAutor
                             join e in db.EDITORIALs on l.idEditorial equals e.idEditorial
                             join u in db.UBICACIONs on l.idLibro equals u.idLibro
                             where
                             l.idLibro==id
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
                                 IdUbicacion =u.idUbicacion,
                                 Pasillo = u.pasillo,
                                 Estante = u.estante,
                                 ID = l.idLibro
                             }).ToList();
                if (lista.Count > 0)
                {
                    var a = lista.First();
                    IdLibro = a.ID;
                    IdUbicacion = a.IdUbicacion;
                    txtTitulo.Text = a.Titulo;
                    txtISBN.Text = a.ISBN;
                    txtAnioPublicacion.Text =  a.Publicacion + "";
                    nupExistencias.Value = a.Existencias;
                    cboPasillo.SelectedItem= new cboItem { Text = a.Pasillo, Value = a.Pasillo };
                    cboEstante.SelectedItem = new cboItem { Text = a.Estante, Value = a.Estante };
                    cargarTablas(a.IdEditorial, a.IdAutor);

                }

            }
        }
    }
}
