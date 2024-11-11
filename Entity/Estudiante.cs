using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public decimal Promedio { get; set; }
        public string Cursos { get => Curso.NombreCurso; }
        public Curso Curso { get; set; }
    }
}
