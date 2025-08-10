using Newtonsoft.Json;
using PLANILLA.ENTIDADES;
using PLANILLA.ESCRITORIO.Componentes;
using PLANILLA.ESCRITORIO.Controles;
using PLANILLA.UTILITARIOS;
using PLANILLA.UTILITARIOS.Request;
using PLANILLA.UTILITARIOS.Response;
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

namespace PLANILLA.ESCRITORIO.Formularios.Planilla
{
    public partial class FrmPlanillaMensual : FrmBase
    {
        public FrmPlanillaMensual()
        {
            InitializeComponent();
        }
        List<PlanillaMensual> arrplanilla = new List<PlanillaMensual>();
        List<SistemaPensiones> arrsistemapension = new List<SistemaPensiones>();
        List<Trabajadores> arrtrabajadores = new List<Trabajadores>();
        private async void FrmPlanillaMensual_Load(object sender, EventArgs e)
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
                HttpResponseMessage response = new HttpResponseMessage();
                response = await _httpClient.GetAsync($"{GlobalConstantes.ApiSistemaPensiones}BusquedaSistemaPensiones");
                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                using (HttpContent content = response.Content)
                {
                    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    {
                        case 200:
                            arrsistemapension = JsonConvert.DeserializeObject<List<SistemaPensiones>>(System.Convert.ToString(obj["data"]));


                            break;
                        case 500: throw new Exception(System.Convert.ToString(obj["message"]));

                    }
                }
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
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        private async void BtGenerar_Click(object sender, EventArgs e)
        {
            try
            {

                DgPlanilla.Rows.Clear();
                HttpResponseMessage response = new HttpResponseMessage();
                response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiPlanillaMensual}CalcularPlanillaByPeriodo", new BusquedaByPeriodo { año = ConvertForce.toInt(CbAño.SelectedValue), mes = ConvertForce.toInt(CbMes.SelectedValue) });
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
                                arrplanilla.OrderByDescending(r => r.Nombre).ToList().ForEach(pla =>
                                {
                                    DgPlanilla.Rows[DgPlanilla.Rows.Add(
                                       arrtrabajadores.FirstOrDefault(r => r.IdTrabajador == pla.IdTrabajador).Documento,
                                       $"{pla.Apellido} {pla.Nombre}",
                                       pla.nDiasTrab,
                                       pla.nDiasDescansos,
                                       pla.nDiasInasistencias,
                                       pla.nFeriadosTrab,
                                       pla.nHorasExtra1,
                                       pla.nHorasExtra2,
                                       pla.HaberBasico,
                                       pla.ValesEmpleado,
                                       pla.BonificacionCargo,
                                       pla.vHorasExtra1,
                                       pla.vHorasExtra2,
                                       pla.vFeriadoTrab,
                                       pla.TotalIngreso,
                                       arrsistemapension.FirstOrDefault(r => r.IdSistemaPension == pla.IdSistemaPension).Nombre,
                                       pla.Aporte,
                                       pla.Comision,
                                       pla.Prima,
                                       pla.TotalDescuento,
                                       pla.TotalNetoBoleta


                                        )].Tag = pla;

                                });
                            }

                            break;
                        case 500: throw new Exception(System.Convert.ToString(obj["message"]));

                    }
                }

            }
            catch (Exception EX)
            {
                mensaje_error(EX);
            }
        }

        private async void BtGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = new HttpResponseMessage();

                response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiPlanillaMensual}InsertLista", arrplanilla);

                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                using (HttpContent content = response.Content)
                {
                    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    {
                        case 200:

                            mensaje_Registrado();

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
    }
}
