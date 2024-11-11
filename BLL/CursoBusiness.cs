using Dal;
using Entity;
using System.Transactions;

namespace BLL
{
    public class CursoBusiness
    {
        private CursoDao cursoData = new CursoDao();
        public List<Curso> ObtenerCursos()
        {
            try
            {
                return cursoData.ObtenerCursos();
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}
