using Entity;
using System.Data.SqlClient;

namespace Mapper
{
    public class EstudianteMapper
    {
        public static Estudiante Map(SqlDataReader reader, Curso curso)
        {
            Estudiante estudiante = new Estudiante
            {
                IdEstudiante = Convert.ToInt32(reader["ID_ESTUDIANTE"].ToString()),
                Nombre = reader["NOMBRE"].ToString(),
                FechaNacimiento = Convert.ToDateTime(reader["FECHA_NACIMIENTO"].ToString()),
                Promedio = Convert.ToDecimal(reader["PROMEDIO_ACTUAL"].ToString()),
                Curso = curso
            };
            return estudiante;
        }
    }
}
