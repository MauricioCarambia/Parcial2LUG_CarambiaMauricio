using BLL;
using Entity;
using System.Drawing.Text;

namespace UI
{
    public partial class Form1 : Form
    {
        //private AplicacionBusiness aplicacionBusiness = new AplicacionBusiness();
        //private CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
        //private Aplicacion aplicacion;
        //private List<Aplicacion> listaAplicacion = new List<Aplicacion>();
        public Form1()
        {
            InitializeComponent();

        }
        private void ObtenerCategoria()
        {
            

        }

        private void MostrarAplicaciones()
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void btnBorrador_Click(object sender, EventArgs e)
        {
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvAplicaciones_SelectionChanged(object sender, EventArgs e)
        {
            
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
