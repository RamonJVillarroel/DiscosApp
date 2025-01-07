using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
namespace Discosapp
{
    public partial class AddDisco : Form
    {
        public AddDisco()
        {
            InitializeComponent();
        }

        private void CancelarDisco_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sendDisco_Click(object sender, EventArgs e)
        {
            Disco NuevoDisco = new Disco();
            DiscoNegocio discoNegocio = new DiscoNegocio();
            try
            {
               
                NuevoDisco.Nombre = txttitulo.Text;
                NuevoDisco.CantidadDeCanciones = int.Parse(txtCanciones.Text);
                NuevoDisco.UrlImagenTapa = txtUrlimagen.Text;
            
                discoNegocio.agregar(NuevoDisco);
                MessageBox.Show("NUEVO DISCO AGREGADO!!!!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }

        private void txtUrlimagen_Leave(object sender, EventArgs e)
        {
            string picture = txtUrlimagen.Text;
            cargarImagen(picture);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboxDisco.Load(imagen);
            }
            catch (Exception ex)
            {
                pboxDisco.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQDCXek_M1agTePOBcSZfP1O9qobtNXYz4OVg&s");
            }

        }

         private void cargarPlataforma()
        {
            try
            {
                PlataformaNegocio plataformaNegocio = new PlataformaNegocio();
                cboxPlataforma.DataSource= plataformaNegocio.Listar();
              
            }
            catch (Exception ex) { 

                MessageBox.Show(ex.Message);  
         
            }
        }
        private void cargarGenero()
        {
             
            try
            {
                GenerosNegocio generoNegocio = new GenerosNegocio();
                cboxGenero.DataSource = generoNegocio.Listar();

            }
            catch (Exception ex){
            MessageBox.Show(ex.ToString());
            }
        }

        private void AddDisco_Load(object sender, EventArgs e)
        {
            cargarPlataforma();
            cargarGenero();
        }
    }
}
