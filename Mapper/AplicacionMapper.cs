using Entity;
using System.Data.SqlClient;

namespace Mapper
{
    public class AplicacionMapper
    {
        public static Aplicacion Map(SqlDataReader reader, Categoria categoria)
        {
            Aplicacion aplicacion = new Aplicacion
            {
                IdApp = Convert.ToInt32(reader["ID"].ToString()),
                Titulo = reader["TITULO"].ToString(),
                Descripcion = reader["DESCRIPCION"].ToString(),
                Desarrolladora = reader["DESARROLLADORA"].ToString(),
                Precio = Convert.ToDecimal(reader["PRECIO"].ToString()),
                Categoria = categoria
            };
            return aplicacion;
        }
    }
}
