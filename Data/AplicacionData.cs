using Entity;
using Mapper;
using System.Configuration;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Dal
{
	public class AplicacionData
	{
		private CategoriaData categoriaData = new CategoriaData();	
		public void GuardarAplicaciones(Aplicacion aplicacion)
		{
			try
			{
				SqlConnection conn = new SqlConnection(Connection.ConnectionString());
				using (conn)
				{
					conn.Open();
					string query = @"INSERT INTO Aplicacion (TITULO, DESCRIPCION, DESARROLLADORA, PRECIO, ID_CATEGORIA) 
									VALUES (@titulo, @descripcion, @desarrolladora, @precio, @idCategoria)";
					SqlCommand cmd = new SqlCommand(query, conn);
					using (cmd)
					{
						cmd.Parameters.AddWithValue("@titulo", aplicacion.Titulo);
						cmd.Parameters.AddWithValue("@descripcion", aplicacion.Descripcion);
						cmd.Parameters.AddWithValue("@desarrolladora", aplicacion.Desarrolladora);
						cmd.Parameters.AddWithValue("@precio", aplicacion.Precio);
						cmd.Parameters.AddWithValue("@idCategoria", aplicacion.Categoria.IdCategoria);
						cmd.ExecuteNonQuery();
					}
					
				}
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		public List<Aplicacion> ObtenerTodasAplicaciones()
		{
			try
			{
				List<Aplicacion> listaAplicaciones = new List<Aplicacion>();
				SqlConnection conn = new SqlConnection(Connection.ConnectionString());
				using (conn)
				{
					conn.Open();
					string query = "SELECT ID, TITULO, DESCRIPCION, DESARROLLADORA, PRECIO, ID_CATEGORIA FROM Aplicacion";
					SqlCommand cmd = new SqlCommand(query, conn);
					using (cmd)
					{
						SqlDataReader reader = cmd.ExecuteReader();
						using (reader)
						{
							while(reader.Read())
							{
								
									int idCategoria = Convert.ToInt32(reader["ID_CATEGORIA"].ToString());
									Categoria categoria = categoriaData.CategoriaPorId(idCategoria);
									Aplicacion aplicacion = AplicacionMapper.Map(reader, categoria);
									listaAplicaciones.Add(aplicacion);
								
							}
						}
					}
				}

					return listaAplicaciones;
			}
			catch (Exception ex)
			{

				throw;
			}
		}
		public Aplicacion ObtenerAppPorId(int id)
		{
			try
			{
				
				SqlConnection conn = new SqlConnection(Connection.ConnectionString());
				using (conn)
				{
					conn.Open();
					string query = "SELECT * FROM Aplicacion WHERE ID = @id";
					SqlCommand cmd = new SqlCommand(query, conn);
					using (cmd)
					{
						cmd.Parameters.AddWithValue("@id", id);
						SqlDataReader reader = cmd.ExecuteReader();
						using (reader)
						{
							while (reader.Read())
							{

								int idCategoria = Convert.ToInt32(reader["ID_CATEGORIA"].ToString());
								Categoria categoria = categoriaData.CategoriaPorId(idCategoria);
								Aplicacion aplicacion = AplicacionMapper.Map(reader, categoria);
								return aplicacion;

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
		public void ModificarAplicacion(Aplicacion aplicacion)
		{
			try
			{
				SqlConnection conn = new SqlConnection(Connection.ConnectionString());
				using (conn)
				{
					conn.Open();
					string query = @"UPDATE Aplicacion SET TITULO = @titulo, DESCRIPCION = @descripcion, DESARROLLADORA = @desarrolladora, 
									PRECIO = @precio WHERE ID = @id";
					SqlCommand cmd = new SqlCommand(query, conn);
					using (cmd)
					{
						cmd.Parameters.AddWithValue("@titulo", aplicacion.Titulo);
						cmd.Parameters.AddWithValue("@descripcion", aplicacion.Descripcion);
						cmd.Parameters.AddWithValue("@desarrolladora", aplicacion.Desarrolladora);
						cmd.Parameters.AddWithValue("@precio", aplicacion.Precio);
						cmd.Parameters.AddWithValue("@id", aplicacion.IdApp);
						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{

				throw;
			}
		}
		public void EliminarAplicacion(int id)
		{
			try
			{
				SqlConnection conn = new SqlConnection(Connection.ConnectionString());
				using (conn)
				{
					conn.Open();
					string query = "DELETE FROM Aplicacion WHERE ID = @id";
					SqlCommand cmd = new SqlCommand(query, conn);
					using (cmd)
					{
						cmd.Parameters.AddWithValue("@id", id);
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
