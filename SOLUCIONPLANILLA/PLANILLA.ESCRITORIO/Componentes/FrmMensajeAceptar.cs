using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLANILLA.ESCRITORIO.Componentes
{
    public partial class FrmMensajeAceptar : FrmBaseMensaje
    {
        public FrmMensajeAceptar()
        {
            InitializeComponent();
        }

        private void FrmMensajeAceptar_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMensajeAceptar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
