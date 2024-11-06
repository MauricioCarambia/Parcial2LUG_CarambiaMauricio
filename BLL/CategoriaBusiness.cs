using Dal;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaBusiness
    {
        private CategoriaData categoriaData = new CategoriaData();

        public List<Categoria> ObtenerCategoria()
        {
            try
            {
                return categoriaData.ObtenerCategoria();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
