using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CategoriaData
    {
        public List<Categoria> ObtenerCategoria()
        {
            try
            {
                List<Categoria> listaCategoria = new List<Categoria>();
                SqlConnection conn = new SqlConnection(Connection.ConnectionString());
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT * FROM Categoria";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (cmd)
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {
                            while (reader.Read())
                            {
                                listaCategoria.Add(CategoriaMapper.Map(reader));
                            }
                        }
                    }
                }
                return listaCategoria;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Categoria CategoriaPorId(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Connection.ConnectionString());
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT ID_CATEGORIA, DESCRIPCION FROM Categoria WHERE ID_CATEGORIA = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {
                            while(reader.Read())
                            {
                                return CategoriaMapper.Map(reader);
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
    }
}
