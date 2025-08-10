using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PLANILLA.UTILITARIOS.GlobalEnum;

namespace PLANILLA.UTILITARIOS.Request
{
    public class BuquedaTrabajador
    {
       public string Busqueda { get; set; }
        public _Estado estado { get; set; }=_Estado.Todos;
    }
}
