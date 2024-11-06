using BLL;
using Entity;
using System.Drawing.Text;

namespace UI
{
    public partial class Form1 : Form
    {
        private AplicacionBusiness aplicacionBusiness = new AplicacionBusiness();
        private CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
        private Aplicacion aplicacion;
        private List<Aplicacion> listaAplicacion = new List<Aplicacion>();
        public Form1()
        {
            InitializeComponent();

        }
        private void ObtenerCategoria()
        {
            List<Categoria> listaCategoria = categoriaBusiness.ObtenerCategoria();

            cmbCategoria.DataSource = listaCategoria;
            cmbCategoria.ValueMember = "IdCategoria";
            cmbCategoria.DisplayMember = "Descripcion";

        }

        private void MostrarAplicaciones()
        {
            dgvAplicaciones.DataSource = null;
            dgvAplicaciones.DataSource = aplicacionBusiness.ObtenerTodasAplicaciones();
            dgvAplicaciones.Columns["Categoria"].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ObtenerCategoria();
            MostrarAplicaciones();
        }
        private void btnBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                aplicacion = new Aplicacion();
                aplicacion.Titulo = txtTitulo.Text;
                aplicacion.Descripcion = txtDescripcion.Text;
                aplicacion.Desarrolladora = txtDesarrolladora.Text;
                aplicacion.Precio = Convert.ToDecimal(txtPrecio.Text);
                Categoria categoria = new Categoria();
                categoria.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                aplicacion.Categoria = categoria;
                listaAplicacion.Add(aplicacion);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                aplicacionBusiness.GuardarAplicacion(listaAplicacion);
                listaAplicacion = new List<Aplicacion>();
                MostrarAplicaciones();
                MessageBox.Show("Aplicacion agregada");
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                string titulo = txtNuevoTitulo.Text;
                string descripcion = txtNuevoDescripcion.Text;
                string desarrolladora = txtNuevoDesarrolladora.Text;
                decimal precio = Convert.ToDecimal(txtNuevoPrecio.Text);
                aplicacionBusiness.ModificarAplicacion(id, titulo, descripcion, desarrolladora, precio);
                MostrarAplicaciones();
                MessageBox.Show("Aplicacion modificada");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtEliminarID.Text);
                aplicacionBusiness.EliminarAplicacion(id);
                MostrarAplicaciones();
                MessageBox.Show("Aplicacion eliminada");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAplicaciones_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvAplicaciones.SelectedRows.Count > 0)
                {
                    Aplicacion seleccionado = (Aplicacion)dgvAplicaciones.SelectedRows[0].DataBoundItem;
                    if (seleccionado != null)
                    {
                        txtID.Text = seleccionado.IdApp.ToString();
                        txtNuevoTitulo.Text = seleccionado.Titulo;
                        txtNuevoDescripcion.Text = seleccionado.Descripcion;
                        txtNuevoDesarrolladora.Text = seleccionado.Desarrolladora;
                        txtNuevoPrecio.Text = seleccionado.Precio.ToString();
                        txtEliminarID.Text = seleccionado.IdApp.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtTitulo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtDesarrolladora.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
