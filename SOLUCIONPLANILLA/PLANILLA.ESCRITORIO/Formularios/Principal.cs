using PLANILLA.ESCRITORIO.Formularios.Mantenedor;
using PLANILLA.ESCRITORIO.Formularios.Planilla;
using PLANILLA.ESCRITORIO.Formularios.Reportes;
using PLANILLA.ESCRITORIO.Formularios.Trabajador;
using Utilitarios;

namespace PLANILLA.ESCRITORIO
{
    public partial class Principal : Form
    {
        FrmMensaje mensaje = new FrmMensaje();
        public Principal()
        {
            InitializeComponent();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCargos frm = new FrmCargos();
                frm.MenustripFrmMenu = cargosToolStripMenuItem;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                mensaje.mensaje_error(ex);
            }

        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGeneros frm = new FrmGeneros();
                frm.MenustripFrmMenu = generosToolStripMenuItem;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                mensaje.mensaje_error(ex);
            }
        }

        private void estadosCivilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEstadoCiviles frm = new FrmEstadoCiviles();
                frm.MenustripFrmMenu = estadosCivilesToolStripMenuItem;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                mensaje.mensaje_error(ex);
            }
        }

        private void sistemaDePensionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSistemaPensiones frm = new FrmSistemaPensiones();
                frm.MenustripFrmMenu = sistemaDePensionesToolStripMenuItem;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                mensaje.mensaje_error(ex);
            }
        }

        private void situacionDeTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSituacionTrabajador frm = new FrmSituacionTrabajador();
                frm.MenustripFrmMenu = situacionDeTrabajadorToolStripMenuItem;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                mensaje.mensaje_error(ex);
            }
        }

        private void tiposEDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTipoDocumento frm = new FrmTipoDocumento();
                frm.MenustripFrmMenu = tiposEDocumentosToolStripMenuItem;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                mensaje.mensaje_error(ex);

            }
        }

        private void fichaDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTrabajador frm = new FrmTrabajador();
                frm.MenustripFrmMenu = fichaDatosToolStripMenuItem;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                mensaje.mensaje_error(ex);

            }
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FrmParametros frm = new FrmParametros();
                frm.MenustripFrmMenu = parametrosToolStripMenuItem;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                mensaje.mensaje_error(ex);

            }
        }

        private void asistenciaTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FrmCargaAsistencia frm = new FrmCargaAsistencia();
                frm.MenustripFrmMenu = asistenciaTrabajadorToolStripMenuItem;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                mensaje.mensaje_error(ex);

            }
        }

        private void planillaMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPlanillaMensual frm = new FrmPlanillaMensual();
                frm.MenustripFrmMenu = planillaMensualToolStripMenuItem;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                mensaje.mensaje_error(ex);

            }
        }

        private void reporteBoletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteBoletas frm = new FrmReporteBoletas();
                frm.MenustripFrmMenu = reporteBoletaToolStripMenuItem;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                mensaje.mensaje_error(ex);

            }
        }
    }
}
