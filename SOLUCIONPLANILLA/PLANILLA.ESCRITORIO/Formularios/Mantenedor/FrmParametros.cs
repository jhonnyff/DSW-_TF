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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLANILLA.ESCRITORIO.Formularios.Mantenedor
{
    public partial class FrmParametros : FrmBase
    {
        public FrmParametros()
        {
            InitializeComponent();
        }
        Parametros obj = new Parametros();
        private void FrmParametros_Load(object sender, EventArgs e)
        {
            try
            {
                CargarParametro();
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }
        async void CargarParametro()
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
                            Parametros Para = JsonConvert.DeserializeObject<Parametros>(System.Convert.ToString(obj["data"]));
                            Accion_ = GlobalEnum._TipoAccion.Nuevo;
                            if (Para != null && Para.IdParametro > 0)
                            {
                                TRemuneracion.Text = Para.RemBasico.ToString();
                                TPorcAsignacion.Text = Para.PorcAsigancionFamiliar.ToString();
                                TPorcHora1.Text = Para.PorcExtra1.ToString();
                                TPorcHora2.Text = Para.PorcExtra2.ToString();
                                Accion_ = GlobalEnum._TipoAccion.Modificar;
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
                if (string.IsNullOrEmpty(TRemuneracion.Text)) mensaje_error("El campo Remuneracion no puede estar vacio");
                if (string.IsNullOrEmpty(TPorcAsignacion.Text)) mensaje_error("El campo Porc. Asignacion no puede estar vacio");
                if (string.IsNullOrEmpty(TPorcHora1.Text)) mensaje_error("El campo Porc. Hora 1 no puede estar vacio");
                if (string.IsNullOrEmpty(TPorcHora2.Text)) mensaje_error("El campo Porc. Hora 2 no puede estar vacio");

                HttpResponseMessage response = new HttpResponseMessage();
                switch (Accion_)
                {
                    case GlobalEnum._TipoAccion.Nuevo:
                        response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiParametro}Insert", new Parametros
                        {
                            RemBasico = ConvertForce.toDecimal(TRemuneracion.Text),
                            PorcAsigancionFamiliar = ConvertForce.toDecimal(TPorcAsignacion.Text),
                            PorcExtra1 = ConvertForce.toDecimal(TPorcHora1.Text),
                            PorcExtra2 = ConvertForce.toDecimal(TPorcHora2.Text),
                        });
                        break;
                    case GlobalEnum._TipoAccion.Modificar:
                        obj.RemBasico = ConvertForce.toDecimal(TRemuneracion.Text);
                        obj.PorcAsigancionFamiliar = ConvertForce.toDecimal(TPorcAsignacion.Text);
                        obj.PorcExtra1 = ConvertForce.toDecimal(TPorcHora1.Text);
                        obj.PorcExtra2 = ConvertForce.toDecimal(TPorcHora2.Text);
                        response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiParametro}Update", obj);
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
                           


                            CargarParametro();

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
