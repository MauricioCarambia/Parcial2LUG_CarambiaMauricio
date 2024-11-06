using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class CategoriaMapper
    {
        public static Categoria Map(SqlDataReader reader)
        {
            Categoria categoria = new Categoria();
            categoria.IdCategoria = reader.GetInt32(0);
            categoria.Descripcion = reader.GetString(1);
            return categoria;
        }
    }
}
