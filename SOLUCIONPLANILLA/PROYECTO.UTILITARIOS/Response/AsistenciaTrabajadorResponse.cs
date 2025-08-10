﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANILLA.UTILITARIOS.Response
{
    public class AsistenciaTrabajadorResponse
    {
        public int IdTrabajador { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public int? DiasLaborales { get; set; }
        public int? DiasDescanso { get; set; }
        public int? DiasInasistencia { get; set; }
        public int? DiasFeriados { get; set; }
        public decimal? HorasExtra25 { get; set; }
        public decimal? HorasExtra35 { get; set; }
        public int? IdAsistencia { get; set; }
    }
}
