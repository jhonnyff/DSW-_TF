using Newtonsoft.Json;
using PLANILLA.ESCRITORIO.Componentes;
using PLANILLA.UTILITARIOS.Request;
using PLANILLA.UTILITARIOS.Response;
using PLANILLA.UTILITARIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLANILLA.ESCRITORIO.Controles;
using PLANILLA.ENTIDADES;

namespace PLANILLA.ESCRITORIO.Formularios.Reportes
{
    public partial class FrmReporteBoletas : FrmBase
    {
        List<PlanillaMensual> arrplanilla = new List<PlanillaMensual>();
        List<Trabajadores> arrtrabajadores = new List<Trabajadores>();

        List<Cargos> ArrCargos = new List<Cargos>();
        List<SituacionTrabajador> ArrSituacion = new List<SituacionTrabajador>();
        List<TipoDocumentos> ArrTpoDocumento = new List<TipoDocumentos>();
        List<Generos> ArrGenero = new List<Generos>();
        List<EstadosCiviles> ArrEstadocivil = new List<EstadosCiviles>();
        List<SistemaPensiones> ArrSistemaPensiones = new List<SistemaPensiones>();
        public FrmReporteBoletas()
        {
            InitializeComponent();

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
        private string GenerarBoletaHtml(PlanillaMensual obj)
        {
            Trabajadores objtrabajadores = arrtrabajadores.FirstOrDefault(r=>r.IdTrabajador==obj.IdTrabajador);
            Cargos objCargos = ArrCargos.FirstOrDefault(r => r.IdCargo == obj.IdCargo);
            SituacionTrabajador ObjSituacion = ArrSituacion.FirstOrDefault(r => r.IdSituacion == obj.IdSituacion);
            TipoDocumentos objTpoDocumento = ArrTpoDocumento.FirstOrDefault(r => r.IdTipoDocumento == objtrabajadores.IdTipoDocumento);
            SistemaPensiones objSistemaPensiones = ArrSistemaPensiones.FirstOrDefault(r => r.IdSistemaPension == obj.IdSistemaPension);
            // Aquí debes personalizar los datos dinámicos (puedes usar datos de tu base de datos)
            string html = @"
            <!DOCTYPE html>
            <html lang='es'>
            <head>
                <meta charset='UTF-8'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <title>Boleta de Pago</title>
                <style>
                    body { font-family: Arial, sans-serif; margin: 0; padding: 0; }
                    .boleta { width: 800px; margin: 0 auto; padding: 20px; border: 1px solid #ccc; }
                    header { display: flex; justify-content: space-between; align-items: center; border-bottom: 2px solid #000; padding-bottom: 10px; }
                    header h1 { font-size: 24px; color: #0046ad; }
                    header h1 span { color: orange; }
                    .empresa-logo img { width: 150px; height: auto; }
                    .trabajador-info, .detalles, .resumen { margin-top: 20px; }
                    .detalles { display: flex; justify-content: space-between; }
                    .detalles div { width: 30%; }
                    .detalles table { width: 100%; border-collapse: collapse; }
                    .detalles table td { padding: 5px; border-bottom: 1px solid #ccc; }
                    footer { text-align: center; margin-top: 30px; }
                </style>
            </head>"+
$@"
            <body>
                <div class='boleta'>
                    <header>
                        <div class='empresa-info'>
                            <h1>BOLETA DE PAGO <span>ENERO DEL 2024</span></h1>
                            <p><strong>Razón Social:</strong> Nombre Empresa Contratada</p>
                            <p><strong>Dirección:</strong> Direccion Empresa Contratada</p>
                            <p><strong>NIT:</strong> 25263987456 &nbsp; <strong>Reg. Patronal:</strong> 070710-00156</p>
                        </div>
                        <div class='empresa-logo'>
                            <img src='logo.png' alt='Logo de la Empresa'>
                            <p>D.S. N° 001-98-TR del 22/01/1998</p>
                        </div>
                    </header>

                    <section class='trabajador-info'>
                        <h2>Trabajador</h2>
                        <p><strong>Trabajador:</strong> {objtrabajadores.Documento} {objtrabajadores.Nombres} {objtrabajadores.ApellidoPaterno} {objtrabajadores.ApellidoMaterno}</p>
                        <p><strong>Fecha Ingreso:</strong> {objtrabajadores.FecIngreso.ToString("dd/MM/yyyy")}</p>
                        <p><strong>Cargo:</strong>{objCargos.Nombre}</p>
                        <p><strong>AFP/ONP:</strong> {objSistemaPensiones.Nombre} &nbsp; <strong>Código SPP:</strong> 652940CABEÑ3</p>
                        <p><strong>Días Trab.:</strong> {obj.nDiasTrab} &nbsp; <strong>Horas:</strong> {obj.nHorasNormal}</p>
                    </section>

                    <section class='detalles'>
                        <div class='ingresos'>
                            <h3>Ingresos</h3>
                            <table>
                                <tr><td>Rem. Básico</td><td>S/ {obj.HaberBasico}</td></tr>
                                <tr><td>Asig. Familiar</td><td>S/ {obj.vAsigFamiliar}</td></tr>
                                <tr><td>Horas Extras 25%</td><td>S/ {obj.vHorasExtra1}</td></tr>
                                <tr><td>Horas Extras 35%</td><td>S/ {obj.vHorasExtra2}</td></tr>
                                <tr><td>Dias Feriados</td><td>S/ {obj.vFeriadoTrab}</td></tr>
                                <tr><td>Dias Feriados</td><td>S/ {obj.ValesEmpleado}</td></tr>
                                <tr><td>Dias Feriados</td><td>S/ {obj.BonificacionCargo}</td></tr>
        
                                <tr><td>Total Ingresos</td><td><strong>S/ {obj.TotalIngreso}</strong></td></tr>
                            </table>
                        </div>
                        
                        <div class='descuentos'>
                            <h3>Descuentos de Ley</h3>
                            <table>
                                <tr><td>Aporte</td><td>S/ {obj.Aporte}</td></tr>
                                <tr><td>Comision</td><td>S/ {obj.Comision}</td></tr>
                                <tr><td>Prima</td><td>S/ {obj.Prima}</td></tr>
                                
                                <tr><td>Total Descuentos</td><td><strong>S/ {obj.TotalDescuento}</strong></td></tr>
                            </table>
                        </div>

                        <div class='aportes'>
                            <h3>Aportes del Empleador</h3>
                            <table>
                                <tr><td>ESSALUD</td><td>S/ {obj.EsSalud}</td></tr>
                                <tr><td>Seguro Vida Ley</td><td>S/ {obj.SeguroVidaLey}</td></tr>
                                <tr><td>Total Empleador</td><td><strong>S/ {obj.EsSalud + obj.SeguroVidaLey}</strong></td></tr>
                            </table>
                        </div>
                    </section>

                    <section class='resumen'>
                        <div class='neto'>
                            <h3>Resumen</h3>
                            <p><strong>Neto a Pagar:</strong> S/ {obj.TotalNetoBoleta}</p>
                            <p><strong>Son:</strong> {obj.TotalNetoBoletaCad}</p>
                        </div>
                    </section>

                    <footer>
                        <p><strong>Emp. Nombre de Sistema</strong></p>
                        <p>Recibí Conforme: <span>____________</span> DNI: <span>____________</span></p>
                    </footer>
                </div>
            </body>
            </html>";

            return html;
        }
        private async void BtGenerar_Click(object sender, EventArgs e)
        {
            try
            {

                DGBusqueda.Rows.Clear();
                HttpResponseMessage response = new HttpResponseMessage();
                response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiTrabajador}BusquedaTrabajadores", new BuquedaTrabajador { Busqueda = "", estado = GlobalEnum._Estado.Todos });
                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                using (HttpContent content = response.Content)
                {
                    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    {
                        case 200:
                            arrtrabajadores = JsonConvert.DeserializeObject<List<Trabajadores>>(System.Convert.ToString(obj["data"]));


                            break;
                        case 500: throw new Exception(System.Convert.ToString(obj["message"]));

                    }
                }

                response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiPlanillaMensual}BuscarListaBoletasByPeriodo", new BusquedaByPeriodo { año = ConvertForce.toInt(CbAño.SelectedValue), mes = ConvertForce.toInt(CbMes.SelectedValue) });
                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                using (HttpContent content = response.Content)
                {
                    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    {
                        case 200:
                            arrplanilla = JsonConvert.DeserializeObject<List<PlanillaMensual>>(System.Convert.ToString(obj["data"]));

                            if (arrplanilla != null && arrplanilla.Any())
                            {
                                arrplanilla.OrderByDescending(r => r.Nombre).ToList().ForEach(list =>
                                {
                                    DGBusqueda.Rows[DGBusqueda.Rows.Add(
                                        arrtrabajadores.FirstOrDefault(r => r.IdTrabajador == list.IdTrabajador).Documento,
                                        $"{list.Apellido} {list.Nombre}",
                                        list.TotalNetoBoleta
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
        private async void FrmReporteBoletas_Load(object sender, EventArgs e)
        {
            try
            {
                CbMes.DataSource = GlobalVariables.Mes();
                CbMes.DisplayMember = "Nombre";
                CbMes.ValueMember = "Id";
                CbMes.SelectedValue = DateTime.Now.Month;
                CbAño.DataSource = GlobalVariables.AñoPeriodo();
                CbAño.DisplayMember = "Nombre";
                CbAño.ValueMember = "Id";
                CbAño.SelectedValue = DateTime.Now.Year;
                await CargarParametros();
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }
        private async void DGBusqueda_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DGBusqueda.SelectedRows.Count == 1 && DGBusqueda.SelectedRows[0].Tag != null)
                {
                    await webView21.EnsureCoreWebView2Async(null);

                    // Llama a la función para generar el HTML y cargarlo en el WebView2
                    string boletaHtml = GenerarBoletaHtml(DGBusqueda.SelectedRows[0].Tag as PlanillaMensual);
                    webView21.NavigateToString(boletaHtml);

                }
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }
    }
}
