using System;
using System.Collections.Generic;
using dominio;
namespace negocio
{
    public class DiscoNegocio
    {
        public List<Disco> Listar()
        {
            List<Disco> lista = new List<Disco>();
            
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT d.Id, titulo, CantidadCanciones,UrlImagenTapa, e.Descripcion as Genero from DISCOS as D inner join ESTILOS as e on d.IdEstilo=e.Id;";
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.IdDisco = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["titulo"];
                    aux.CantidadDeCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
                    //Se le tiene que crear una instancia porque si no se crea una referencia nula
                    aux.Genero = new Genero();
                    aux.Genero.Descripcion = (string)datos.Lector["Genero"];
                    
                    // aux.fechaDeLanzamiento = (string)lector["FechaLanzamiento"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                datos.terminarConexion();
            }
        }
        public void agregar(Disco NuevoDisco)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //para insertar datos se puede hacer de esta forma
                string consulta = "INSERT INTO DISCOS(Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion)VALUES('"+ NuevoDisco.Nombre + "',GETDATE()," + NuevoDisco.CantidadDeCanciones+",'"+NuevoDisco.UrlImagenTapa+ "', @IdEstilo, @IdTipoEdicion);";
               
                datos.setearParametro("@IdEstilo", NuevoDisco.Genero.Id);
                datos.setearParametro("@IdTipoEdicion", NuevoDisco.Plataforma.Id);
                datos.setearConsulta(consulta);
                //importante para poder ejecutar datos
                datos.ejecutarAccion();
            }
            catch (Exception ex) { 
              throw ex;
            }
            finally
            {
                datos.terminarConexion();
            }

        }
        
    }
}
