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
    public partial class FrmMensajeSiNo : FrmBaseMensaje
    {
        public FrmMensajeSiNo()
        {
            InitializeComponent();
        }
        public enum _Decision
        {
            Si,
            No,
        }
        private _Decision _FxDecision = _Decision.No;
        public _Decision FxDecision
        {
            get { return _FxDecision; }
        }


        private _Decision _FxBotonConFoco = _Decision.No;

        private void FrmMensajeSiNo_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            _FxDecision = _Decision.Si;
            this.Close();

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMensajeSiNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FrmMensajeSiNo_Shown(object sender, EventArgs e)
        {
            if (_FxBotonConFoco == _Decision.Si)
                BAceptar.Focus();
            else
                BCancelar.Focus();
        }

        public _Decision FxBotonConFoco
        {
            set
            {
                _FxBotonConFoco = value;
            }
        }
    }
}
