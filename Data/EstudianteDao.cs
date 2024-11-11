using Entity;
using Mapper;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;

namespace Dal
{
	public class EstudianteDao
	{
		private CursoDao cursoDao = new CursoDao();

		public void GuardarEstudiantes(Estudiante estudiante)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(Connection.ConnectionString()))
				{
					conn.Open();
					string query = "INSERT INTO ESTUDIANTE (NOMBRE, FECHA_NACIMIENTO, PROMEDIO_ACTUAL, ID_CURSO) VALUES (@nombre, @fecha, @promedio, @idCurso)";
					SqlCommand cmd = new SqlCommand(query, conn);
					using (cmd)
					{
						cmd.Parameters.AddWithValue("@nombre", estudiante.Nombre);
						cmd.Parameters.AddWithValue("@fecha",estudiante.FechaNacimiento);
						cmd.Parameters.AddWithValue("@promedio", estudiante.Promedio);
						cmd.Parameters.AddWithValue("@idCurso", estudiante.Curso.IdCurso);
						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		public List<Estudiante> ObtenerEstudiantes()
		{
			try
			{
				List<Estudiante> listaEstudiantes = new List<Estudiante>();
				using (SqlConnection conn = new SqlConnection(Connection.ConnectionString()))
				{
					conn.Open();
					string query = "SELECT ID_ESTUDIANTE, NOMBRE, FECHA_NACIMIENTO, PROMEDIO_ACTUAL, ID_CURSO FROM ESTUDIANTE";
					SqlCommand cmd = new SqlCommand(query, conn);
					using (cmd)
					{
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								int idCurso = Convert.ToInt32(reader["ID_CURSO"].ToString());
								Curso curso = cursoDao.GetById(idCurso);
								Estudiante estudiante = EstudianteMapper.Map(reader, curso);
								listaEstudiantes.Add(estudiante);

							}
						}
					}
				}
				return listaEstudiantes;
			}
			catch (Exception ex)
			{
				throw;
			}
		}

		public Estudiante GetById(int id)
		{
			try
			{

				SqlConnection conn = new SqlConnection(Connection.ConnectionString());
				using (conn)
				{
					conn.Open();
					string query = "SELECT * FROM ESTUDIANTE WHERE ID_ESTUDIANTE = @id";
					SqlCommand cmd = new SqlCommand(query, conn);
					using (cmd)
					{
						cmd.Parameters.AddWithValue("@id", id);
						SqlDataReader reader = cmd.ExecuteReader();
						using (reader)
						{
							while (reader.Read())
							{

								int idCurso = Convert.ToInt32(reader["ID_CURSO"].ToString());
								Curso curso = cursoDao.GetById(idCurso);
								Estudiante estudiante = EstudianteMapper.Map(reader, curso);
								return estudiante;

							}
						}
					}
				}
				return null;

			}
			catch (Exception ex)
			{

				throw;
			}
		}
		public void ModificarEstudiante(Estudiante estudiante)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(Connection.ConnectionString()))
				{
					conn.Open();
					string query = "UPDATE ESTUDIANTE SET NOMBRE = @nombre, PROMEDIO_ACTUAL = @promedio, ID_CURSO = @idCurso WHERE ID_ESTUDIANTE = @idEstudiante";
					SqlCommand cmd = new SqlCommand(query, conn);
					using (cmd)
					{
						cmd.Parameters.AddWithValue("@nombre", estudiante.Nombre);
						cmd.Parameters.AddWithValue("@promedio", estudiante.Promedio);
						cmd.Parameters.AddWithValue("@idCurso", estudiante.Curso.IdCurso);
						cmd.Parameters.AddWithValue("@idEstudiante", estudiante.IdEstudiante);
						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		public void EliminarEstudiante(int id)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(Connection.ConnectionString()))
				{
					conn.Open();
					string query = "DELETE FROM ESTUDIANTE WHERE ID_ESTUDIANTE = @idEstudiante";
					SqlCommand cmd = new SqlCommand(query, conn);
					using (cmd)
					{
						cmd.Parameters.AddWithValue("@idEstudiante", id);
						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{

				throw;
			}
		}
		
		
	}
}
