using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
namespace Discosapp
{
    internal class DiscoNegocio
    {
        public List<DiscoNegocio> listar()
        {
            string Nombre, Descripcion;
            int Id, Numero;
            List<Disco> list = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataAdapter lector;
            try
            {
                
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)lector["Id"];
                    //aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.fechaDeLanzamiento = (string)lector["FechaDeLanzamiento"];
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
