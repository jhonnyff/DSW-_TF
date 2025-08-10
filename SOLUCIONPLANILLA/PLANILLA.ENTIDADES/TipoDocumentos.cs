﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANILLA.ENTIDADES
{
    public class TipoDocumentos: _Auditoria
    {
        [Key]
        public int IdTipoDocumento { get; set; }
        public string Nombre { get; set; }
        
    }
}
