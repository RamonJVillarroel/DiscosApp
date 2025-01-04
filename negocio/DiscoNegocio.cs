using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Collections;
//using System.Xml.Linq;
using System.Data.SqlClient;
using dominio;
namespace negocio
{
    public class DiscoNegocio
    {
        public List<Disco> Listar()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;//que se ssiempre datareader
            try
            {
                
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT d.Id, titulo, CantidadCanciones,UrlImagenTapa, e.Descripcion as Genero  from DISCOS as D inner join ESTILOS as e on d.IdEstilo=e.Id;";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.IdDisco = (int)lector["Id"];
                    aux.Nombre = (string)lector["titulo"];
                    aux.CantidadDeCanciones = (int)lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    //Se le tiene que crear una instancia porque si no se crea una referencia nula
                    aux.Genero = new Genero();
                    aux.Genero.Descripcion = (string)lector["Genero"];
                    // aux.fechaDeLanzamiento = (string)lector["FechaLanzamiento"];
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex){
               throw ex;
            }
        }
    }
}
