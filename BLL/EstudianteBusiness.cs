﻿using Dal;
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
                    ValidarEstudiante(estudiante);
                    estudianteDao.GuardarEstudiantes(estudiante);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private static void ValidarEstudiante(Estudiante estudiante)
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
            if (string.IsNullOrEmpty(estudiante.Nombre) || estudiante.Nombre.Length < 3)
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
        }

        public void GuardarEstudiante(List<Estudiante> estudiantes)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    foreach(Estudiante estudiante in estudiantes)
                    {
                        ValidarEstudiante(estudiante);
                        GuardarEstudiantes(estudiante);
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

        public void ModificarEstudiante(Estudiante estudiantes)
        {
            try
            {
                Estudiante estudiante = estudianteDao.GetById(estudiantes.IdEstudiante);
                Curso validarCurso = cursoDao.GetById(estudiantes.Curso.IdCurso);
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
                    if (string.IsNullOrEmpty(estudiantes.Nombre) || estudiantes.Nombre.Length < 3)
                    {
                        throw new Exception("El nombre debe tener 3 letras minimo");
                    }
                    if (estudiantes.Promedio == 0)
                    {
                        throw new Exception("El promedio no puede ser cero");
                    }
                    
                    estudianteDao.ModificarEstudiante(estudiantes);
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
