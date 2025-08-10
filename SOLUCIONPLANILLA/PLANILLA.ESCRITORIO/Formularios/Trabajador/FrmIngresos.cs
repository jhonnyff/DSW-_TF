using Newtonsoft.Json;
using PLANILLA.ENTIDADES;
using PLANILLA.ESCRITORIO.Componentes;
using PLANILLA.ESCRITORIO.Controles;
using PLANILLA.UTILITARIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLANILLA.ESCRITORIO.Formularios.Trabajador
{
    public partial class FrmIngresos : FrmBase
    {
        int IDTrabajador = 0;
        IngresosTrabajadores objIngreso = new IngresosTrabajadores();
        public FrmIngresos(int iDTrabajador)
        {
            InitializeComponent();
            IDTrabajador = iDTrabajador;
        }
        void calcularTotal()
        {
            TTotal.Text = Math.Round(ConvertForce.toDecimal(TRemuneracion.Text) + ConvertForce.toDecimal(TVales.Text) + ConvertForce.toDecimal(TBonificacion.Text), 2).ToString();

        }
        private void Tremuneracion_TextChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }
        async Task cargarparametro()
        {
            try
            {
                HttpResponseMessage response = new HttpResponseMessage();
                response = await _httpClient.GetAsync($"{GlobalConstantes.ApiParametro}BusquedaOne");
                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                using (HttpContent content = response.Content)
                {
                    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    {
                        case 200:
                            Parametros Lista = JsonConvert.DeserializeObject<Parametros>(System.Convert.ToString(obj["data"]));

                            if (Lista != null && Lista.IdParametro != 0)
                            {
                                TRemuneracion.Text = Lista.RemBasico.ToString();
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
        private async void FrmIngresos_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = new HttpResponseMessage();
                response = await _httpClient.GetAsync($"{GlobalConstantes.ApiIngresosTrabajadores}BusquedaOne?id={IDTrabajador}");
                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                using (HttpContent content = response.Content)
                {
                    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    {
                        case 200:
                            objIngreso = JsonConvert.DeserializeObject<IngresosTrabajadores>(System.Convert.ToString(obj["data"]));

                            if (objIngreso != null && objIngreso.IdTrabajador != 0)
                            {
                                TRemuneracion.Text = objIngreso.Remuneracion.ToString();
                                TVales.Text = objIngreso.Vale.ToString();
                                TBonificacion.Text = objIngreso.BonifCargo.ToString();
                            }
                            else
                            {
                                await cargarparametro();
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

        private async void BGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TRemuneracion.Text) || ConvertForce.toDecimal(TRemuneracion.Text) == 0) mensaje_error("El campo Remuneracion no puede estar vacio");

                HttpResponseMessage response = new HttpResponseMessage();
                if (objIngreso == null || objIngreso?.IdIngresoTrabajador == 0)
                {
                    response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiIngresosTrabajadores}Insert", new IngresosTrabajadores
                    {
                        Remuneracion = ConvertForce.toDecimal(TRemuneracion.Text),
                        Vale = ConvertForce.toDecimal(TVales.Text),
                        BonifCargo = ConvertForce.toDecimal(TBonificacion.Text),
                        IdTrabajador = IDTrabajador,
                    });
                }
                else
                {
                    objIngreso.Remuneracion = ConvertForce.toDecimal(TRemuneracion.Text);
                    objIngreso.Vale = ConvertForce.toDecimal(TVales.Text);
                    objIngreso.BonifCargo = ConvertForce.toDecimal(TBonificacion.Text);
                    response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiIngresosTrabajadores}Update", objIngreso);
                }


                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                using (HttpContent content = response.Content)
                {
                    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    {
                        case 200:

                            mensaje_Actualizado();
                            obj = null;
                            this.Close();
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
