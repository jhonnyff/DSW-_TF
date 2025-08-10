using Newtonsoft.Json;
using PLANILLA.ENTIDADES;
using PLANILLA.ESCRITORIO.Componentes;
using PLANILLA.ESCRITORIO.Controles;
using PLANILLA.UTILITARIOS;
using PLANILLA.UTILITARIOS.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Utilitarios;
using ConvertForce = PLANILLA.ESCRITORIO.Controles.ConvertForce;


namespace PLANILLA.ESCRITORIO.Formularios.Trabajador
{
    public partial class FrmTrabajador : FrmBase
    {
        public FrmTrabajador()
        {
            InitializeComponent();
        }
        Trabajadores objTrabajador = new Trabajadores();
        List<Cargos> ArrCargos = new List<Cargos>();
        List<SituacionTrabajador> ArrSituacion = new List<SituacionTrabajador>();
        List<TipoDocumentos> ArrTpoDocumento = new List<TipoDocumentos>();
        List<Generos> ArrGenero = new List<Generos>();
        List<EstadosCiviles> ArrEstadocivil = new List<EstadosCiviles>();
        List<SistemaPensiones> ArrSistemaPensiones = new List<SistemaPensiones>();
        private async void FrmTrabajador_Load(object sender, EventArgs e)
        {
            EstadoControles(false);
            await CargarParametros();
            CargarCombos();
        }
        async Task CargarParametros()
        {
            try
            {

                HttpResponseMessage response = new HttpResponseMessage();
                response = await _httpClient.GetAsync($"{GlobalConstantes.ApiParametro}ParametrosFormularioTrabajador");
                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                using (HttpContent content = response.Content)
                {
                    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    {
                        case 200:
                            var objarr = JsonConvert.DeserializeObject<dynamic>(System.Convert.ToString(obj["data"]));
                            ArrCargos = JsonConvert.DeserializeObject<List<Cargos>>(System.Convert.ToString(objarr["cargos"]));
                            ArrSituacion = JsonConvert.DeserializeObject<List<SituacionTrabajador>>(System.Convert.ToString(objarr["situaciones"]));
                            ArrTpoDocumento = JsonConvert.DeserializeObject<List<TipoDocumentos>>(System.Convert.ToString(objarr["tipoDocumentos"]));
                            ArrGenero = JsonConvert.DeserializeObject<List<Generos>>(System.Convert.ToString(objarr["generos"]));
                            ArrEstadocivil = JsonConvert.DeserializeObject<List<EstadosCiviles>>(System.Convert.ToString(objarr["estadosCiviles"]));
                            ArrSistemaPensiones = JsonConvert.DeserializeObject<List<SistemaPensiones>>(System.Convert.ToString(objarr["sistemaPensiones"]));



                            break;
                        case 500: throw new Exception(System.Convert.ToString(obj["message"]));

                    }
                }
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }

        }
        void CargarCombos()
        {
            CbCargo.DataSource = null;
            CbCargo.DataSource = ArrCargos;
            CbCargo.DisplayMember = "Nombre";
            CbCargo.ValueMember = "IdCargo";

            CbGenero.DataSource = null;
            CbGenero.DataSource = ArrGenero;
            CbGenero.DisplayMember = "Nombre";
            CbGenero.ValueMember = "IdGenero";

            CbEstadoCivil.DataSource = null;
            CbEstadoCivil.DataSource = ArrEstadocivil;
            CbEstadoCivil.DisplayMember = "Nombre";
            CbEstadoCivil.ValueMember = "IdEstadoCivil";

            CbSituacion.DataSource = null;
            CbSituacion.DataSource = ArrSituacion;
            CbSituacion.DisplayMember = "Nombre";
            CbSituacion.ValueMember = "IdSituacion";

            CbTipoDocumento.DataSource = null;
            CbTipoDocumento.DataSource = ArrTpoDocumento;
            CbTipoDocumento.DisplayMember = "Nombre";
            CbTipoDocumento.ValueMember = "IdTipoDocumento";

            CbSistemaPension.DataSource = null;
            CbSistemaPension.DataSource = ArrSistemaPensiones;
            CbSistemaPension.DisplayMember = "Nombre";
            CbSistemaPension.ValueMember = "IdSistemaPension";
        }
        void Limpiar()
        {

            CargarCombos();
            TDocumento.Clear();
            TNombre.Clear();
            TApellidoMaterno.Clear();
            TApellidoPaterno.Clear();
            THijos.Clear();
            TDireccion.Clear();
            TEmail.Clear();
            DtpIngreso.Value = DateTime.Now;
            Dtpnacimiento.Value = DateTime.Now;
            objTrabajador = new Trabajadores();
            PImagen.Image = null;
        }
        void EstadoControles(bool estado)
        {
            BCargarImagen.Enabled = estado;
            TDocumento.Enabled = estado;
            CbTipoDocumento.Enabled = estado;
            PImagen.Enabled = estado;
            DtpIngreso.Enabled = estado;
            Dtpnacimiento.Enabled = estado;
            THijos.Enabled = estado;
            TEmail.Enabled = estado;
            TDireccion.Enabled = estado;
            CbSistemaPension.Enabled = estado;
            CbSituacion.Enabled = estado;
            CbCargo.Enabled = estado;
            CbEstadoCivil.Enabled = estado;
            CbGenero.Enabled = estado;
            TApellidoPaterno.Enabled = estado;
            TApellidoMaterno.Enabled = estado;
            TNombre.Enabled = estado;
            BtIngresos.Visible = false;
        }
        void LLenarCampos()
        {
            if (objTrabajador != null && objTrabajador.IdTrabajador > 0)
            {
                CbTipoDocumento.SelectedValue = objTrabajador.IdTipoDocumento;
                TDocumento.Text = objTrabajador.Documento;
                TNombre.Text = objTrabajador.Nombres;
                TApellidoPaterno.Text = objTrabajador.ApellidoPaterno;
                TApellidoMaterno.Text = objTrabajador.ApellidoMaterno;
                CbGenero.SelectedValue = objTrabajador.IdGenero;
                CbEstadoCivil.SelectedValue = objTrabajador.IdEstadoCivil;
                TDireccion.Text = objTrabajador.Direccion;
                TEmail.Text = objTrabajador.Email;
                THijos.Text = objTrabajador.Hijos.ToString();
                CbTipoDocumento.SelectedValue = objTrabajador.IdCargo;
                Dtpnacimiento.Value = objTrabajador.FecNacimiento;
                Dtpnacimiento.Value = objTrabajador.FecIngreso;
                CbSituacion.SelectedValue = objTrabajador.IdSituacion;
                CbSistemaPension.SelectedValue = objTrabajador.IdSistemaPension;
                PImagen.Image = objTrabajador.Foto == null ? null : Controles.Convert.toImage(objTrabajador.Foto);
            }
        }
        async void llenardatagrid(string busqueda)
        {
            try
            {
                DGBusqueda.Rows.Clear();
                HttpResponseMessage response = new HttpResponseMessage();
                response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiTrabajador}BusquedaTrabajadores", new BuquedaTrabajador { Busqueda = busqueda, estado = GlobalEnum._Estado.Todos });
                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                using (HttpContent content = response.Content)
                {
                    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    {
                        case 200:
                            List<Trabajadores> Lista = JsonConvert.DeserializeObject<List<Trabajadores>>(System.Convert.ToString(obj["data"]));

                            if (Lista != null && Lista.Any())
                            {
                                Lista.OrderByDescending(r => r.Activo).ThenBy(r => r.Nombres).ToList().ForEach(list =>
                                {
                                    DGBusqueda.Rows[DGBusqueda.Rows.Add(
                                        list.Documento, list.Nombres + " " + list.ApellidoPaterno + " " + list.ApellidoMaterno, list.Activo
                                        )].Tag = list;

                                });
                            }

                            break;
                        case 500: throw new Exception(System.Convert.ToString(obj["message"]));

                    }
                }
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }

        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                Accion_ = GlobalEnum._TipoAccion.Nuevo;
                EstadoControles(true);
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        private void BCargarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog carga = new OpenFileDialog();
                carga.Filter = "images files (*.jpg)|";
                carga.ShowDialog();
                System.Drawing.Image image = new Bitmap(carga.FileName);
                PImagen.Image = image;
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        private void PImagen_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (mensaje_Pregunta("Esta Seguro?", "Desea Eliminar??"))
                {
                    PImagen.Image = null;
                }
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        StringBuilder ValidarCampos()
        {
            StringBuilder cadena = new StringBuilder();
            if (string.IsNullOrEmpty(TDocumento.Text)) cadena.AppendLine("- Debe Ingresar El Numero Documento.");
            if (string.IsNullOrEmpty(TNombre.Text)) cadena.AppendLine("- Debe Ingresar El Nombre del Trabajador.");
            if (string.IsNullOrEmpty(TApellidoPaterno.Text)) cadena.AppendLine("- Debe Ingresar El Ap. Paterno del Trabajador.");
            if (string.IsNullOrEmpty(TApellidoMaterno.Text)) cadena.AppendLine("- Debe Ingresar El Ap. Materno del Trabajador.");

            return cadena;
        }

        Trabajadores CargarObjeto()
        {
            if (Accion_ == GlobalEnum._TipoAccion.Nuevo) objTrabajador = new Trabajadores();
            objTrabajador.IdTipoDocumento = (int)CbTipoDocumento.SelectedValue;
            objTrabajador.Documento = TDocumento.Text;
            objTrabajador.Nombres = TNombre.Text;
            objTrabajador.ApellidoPaterno = TApellidoPaterno.Text;
            objTrabajador.ApellidoMaterno = TApellidoMaterno.Text;
            objTrabajador.IdGenero = (int)CbGenero.SelectedValue;
            objTrabajador.IdEstadoCivil = (int)CbEstadoCivil.SelectedValue;
            objTrabajador.Direccion = TDireccion.Text;
            objTrabajador.Email = TEmail.Text;
            objTrabajador.Hijos = ConvertForce.toInt(THijos.Text);
            objTrabajador.IdCargo = (int)CbTipoDocumento.SelectedValue;
            objTrabajador.FecNacimiento = Dtpnacimiento.Value;
            objTrabajador.FecIngreso = Dtpnacimiento.Value;
            objTrabajador.IdSituacion = (int)CbSituacion.SelectedValue;
            objTrabajador.IdSistemaPension = (int)CbSistemaPension.SelectedValue;
            objTrabajador.Foto = PImagen.Image == null ? null : Controles.Convert.toArrayByte(PImagen.Image);
            return objTrabajador;
        }

        private async void BGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder mensaje = ValidarCampos();
                if (!string.IsNullOrEmpty(mensaje.ToString())) mensaje_Exclamacion("Advertencia!!!", mensaje.ToString());
                Trabajadores objT = CargarObjeto();

                HttpResponseMessage response = new HttpResponseMessage();
                switch (Accion_)
                {
                    case GlobalEnum._TipoAccion.Nuevo:
                        response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiTrabajador}Insert", objT);
                        break;
                    case GlobalEnum._TipoAccion.Modificar:

                        response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiTrabajador}Update", objT);
                        break;
                }

                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                using (HttpContent content = response.Content)
                {
                    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    {
                        case 200:
                            switch (Accion_)
                            {
                                case GlobalEnum._TipoAccion.Nuevo:
                                    mensaje_Registrado();
                                    break;
                                case GlobalEnum._TipoAccion.Modificar:
                                    mensaje_Actualizado();
                                    break;
                            }
                            obj = null;
                            Limpiar();
                            EstadoControles(false);
                            break;
                        case 500: throw new Exception(System.Convert.ToString(obj["message"]));

                    }
                }
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (objTrabajador.IdTrabajador > 0)
                {
                    EstadoControles(true);
                    Accion_ = GlobalEnum._TipoAccion.Modificar;
                    BtIngresos.Visible = true;
                }
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        private void DGBusqueda_SelectionChanged(object sender, EventArgs e)
        {
            if (DGBusqueda.SelectedRows.Count == 1 && DGBusqueda.SelectedRows[0].Tag != null)
            {
                objTrabajador = DGBusqueda.SelectedRows[0].Tag as Trabajadores;
                LLenarCampos();
            }
        }

        private void DGBusqueda_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right && DGBusqueda.CurrentCell != null)
                {
                    if (DGBusqueda.CurrentCell.ColumnIndex != 0)
                    {
                        if (DGBusqueda.SelectedCells.Count != 0)
                        {
                            MenuStrip.Show(DGBusqueda, new System.Drawing.Point(e.X, e.Y));
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        private async void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Trabajadores objT = DGBusqueda.SelectedRows[0].Tag as Trabajadores;
                if (objT != null)
                {
                    HttpResponseMessage response = new HttpResponseMessage();

                    response = await _httpClient.GetAsync($"{GlobalConstantes.ApiTrabajador}CambiarEstado?id={objT.IdTrabajador}");

                    if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                    using (HttpContent content = response.Content)
                    {
                        var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                        switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                        {
                            case 200:

                                mensaje_Actualizado();

                                obj = null;

                                llenardatagrid(TBusqueda.Text);

                                break;
                            case 500: throw new Exception(System.Convert.ToString(obj["message"]));

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                llenardatagrid(TBusqueda.Text);
                DGBusqueda.ClearSelection();
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        private void BtIngresos_Click(object sender, EventArgs e)
        {
            try
            {
                if (objTrabajador.IdTrabajador != 0)
                {
                    FrmIngresos frm = new FrmIngresos(objTrabajador.IdTrabajador);
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }
    }
}
