using BLL;
using Entity;
using System.Drawing.Text;

namespace UI
{
    public partial class Form1 : Form
    {
        private EstudianteBusiness estudiantesBusiness = new EstudianteBusiness();
        private CursoBusiness cursoBusiness = new CursoBusiness();
        private Estudiante estudiantes;
        private List<Estudiante> listaEstudiante = new List<Estudiante>();
        public Form1()
        {
            InitializeComponent();

        }
        private void ObtenerCursos()
        {
            try
            {
                List<Curso> listaCursos = cursoBusiness.ObtenerCursos();

                cmbCurso.DataSource = listaCursos;
                cmbCurso.ValueMember = "IdCurso";
                cmbCurso.DisplayMember = "NombreCurso";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void ObtenerCursosModificar()
        {
            try
            {
                List<Curso> listaCursos = cursoBusiness.ObtenerCursos();

                cmbNuevoCurso.DataSource = listaCursos;
                cmbNuevoCurso.ValueMember = "IdCurso";
                cmbNuevoCurso.DisplayMember = "NombreCurso";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void MostrarEstudiantes()
        {
            try
            {
                List<Estudiante> listaEstudiantes = estudiantesBusiness.ObtenerEstudiantes();

                dgvEstudiantes.DataSource = null;
                dgvEstudiantes.DataSource = listaEstudiantes;
                dgvEstudiantes.Columns["Curso"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          

        }
        private void MostrarCursos()
        {
            try
            {
                List<Curso> listaCursos = cursoBusiness.ObtenerCursos();
                dgvCursos.DataSource = null;
                dgvCursos.DataSource = listaCursos;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ObtenerCursos();
            MostrarCursos();
            MostrarEstudiantes();
            ObtenerCursosModificar();
            txtPromedio.Text = "0";
        }
        private void btnBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerDatos();
                listaEstudiante.Add(estudiantes);
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ObtenerDatos()
        {
            try
            {
                estudiantes = new Estudiante();
                estudiantes.Nombre = txtNombre.Text;
                estudiantes.FechaNacimiento = dtpFecha.Value.Date;
                estudiantes.Promedio = Convert.ToDecimal(txtPromedio.Text);
                Curso curso = new Curso();
                curso.IdCurso = Convert.ToInt32(cmbCurso.SelectedValue);
                estudiantes.Curso = curso;
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
                estudiantesBusiness.GuardarEstudiante(listaEstudiante);
                listaEstudiante = new List<Estudiante>();
                MostrarEstudiantes();
                MessageBox.Show("Alumno agregado");
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
                estudiantes = new Estudiante();
                estudiantes.IdEstudiante = Convert.ToInt32(txtID.Text);
                estudiantes.Nombre = txtNuevoNombre.Text;
                estudiantes.Promedio = Convert.ToDecimal(txtNuevoPromedio.Text);
                Curso curso = new Curso();
                curso.IdCurso = Convert.ToInt32(cmbNuevoCurso.SelectedValue);
                estudiantes.Curso = curso;
                estudiantesBusiness.ModificarEstudiante(estudiantes);
                MostrarEstudiantes();
                MessageBox.Show("Estudiante modificado");
                
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
                estudiantesBusiness.EliminarEstudiante(id);
                MostrarEstudiantes();
                MessageBox.Show("Estudiante eliminado");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtPromedio.Text = "0";
            dtpFecha.Value = DateTime.Now;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerDatos();
                estudiantesBusiness.GuardarEstudiantes(estudiantes);
                MostrarEstudiantes();
                MessageBox.Show("Estudiante agregado");
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEstudiantes_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvEstudiantes.SelectedRows.Count > 0)
                {
                    Estudiante seleccionado = (Estudiante)dgvEstudiantes.SelectedRows[0].DataBoundItem;
                    if (seleccionado != null)
                    {
                        txtID.Text = seleccionado.IdEstudiante.ToString();
                        txtNuevoNombre.Text = seleccionado.Nombre.ToString();
                        txtNuevoPromedio.Text = seleccionado.Promedio.ToString();
                        cmbNuevoCurso.SelectedValue = seleccionado.Curso.IdCurso;
                        txtEliminarID.Text = seleccionado.IdEstudiante.ToString();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

      
    }
}
