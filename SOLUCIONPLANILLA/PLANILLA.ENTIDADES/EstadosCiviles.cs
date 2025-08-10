using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANILLA.ENTIDADES
{
    public class EstadosCiviles:_Auditoria
    {
        [Key]
        public int IdEstadoCivil { get; set; }
        public string Nombre { get; set; }

    }
}
