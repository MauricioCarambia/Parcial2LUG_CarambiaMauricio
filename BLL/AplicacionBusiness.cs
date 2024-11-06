using Dal;
using Entity;
using System.Transactions;

namespace BLL
{
    public class AplicacionBusiness
    {
        private AplicacionData aplicacionData = new AplicacionData();

        public void GuardarAplicaciones(Aplicacion aplicaciones)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    if(aplicaciones.Precio <= 0)
                    {
                        throw new Exception("El precio debe ser mayor a cero");
                    }
                    if(aplicaciones.Titulo.Length <= 5)
                    {
                        throw new Exception("El titulo debe tener mas de 5 letras");
                    }
                    if(aplicaciones.Descripcion.Length <= 15)
                    {
                        throw new Exception("La descripcion debe tener mas de 15 letras");
                    }
                    if(aplicaciones.Categoria == null)
                    {
                        throw new Exception("Selecciones una categoria");
                    }
                    aplicacionData.GuardarAplicaciones(aplicaciones);
                    trx.Complete();
                }
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void GuardarAplicacion(List<Aplicacion> aplicacion)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    foreach(Aplicacion aplicaciones in aplicacion)
                    {
                        GuardarAplicaciones(aplicaciones);
                    }
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<Aplicacion> ObtenerTodasAplicaciones()
        {
            try
            {
                return aplicacionData.ObtenerTodasAplicaciones();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        public void ModificarAplicacion(int id, string titulo, string descripcion, string desarrolladora, decimal precio)
        {
            try
            {
                Aplicacion aplicacion = aplicacionData.ObtenerAppPorId(id);
                using (TransactionScope trx = new TransactionScope())
                {
                    
                    if (aplicacion == null)
                    {
                        throw new Exception("Aplicacion no existe");
                    }
                    if (precio <= 0)
                    {
                        throw new Exception("El precio debe ser mayor a cero");
                    }
                    if (titulo.Length <= 5)
                    {
                        throw new Exception("El titulo debe tener mas de 5 letras");
                    }
                    if (descripcion.Length <= 15)
                    {
                        throw new Exception("La descripcion debe tener mas de 15 letras");
                    }

                    aplicacion.Titulo = titulo;
                    aplicacion.Descripcion = descripcion;
                    aplicacion.Desarrolladora = desarrolladora;
                    aplicacion.Precio = precio;
                    aplicacionData.ModificarAplicacion(aplicacion);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarAplicacion(int id)
        {
            try
            {
                Aplicacion aplicacion = aplicacionData.ObtenerAppPorId(id);
                using (TransactionScope trx = new TransactionScope())
                {
                    
                    if (aplicacion == null)
                    {
                        throw new Exception("Aplicacion no existe");
                    }
                    aplicacionData.EliminarAplicacion(id);
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
