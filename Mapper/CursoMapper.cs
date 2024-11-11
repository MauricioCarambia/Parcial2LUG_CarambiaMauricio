using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class CursoMapper
    {
       public static Curso Map(SqlDataReader reader)
        {
            Curso curso = new Curso();
            curso.IdCurso = reader.GetInt32(0);
            curso.NombreCurso = reader.GetString(1);
            curso.Profesor = reader.GetString(2);
            curso.Horario = reader.GetString(3);
            return curso;
        }
    }
}
