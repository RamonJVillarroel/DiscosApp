﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discosapp
{
    internal class Disco
    {

        public int IdDisco { get; set; }
        public string Nombre { get; set; }
        public string fechaDeLanzamiento { get; set; }
        public int CantidadDeCanciones { get; set; }

        public string UrlImagenTapa { get; set; }
    }
}
