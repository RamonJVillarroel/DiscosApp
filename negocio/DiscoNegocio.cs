using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Collections;
//using System.Xml.Linq;
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
                string consulta = "SELECT d.Id, titulo, CantidadCanciones,UrlImagenTapa, e.Descripcion as Genero  from DISCOS as D inner join ESTILOS as e on d.IdEstilo=e.Id;";
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
    }
}
