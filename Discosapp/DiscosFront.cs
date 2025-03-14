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

        private void DiscosApp_Load(object sender, EventArgs e)
        {
            cargarDiscos();
            //Defino los desplegables
            cboCampo.Items.Add("Titulo");
            cboCampo.Items.Add("cantidad de canciones");
            cboCampo.Items.Add("plataforma");
        }
        //trabando con imagenes
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            //evaluo si es nulo porque si no iintentara rellenar con nulo y se rompera
            if (dgvDiscos.CurrentRow != null)
            {
                 Disco DiscoSeleccionado= (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                //para obttener el objeto enlazado, se transforma con un casteo explicito
               //pboxDisco.Load(DiscoSeleccionado.UrlImagenTapa);//despues se puede realizar la carga
                cargarImagen(DiscoSeleccionado.UrlImagenTapa);
            }
           
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
        //filtro rapido se realiza directamente con la lista en ell front por asi decirlo.

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

        //eliminacion logica y fisica
        //ficia elimina directamente sin poder recuperar
        //logica elimina y deja la opcion de poder recuperar
        //se hace con una columna de tipo bit (0 o 1) 
        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {

            eliminar();
        }
        private void eliminar(bool logico =false)
        {
            DiscoNegocio disco = new DiscoNegocio();
            Disco seleccionado;
            try
            {
                DialogResult result = MessageBox.Show("Quieres eliminar este activo?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

                    if (logico)
                        disco.eliminarLogico(seleccionado.IdDisco);
                    else
                        disco.eliminar(seleccionado.IdDisco);
                    cargarDiscos();
  

                }

            }
            catch (Exception ex) { throw ex; }

        }
        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            //para que pueda ser logico se debe setear en true ya que
            //de por si va en false es decir eliminar logico no funcionaria
            eliminar(true);
        }

        private void recargaFiltro()
        {
            string filtro = textSerchName.Text;
            if (filtro != "")
            {
                textSerchName.Text = "";
            }
        }
        //mejora de filtro rapido
        private void textSerchName_TextChanged(object sender, EventArgs e)
        {
            //requiere de una expresion lamda para realizar la busqueda.

            List<Disco> listafiltrada;
            string busqueda = textSerchName.Text;
            //hace una especie de ciclo contra la lista
            if (busqueda.Length >= 2)
            {
                //con condiciones logicas se pueden mejorar los filtros
                listafiltrada = listaDisco.FindAll(x => x.Nombre.ToUpper().Contains(busqueda.ToUpper()));

                //devuelve todo, por lo tanto se tiene que evitar
                dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
                dgvDiscos.Columns["IdDisco"].Visible = false;

            }
            else
            {

                listafiltrada = listaDisco;

            }
            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listafiltrada;
            //para limpiarfiltros
           
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "cantidad de canciones")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {   
            DiscoNegocio discoNegocio = new DiscoNegocio();
            try
            {
                string conteo = txtFiltroAvanzado.Text;
                if (conteo.Length > 0)
                {
                    string campo = cboCampo.SelectedItem.ToString();
                    string criterio = cboCriterio.SelectedItem.ToString();
                    string filtro =txtFiltroAvanzado.Text;
                    dgvDiscos.DataSource= discoNegocio.filtrar(campo, criterio, filtro);

                }
                else
                {
                    dgvDiscos.DataSource = listaDisco;
                }
                



            }catch (Exception ex ){ throw ex; }  
          




        }
    }
}
