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
    public class CursoDao
    {
        public List<Curso> ObtenerCursos()
        {
            try
            {
                List<Curso> listaCurso = new List<Curso>();
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT ID_CURSO, NOMBRE_CURSO, PROFESOR, HORARIO FROM CURSO";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (cmd)
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaCurso.Add(CursoMapper.Map(reader));
                            }
                        }
                    }
                }
                return listaCurso;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Curso GetById(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Connection.ConnectionString());
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT ID_CURSO, NOMBRE_CURSO, PROFESOR, HORARIO FROM CURSO WHERE ID_CURSO = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {
                            while (reader.Read())
                            {
                                return CursoMapper.Map(reader);
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
