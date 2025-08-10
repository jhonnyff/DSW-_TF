using PROYECTO.UTILITARIOS;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PLANILLA.UTILITARIOS.GlobalEnum;
using static PLANILLA.ESCRITORIO.Componentes.FrmBaseMensaje;


namespace PLANILLA.ESCRITORIO.Componentes
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }
        public ToolStripMenuItem MenustripFrmMenu = new ToolStripMenuItem();
        public _TipoAccion Accion_ = _TipoAccion.Ninguno;
        public HttpClient _httpClient;
        #region  REGION DE MENSAJES (MUESTRA LOS DIFERENTES TIPOS DE MENSAJES EN LOS FORMULARIOS DEL PROYECTO)
        public bool mensaje_Pregunta(string titulo, string mensaje)
        {
            FrmMensajeSiNo objFrm = new FrmMensajeSiNo();
            objFrm.Owner = this;
            objFrm.Text = "PREGUNTA ?";
            objFrm.Titulo = titulo;
            objFrm.Mensaje = mensaje;
            objFrm.FxIcono = FrmBaseMensaje._Iconos.Question;
            objFrm.ShowDialog();
            return objFrm.FxDecision == FrmMensajeSiNo._Decision.Si ? true : false;
        }
        public bool mensaje_Pregunta_EstaSeguroDeEliminarElRegistro()
        {
            FrmMensajeSiNo objFrm = new FrmMensajeSiNo();
            objFrm.Owner = this;
            objFrm.Text = "PREGUNTA ?";
            objFrm.Titulo = "ESTA SEGURO DE ELIMINAR EL REGISTRO";
            objFrm.Mensaje = "TENGA EN CUENTA QUE UNA VES ELIMINADO LOS DATOS NO SE PODRAN RECUPERAR";
            objFrm.FxIcono = FrmBaseMensaje._Iconos.Question;
            objFrm.ShowDialog();
            return objFrm.FxDecision == FrmMensajeSiNo._Decision.Si ? true : false;
        }
        public bool mensaje_Pregunta_EstaSeguroDeEliminarElRegistro(string mensaje)
        {
            FrmMensajeSiNo objFrm = new FrmMensajeSiNo();
            objFrm.Owner = this;
            objFrm.Text = "PREGUNTA ?";
            objFrm.Titulo = "ESTA SEGURO DE ELIMINAR EL REGISTRO";
            objFrm.Mensaje = mensaje;
            objFrm.FxIcono = FrmBaseMensaje._Iconos.Question;
            objFrm.ShowDialog();
            return objFrm.FxDecision == FrmMensajeSiNo._Decision.Si ? true : false;
        }
        public bool mensaje_OlvidoSeleccionarUnRegistro(DataGridView value)
        {
            bool ok = false;
            string mensaje = "";
            if (value.Rows.Count == 0)
            {
                mensaje = "NO HAY RESULTADOS PRESENTES";
                ok = true;
                //FxClient2.MessageBox.show(this, "UN MOMENTO POR FAVOR", "NO HAY RESULTADOS PRESENTES", Utilitarios.WindowsControls.FrmMessageBox._Buttons.Aceptar, Utilitarios.WindowsControls.FrmMessageBox._Iconos.Exclamation);
            }
            else if (value.CurrentRow == null)
            {
                ok = true;
                mensaje = "OLVIDO SELECCIONAR UN REGISTRO";
                //FxClient2.MessageBox.show(this, "UN MOMENTO POR FAVOR", "OLVIDO SELECCIONAR UN REGISTRO", Utilitarios.WindowsControls.FrmMessageBox._Buttons.Aceptar, Utilitarios.WindowsControls.FrmMessageBox._Iconos.Exclamation);
            }

            if (ok)
            {
                FrmMensajeAceptar objFrm = new FrmMensajeAceptar();
                objFrm.Owner = this;
                objFrm.Text = "ATENCION !";
                objFrm.Titulo = "UN MOMENTO POR FAVOR";
                objFrm.Mensaje = mensaje;
                objFrm.FxIcono = FrmBaseMensaje._Iconos.Exclamation;
                objFrm.ShowDialog();
            }

            return ok;
        }
        public object mensaje_IngresarUnDato(string titulo, string mensaje, Controles.TextBox.__TextBox_TipoMascara tipo_entrada = Controles.TextBox.__TextBox_TipoMascara.Ninguno, int maxlength = 32767)
        {
            FrmMensajeAceptarCancelar objFrm = new FrmMensajeAceptarCancelar();
            objFrm.Owner = this;
            objFrm.Text = "PREGUNTA ?";
            objFrm.Titulo = titulo;
            objFrm.Mensaje = mensaje;
            objFrm.FxIcono = FrmBaseMensaje._Iconos.Question;
            objFrm.TDato.FxMaskType = tipo_entrada;
            objFrm.TDato.MaxLength = maxlength;
            objFrm.ShowDialog();
            object rpta = objFrm.FxDecision == FrmMensajeAceptarCancelar._Decision.Si ? objFrm.TDato.Text : null;
            objFrm.Dispose();
            return rpta;
        }

        public void mensaje_error(Exception ex)
        {

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(delegate
                        {


                            FrmMensajeAceptar objFrm = new FrmMensajeAceptar();
                            objFrm.Owner = this;
                            objFrm.Text = "ERROR *";
                            objFrm.Titulo = ex.Source.ToUpper();
                            objFrm.Mensaje = ex.Message.ToUpper();
                            objFrm.FxIcono = FrmBaseMensaje._Iconos.Error;
                            objFrm.ShowDialog();

                        }));

                    }
                    else
                    {
                        FrmMensajeAceptar objFrm = new FrmMensajeAceptar();
                        objFrm.Owner = this;
                        objFrm.Text = "ERROR *";
                        objFrm.Titulo = ex.Source.ToUpper();
                        objFrm.Mensaje = ex.Message.ToUpper();
                        objFrm.FxIcono = FrmBaseMensaje._Iconos.Error;
                        objFrm.ShowDialog();
                    }
               
            
        }

        public void mensaje_error(string ex)
        {
            FrmMensajeAceptar objFrm = new FrmMensajeAceptar();
            objFrm.Owner = this;
            objFrm.Text = "ERROR *";
            objFrm.Titulo = "A OCURRIDO UN PROBLEMA";
            objFrm.Mensaje = ex;
            objFrm.FxIcono = FrmBaseMensaje._Iconos.Error;
            objFrm.ShowDialog();

            // FxClient2.MessageBox.show(this, ex.Source.ToUpper(), ex.Message.ToUpper(), Utilitarios.WindowsControls.FrmMessageBox._Buttons.Aceptar, Utilitarios.WindowsControls.FrmMessageBox._Iconos.Error);
        }
        public bool mensaje_OlvidoIngresarLosSiguientesDatos(string mensaje)
        {
            bool ok = false;
            if (mensaje != "")
            {
                ok = true;

                FrmMensajeAceptar objFrm = new FrmMensajeAceptar();
                objFrm.Owner = this;
                objFrm.Text = "ATENCION !";
                objFrm.Titulo = "OLVIDO INGRESAR LOS SIGUIENTES DATOS";
                objFrm.Mensaje = mensaje;
                objFrm.FxIcono = FrmBaseMensaje._Iconos.Exclamation;
                objFrm.ShowDialog();

                // FxClient2.MessageBox.show(this, "OLVIDO INGRESAR LOS SIGUIENTES DATOS", mensaje, Utilitarios.WindowsControls.FrmMessageBox._Buttons.Aceptar, Utilitarios.WindowsControls.FrmMessageBox._Iconos.Exclamation);
            }
            return ok;
        }
        public bool mensaje_HanOcurridoLosSiguientesErrores(string mensaje)
        {
            bool ok = false;
            if (mensaje != "")
            {
                ok = true;
                FrmMensajeAceptar objFrm = new FrmMensajeAceptar();
                objFrm.Owner = this;
                objFrm.Text = "ATENCION !";
                objFrm.Titulo = "HAN OCURRIDO LOS SIGUIENTES ERRORES";
                objFrm.Mensaje = mensaje;
                objFrm.FxIcono = FrmBaseMensaje._Iconos.Error;
                objFrm.ShowDialog();

                //FxClient2.MessageBox.show(this, "HAN OCURRIDO LOS SIGUIENTES ERRORES", mensaje, Utilitarios.WindowsControls.FrmMessageBox._Buttons.Aceptar, Utilitarios.WindowsControls.FrmMessageBox._Iconos.Exclamation);
            }
            return ok;
        }
        public void mensaje_Registrado()
        {
            FrmMensajeAceptar objFrm = new FrmMensajeAceptar();
            objFrm.Owner = this;
            objFrm.Text = "ATENCION !";
            objFrm.Titulo = "REGISTRO CORRECTO";
            objFrm.Mensaje = "LOS DATOS SE HAN GUARDADO EN LA BASE DE DATOS SIM PROBLEMAS";
            objFrm.FxIcono = FrmBaseMensaje._Iconos.Information;
            objFrm.ShowDialog();

            // FxClient2.MessageBox.show(this, "REGISTRO CORRECTO", "LOS DATOS SE HAN GUARDADO EN LA BASE DE DATOS SIM PROBLEMAS", Utilitarios.WindowsControls.FrmMessageBox._Buttons.Aceptar, Utilitarios.WindowsControls.FrmMessageBox._Iconos.Information );
        }
        public void mensaje_Eliminado()
        {
            FrmMensajeAceptar objFrm = new FrmMensajeAceptar();
            objFrm.Owner = this;
            objFrm.Text = "ATENCION !";
            objFrm.Titulo = "ELIMINACION CORRECTA";
            objFrm.Mensaje = "LOS DATOS SE HAN ELIMINADO DE LA BASE DE DATOS SIM PROBLEMAS";
            objFrm.FxIcono = FrmBaseMensaje._Iconos.Information;
            objFrm.ShowDialog();

            // FxClient2.MessageBox.show(this, "REGISTRO CORRECTO", "LOS DATOS SE HAN GUARDADO EN LA BASE DE DATOS SIM PROBLEMAS", Utilitarios.WindowsControls.FrmMessageBox._Buttons.Aceptar, Utilitarios.WindowsControls.FrmMessageBox._Iconos.Information );
        }
        public void mensaje_Actualizado()
        {
            FrmMensajeAceptar objFrm = new FrmMensajeAceptar();
            objFrm.Owner = this;
            objFrm.Text = "ATENCION !";
            objFrm.Titulo = "ACTUALIZACION CORRECTA";
            objFrm.Mensaje = "LOS DATOS SE HAN ACTUALIZADO EN LA BASE DE DATOS SIM PROBLEMAS";
            objFrm.FxIcono = FrmBaseMensaje._Iconos.Information;
            objFrm.ShowDialog();
            //  FxClient2.MessageBox.show(this, "ACTUALIZACION CORRECTA", "LOS DATOS SE HAN ACTUALIZADO EN LA BASE DE DATOS SIM PROBLEMAS", Utilitarios.WindowsControls.FrmMessageBox._Buttons.Aceptar, Utilitarios.WindowsControls.FrmMessageBox._Iconos.Information);
        }
        public void mensaje_Informativo(string titulo, string mensaje)
        {
            FrmMensajeAceptar objFrm = new FrmMensajeAceptar();
            objFrm.Owner = this;
            objFrm.Text = "ATENCION !";
            objFrm.Titulo = titulo.ToUpper();
            objFrm.Mensaje = mensaje.ToUpper();
            objFrm.FxIcono = FrmBaseMensaje._Iconos.Information;
            objFrm.ShowDialog();
            //  FxClient2.MessageBox.show(this, "ACTUALIZACION CORRECTA", "LOS DATOS SE HAN ACTUALIZADO EN LA BASE DE DATOS SIM PROBLEMAS", Utilitarios.WindowsControls.FrmMessageBox._Buttons.Aceptar, Utilitarios.WindowsControls.FrmMessageBox._Iconos.Information);
        }
        public void mensaje_Exclamacion(string titulo, string mensaje)
        {
            FrmMensajeAceptar objFrm = new FrmMensajeAceptar();
            objFrm.Owner = this;
            objFrm.Text = "ATENCION !";
            objFrm.Titulo = titulo.ToUpper();
            objFrm.Mensaje = mensaje.ToUpper();
            objFrm.FxIcono = FrmBaseMensaje._Iconos.Exclamation;
            objFrm.ShowDialog();
            //  FxClient2.MessageBox.show(this, "ACTUALIZACION CORRECTA", "LOS DATOS SE HAN ACTUALIZADO EN LA BASE DE DATOS SIM PROBLEMAS", Utilitarios.WindowsControls.FrmMessageBox._Buttons.Aceptar, Utilitarios.WindowsControls.FrmMessageBox._Iconos.Information);
        }
        #endregion

        public void BloqueoControles(bool estado)
        {
            foreach (Control c in this.Controls)
            {
                if (!(c is UserControl))
                    BloqueControl(c, estado);
            }

        }
        private void BloqueControl(Control R, bool estado)
        {
            if (R.Controls.Count > 0)
                foreach (Control c in R.Controls)
                {
                    if (!(c is UserControl))
                    {
                        if (c is System.Windows.Forms.TextBox || c is System.Windows.Forms.CheckBox || c is DateTimePicker || c is Button || c is PictureBox || c is ComboBox)
                            c.Enabled = estado;
                        if (c.Controls.Count > 0)
                        {
                            BloqueControl(c, estado);
                        }
                    }
                }
            else
                if (R is System.Windows.Forms.TextBox || R is System.Windows.Forms.CheckBox || R is DateTimePicker || R is Button || R is PictureBox || R is ComboBox || R is Controles.TextBox)
                R.Enabled = estado;
        }
        private void limpiarcontrol(Control R)
        {

            if (R.Controls.Count > 0)
            {
                foreach (Control c in R.Controls)
                {
                    if (!(c is UserControl))
                    {
                        if (c.GetType() == typeof(Controles.TextBox) || c.GetType() == typeof(System.Windows.Forms.TextBox))
                        {
                            System.Windows.Forms.TextBox t = c as System.Windows.Forms.TextBox;
                            t.Clear();
                        }
                        else if (c.GetType() == typeof(System.Windows.Forms.CheckBox))
                        {
                            System.Windows.Forms.CheckBox t = c as System.Windows.Forms.CheckBox;
                            t.Checked = false;
                        }
                        else if (c.GetType() == typeof(DateTimePicker))
                        {
                            DateTimePicker t = c as DateTimePicker;
                            t.Value = DateTime.Now;
                        }
                        else if (c.GetType() == typeof(MaskedTextBox))
                        {
                            MaskedTextBox t = c as MaskedTextBox;
                            t.Clear();
                        }
                        else if (c.GetType() == typeof(ComboBox))
                        {
                            ComboBox t = c as ComboBox;
                            t.SelectedIndex = -1;
                        }

                        if (c.Controls.Count > 0)
                        {
                            limpiarcontrol(c);
                        }
                    }
                }
            }
            else
            {
                if (!(R is UserControl))
                {
                    if (R.GetType() == typeof(Controles.TextBox) || R.GetType() == typeof(System.Windows.Forms.TextBox))
                    {
                        System.Windows.Forms.TextBox t = R as System.Windows.Forms.TextBox;
                        t.Clear();
                    }
                    else if (R.GetType() == typeof(System.Windows.Forms.CheckBox))
                    {
                        System.Windows.Forms.CheckBox t = R as System.Windows.Forms.CheckBox;
                        t.Checked = false;
                    }
                    else if (R.GetType() == typeof(DateTimePicker))
                    {
                        DateTimePicker t = R as DateTimePicker;
                        t.Value = DateTime.Now;
                    }
                    else if (R.GetType() == typeof(MaskedTextBox))
                    {
                        MaskedTextBox t = R as MaskedTextBox;
                        t.Clear();
                    }
                    else if (R.GetType() == typeof(ComboBox))
                    {
                        ComboBox t = R as ComboBox;
                        t.SelectedIndex = -1;
                    }
                }
            }

        }
        public void LimpiarControles()
        {

            foreach (Control c in this.Controls)
            {
                if (!(c is UserControl))
                    limpiarcontrol(c);
            }

        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            MenustripFrmMenu.Enabled = false;
            Accion_=_TipoAccion.Ninguno;
        }

        private void FrmBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenustripFrmMenu.Enabled = true;
        }
    }
}
