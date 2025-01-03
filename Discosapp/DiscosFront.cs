using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discosapp
{
    public partial class DiscosApp : Form
    {
        private List<Disco> listaDisco;
        public DiscosApp()
        {
            InitializeComponent();
        }

       
        private void textSerchName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textSerchName.Text == "Busqueda Por Nombre")
            {
                textSerchName.Text = "";
            }
        }


        private void textSerchName_Leave(object sender, EventArgs e)
        {
            if (textSerchName.Text == "")
            {
                textSerchName.Text = "Busqueda Por Nombre";
            }
        }

        private void DiscosApp_Load(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            listaDisco = negocio.Listar();
            dgvDiscos.DataSource = listaDisco;
            pboxDisco.Load(listaDisco[0].UrlImagenTapa);
        }
        //trabando con imagenes
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
           
               Disco DiscoSeleccionado= (Disco)dgvDiscos.CurrentRow.DataBoundItem;//para obttener el objeto enlazado, se transforma con un casteo explicito
               //pboxDisco.Load(DiscoSeleccionado.UrlImagenTapa);//despues se puede realizar la carga
                cargarImagen(DiscoSeleccionado.UrlImagenTapa);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pboxDisco.Load(imagen);
            }
            catch (Exception ex) {
                pboxDisco.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQDCXek_M1agTePOBcSZfP1O9qobtNXYz4OVg&s");
            }

        }
    }
}
