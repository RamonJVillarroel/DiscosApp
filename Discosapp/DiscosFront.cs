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
    }
}
