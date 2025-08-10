using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANILLA.ESCRITORIO.Controles
{
    public interface IControl
    {
        System.Windows.Forms.Control[] ObjPanel { get; set; }
    }
}
