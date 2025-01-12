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
            cargarDiscos();
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

        private void btnSerchName_Click(object sender, EventArgs e)
        {
            string name = textSerchName.Text;
            MessageBox.Show(name);
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddDisco addDisco = new AddDisco();
            addDisco.ShowDialog();
            cargarDiscos();
        }


        private void cargarDiscos()
        {
            try
            {
                DiscoNegocio negocio = new DiscoNegocio();
                listaDisco = negocio.Listar();
                dgvDiscos.DataSource = listaDisco;
                //dgvDiscos.Columns["FechaLanzamiento"].Visible = false;
                dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
                pboxDisco.Load(listaDisco[0].UrlImagenTapa);
            }
            catch (Exception ex) { 

                MessageBox.Show(ex.Message);  
         
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {   
            //instanicio lo que quiero modificar
            Disco seleccionado;
            seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            //se lo debo pasar al formuladio que debo de modificar para que genere la nueva instancia con el parametro a recibir
            //min 4
            //
            AddDisco modificar = new AddDisco(seleccionado);
            modificar.ShowDialog();
            cargarDiscos();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            DiscoNegocio disco = new DiscoNegocio();
            Disco seleccionado;
            try
            {
                DialogResult result = MessageBox.Show("Quieres eliminar este activo?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                    disco.elimnar(seleccionado.IdDisco);
                   // cargarDiscos();

                }

            }
            catch (Exception ex){ throw ex; }
         
        }
    }
}
