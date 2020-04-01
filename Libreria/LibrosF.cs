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

        public LibrosF()
        {
            InitializeComponent();
        }

        private void LibrosF_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            cargarTablas();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            MenuF n = new MenuF();
            n.Show();
            this.Hide();
        }

        private void cargarTablas()
        {
            using (contexto db = new contexto())
            {
                //Llenando editoriales
                List<EDITORIAL> lista = (from x in db.EDITORIALs
                                         select x).ToList();
                if (lista.Count > 0)
                {
                    cboEditorial.DataSource = null;

                    cboEditorial.DisplayMember = "descEditorial";
                    cboEditorial.ValueMember = "idEditorial";
                    cboEditorial.DataSource = lista;
                }
                //Llenando Autores
                List<AUTOR> listaAutor = (from x in db.AUTORs
                                         select x).ToList();
                if (listaAutor.Count > 0)
                {
                    cboAutor.DataSource = null;

                    cboAutor.DisplayMember = "nombreAutor";
                    cboAutor.ValueMember = "idAutor";
                    cboAutor.DataSource = listaAutor;
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAnioPublicacion.Text) ||
                    string.IsNullOrEmpty(txtEstante.Text) ||
                    string.IsNullOrEmpty(txtISBN.Text) ||
                    string.IsNullOrEmpty(txtPasillo.Text) ||
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


                            LIBRO newlibro = new LIBRO();
                            newlibro.isbn = txtISBN.Text;
                            newlibro.titulo = txtTitulo.Text;
                            newlibro.publicacion = int.Parse( txtAnioPublicacion.Text);
                            newlibro.existencias = Decimal.ToInt32(nupExistencias.Value);
                            newlibro.idAutor = (int) cboAutor.SelectedValue ;
                            newlibro.idEditorial = (int) cboEditorial.SelectedValue;

                            db.LIBROes.Add(newlibro);
                            int i =db.SaveChanges();
                            if (i > 0)
                            {
                                UBICACION newUbicacion = new UBICACION();
                                newUbicacion.idLibro = newlibro.idLibro;
                                newUbicacion.pasillo = txtPasillo.Text;
                                newUbicacion.estante = txtEstante.Text;
                                db.UBICACIONs.Add(newUbicacion);
                                i = db.SaveChanges();
                            }
                            if(i>0)
                            MessageBox.Show("Libro ingresado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
