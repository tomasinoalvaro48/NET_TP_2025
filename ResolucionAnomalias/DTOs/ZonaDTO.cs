﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ZonaDTO
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public int LocalidadId { set; get; }
        public string? LocalidadCodigo { set; get; }

    }
}
