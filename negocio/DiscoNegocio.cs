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
                string consulta = "SELECT d.Id, titulo, CantidadCanciones,UrlImagenTapa, e.Descripcion as Genero, e.Id as IdGenero, TE.Descripcion AS PLATAFORMA, TE.Id as IdPlataforma FROM DISCOS as D inner join ESTILOS as e on d.IdEstilo=e.Id INNER JOIN TIPOSEDICION AS TE on d.IdTipoEdicion = TE.Id;";
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.IdDisco = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["titulo"];
                    aux.CantidadDeCanciones = (int)datos.Lector["CantidadCanciones"];
                    //verificacion de que no sea nulo
                    //if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("UrlImagenTapa"))))
                    //{
                    //   aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
                    // }
                    //FORMA DOS DE VERIFICACION
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                    {
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
                    }
                    //Se le tiene que crear una instancia porque si no se crea una referencia nula
                    aux.Genero = new Genero();
                    aux.Genero.Descripcion = (string)datos.Lector["Genero"];
                    aux.Genero.Id = (int)datos.Lector["IdGenero"];
                    aux.Plataforma = new Plataforma();
                    aux.Plataforma.Descripcion = (string)datos.Lector["Plataforma"];
                    aux.Plataforma.Id = (int)datos.Lector["IdPlataforma"];

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
                string consulta = "INSERT INTO DISCOS(Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion)VALUES('" + NuevoDisco.Nombre + "',GETDATE()," + NuevoDisco.CantidadDeCanciones + ",'" + NuevoDisco.UrlImagenTapa + "', @IdEstilo, @IdTipoEdicion);";

                datos.setearParametro("@IdEstilo", NuevoDisco.Genero.Id);
                datos.setearParametro("@IdTipoEdicion", NuevoDisco.Plataforma.Id);
                datos.setearConsulta(consulta);
                //importante para poder ejecutar datos de añadido
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.terminarConexion();
            }

        }
        public void modificar(Disco disco) {
           // AccesoDatos accesoDatos = new AccesoDatos;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update DISCOS SET Titulo=@titulo,CantidadCanciones=@canciones, UrlImagenTapa=@img, IdEstilo=@Idgenero, IdTipoEdicion=@IdPlataforma WHERE id=@IdDisco;");
                datos.setearParametro("@titulo", disco.Nombre);
                datos.setearParametro("@canciones", disco.CantidadDeCanciones);
                datos.setearParametro("@img", disco.UrlImagenTapa);
                datos.setearParametro("@Idgenero", disco.Genero.Id);
                datos.setearParametro("@IdPlataforma", disco.Plataforma.Id);
                datos.setearParametro("@IdDisco", disco.IdDisco);
                //importante para poder ejecutar datos
                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw  ex; }
            finally { datos.terminarConexion(); }
        }
        public void eliminar(int idDisco)
        {
            try {
                AccesoDatos datos = new AccesoDatos();

                datos.setearConsulta("delete from DISCOS where id=@IdDisco;");
                datos.setearParametro("@IdDisco", idDisco);
                datos.ejecutarAccion();


            }
            catch (Exception ex) { throw ex; }  


        }
    }
}
