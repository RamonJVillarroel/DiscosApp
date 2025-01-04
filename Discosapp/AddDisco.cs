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
    }
}
