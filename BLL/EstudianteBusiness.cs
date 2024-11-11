using Dal;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class EstudianteBusiness
    {
        private EstudianteDao estudianteDao = new EstudianteDao();
        private CursoDao cursoDao = new CursoDao();
        public void GuardarEstudiantes(Estudiante estudiante)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    int edad = DateTime.Now.Year - estudiante.FechaNacimiento.Year;
                    if (DateTime.Now < estudiante.FechaNacimiento.AddYears(edad))
                    {
                        edad--;
                    }

                    if (edad < 16 || edad > 60)
                    {
                        throw new Exception("El estudiante debe tener entre 16 y 60 años.");
                    }
                    if (estudiante.Nombre.Length < 3 || string.IsNullOrEmpty(estudiante.Nombre))
                    {
                        throw new Exception("El nombre debe tener 3 letras minimo");
                    }
                    if (estudiante.Promedio != 0)
                    {
                        throw new Exception("El promedio debe ser cero");
                    }
                    if (estudiante.Curso == null)
                    {
                        throw new Exception("Seleccione un curso");
                    }
                    estudianteDao.GuardarEstudiantes(estudiante);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void GuardarEstudiante(List<Estudiante> estudiante)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    foreach(Estudiante estudiantes in estudiante)
                    {
                        int edad = DateTime.Now.Year - estudiantes.FechaNacimiento.Year;
                        if (DateTime.Now.DayOfYear < estudiantes.FechaNacimiento.DayOfYear)
                        {
                            edad--;
                        }

                        if (edad <= 16 || edad >= 60)
                        {
                            throw new Exception("El estudiante debe tener entre 16 y 60 años.");
                        }
                        if (estudiantes.Nombre.Length < 3 || string.IsNullOrEmpty(estudiantes.Nombre))
                        {
                            throw new Exception("El nombre debe tener 3 letras minimo");
                        }
                        if (estudiantes.Promedio != 0)
                        {
                            throw new Exception("El promedio no debe ser cero");
                        }
                        if(estudiantes.Curso.IdCurso == null)
                        {
                            throw new Exception("Seleccione un curso");
                        }
                        GuardarEstudiantes(estudiantes);
                    }
                    trx.Complete();
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
                return estudianteDao.ObtenerEstudiantes();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void ModificarEstudiante(int id, string nombre, decimal promedio, Curso curso)
        {
            try
            {
                Estudiante estudiante = estudianteDao.GetById(id);
                Curso validarCurso = cursoDao.GetById(curso.IdCurso);
                using (TransactionScope trx = new TransactionScope())
                { 
                    
                    if(estudiante == null)
                    {
                        throw new Exception("Alumno no existe");
                    }
                    if(validarCurso == null)
                    {
                        throw new Exception("El curso seleccionado no existe");
                    }
                    if (nombre.Length < 3)
                    {
                        throw new Exception("El nombre debe tener 3 letras minimo");
                    }
                    if (promedio == 0)
                    {
                        throw new Exception("El promedio no puede ser cero");
                    }
                    estudiante.Curso = new Curso();
                    estudiante.Nombre = nombre;
                    estudiante.Promedio = promedio;
                    estudiante.Curso.IdCurso = curso.IdCurso;
                    estudianteDao.ModificarEstudiante(estudiante);
                    trx.Complete();
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
                Estudiante estudiante = estudianteDao.GetById(id);
                using (TransactionScope trx = new TransactionScope())
                {
                    
                    if (estudiante == null)
                    {
                        throw new Exception("Alumno no existe");
                    }
                    
                    estudianteDao.EliminarEstudiante(id);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
