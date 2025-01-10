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
        //crear el atributo privado para el elemento modificar
        // esto debido a que
        //
        // con esto logramos que cuando se cargue la app este nulo en la carga,
        //pero al querer modificar va a cargar el objeto a modificar
        //esto crea un pasamano entre ventanas
        private Disco disco=null;
        public AddDisco()
        {
            InitializeComponent();
        }
        public AddDisco(Disco Disco)
        {
            InitializeComponent();
            this.disco = Disco;
            Text = "Update Disco";
            sendDisco.Text = "Actualizar";
        }

        private void CancelarDisco_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sendDisco_Click(object sender, EventArgs e)
        {
            DiscoNegocio discoNegocio = new DiscoNegocio();

            try
            {
                if (disco==null)
                    disco = new Disco();

                disco.Nombre = txttitulo.Text;
                disco.CantidadDeCanciones = int.Parse(txtCanciones.Text);
                disco.UrlImagenTapa = txtUrlimagen.Text;
                //para que el disco pueda seleccionar el valor del combo box se usa selecte item
                // pero el select item devuelve un object
                //por lo tanto como se que lo que tengo es una clase puedo hacer el casteo.
                //porque se que viene es una clase
                disco.Genero = (Genero)cboxGenero.SelectedItem;
                disco.Plataforma = (Plataforma)cboxPlataforma.SelectedItem;
                //Como ver cual ejecutar
                if (disco.IdDisco != 0)
                {
                    discoNegocio.modificar(disco);
                    MessageBox.Show("MODIFICADO!!!!");
                }
                else {
                    discoNegocio.agregar(disco);
                    MessageBox.Show("NUEVO DISCO AGREGADO!!!!");
                }

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
                cboxPlataforma.DataSource = plataformaNegocio.Listar();
                //modificacion para los desplegables en modificar
                cboxPlataforma.ValueMember = "Id";
                cboxPlataforma.DisplayMember = "Descripcion";
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
                //modificacion para los desplegables en modificar
                cboxGenero.ValueMember = "Id";
                cboxGenero.DisplayMember = "Descripcion";
            }
            catch (Exception ex){
            MessageBox.Show(ex.ToString());
            }
        }

        private void AddDisco_Load(object sender, EventArgs e)
        {
            try
            {
                cargarPlataforma();
                cargarGenero();

                if (disco !=null)
                {
                  txttitulo.Text =disco.Nombre;
                  txtCanciones.Text = disco.CantidadDeCanciones.ToString();
                  txtUrlimagen.Text = disco.UrlImagenTapa;
                  cargarImagen(disco.UrlImagenTapa);
                  //con esto me aseguro de poder llamar a los desplegables a modificar
                  //modificar la consulta inicial
                  cboxGenero.SelectedValue = disco.Genero.Id;
                  cboxPlataforma.SelectedValue= disco.Plataforma.Id;
                    //MessageBox.Show("NUEVO DISCO AGREGADO!!!!");

                }
            }
            catch (Exception ex){  throw new Exception(ex.ToString()); }   
            
        }
    }
}
