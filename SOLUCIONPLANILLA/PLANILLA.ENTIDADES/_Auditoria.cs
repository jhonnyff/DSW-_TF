﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANILLA.ENTIDADES
{
    public class _Auditoria
    {
        public bool? Activo { get; set; }
        public DateTime? FecCreacion { get; set; }
        public DateTime? FecUltimaModificacion { get; set; }
    }
}
