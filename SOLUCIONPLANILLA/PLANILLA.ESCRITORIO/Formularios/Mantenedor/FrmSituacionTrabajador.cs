using Newtonsoft.Json;
using PLANILLA.ENTIDADES;
using PLANILLA.ESCRITORIO.Componentes;
using PLANILLA.UTILITARIOS;
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

namespace PLANILLA.ESCRITORIO.Formularios.Mantenedor
{
    public partial class FrmSituacionTrabajador : FrmBase
    {
        public FrmSituacionTrabajador()
        {
            InitializeComponent();
        }
        SituacionTrabajador obj = new SituacionTrabajador();
        async void llenardatagrid()
        {
            try
            {
                Dg1.Rows.Clear();
                HttpResponseMessage response = new HttpResponseMessage();
                response = await _httpClient.GetAsync($"{GlobalConstantes.ApiSituacionTrabajador}BusquedaSituacionTrabajador");
                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                using (HttpContent content = response.Content)
                {
                    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    {
                        case 200:
                            List<SituacionTrabajador> Lista = JsonConvert.DeserializeObject<List<SituacionTrabajador>>(System.Convert.ToString(obj["data"]));

                            if (Lista != null && Lista.Any())
                            {
                                Lista.OrderByDescending(r => r.Activo).ThenBy(r => r.Nombre).ToList().ForEach(list =>
                                {
                                    Dg1.Rows[Dg1.Rows.Add(
                                        list.IdSituacion, list.Nombre, list.Activo, list.FecCreacion
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

        private void Dg1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right && Dg1.CurrentCell != null)
                {
                    if (Dg1.CurrentCell.ColumnIndex != 0)
                    {
                        if (Dg1.SelectedCells.Count != 0)
                        {
                            SituacionTrabajador obj = Dg1.SelectedRows[0].Tag as SituacionTrabajador;
                            if (obj != null)
                            {
                                estadoToolStripMenuItem.Text = (bool)obj.Activo ? "Desactivar" : "Activar";

                            }


                            MenuStrip.Show(Dg1, new System.Drawing.Point(e.X, e.Y));
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        private void FrmSituacionTrabajador_Load(object sender, EventArgs e)
        {
            try
            {
                llenardatagrid();
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                obj = Dg1.SelectedRows[0].Tag as SituacionTrabajador;
                if (obj != null)
                {
                    Tnombre.Text = obj.Nombre;
                    Accion_ = GlobalEnum._TipoAccion.Modificar;
                }
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        private async void estadoToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                obj = Dg1.SelectedRows[0].Tag as SituacionTrabajador;
                if (obj != null)
                {
                    HttpResponseMessage response = new HttpResponseMessage();

                    response = await _httpClient.GetAsync($"{GlobalConstantes.ApiSituacionTrabajador}CambiarEstado?id={obj.IdSituacion}");

                    if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                    using (HttpContent content = response.Content)
                    {
                        var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                        switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                        {
                            case 200:

                                mensaje_Actualizado();

                                obj = null;
                                Tnombre.Clear();


                                llenardatagrid();

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

        private void BNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                obj = null;
                Accion_ = GlobalEnum._TipoAccion.Nuevo;
                Tnombre.Clear();
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
                if (string.IsNullOrEmpty(Tnombre.Text)) mensaje_error("El campo Nombre no puede estar vacio");

                HttpResponseMessage response = new HttpResponseMessage();
                switch (Accion_)
                {
                    case GlobalEnum._TipoAccion.Nuevo:
                        response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiSituacionTrabajador}Insert", new SituacionTrabajador { Nombre = Tnombre.Text });
                        break;
                    case GlobalEnum._TipoAccion.Modificar:
                        obj.Nombre = Tnombre.Text;
                        response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiSituacionTrabajador}Update", obj);
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
                            Tnombre.Clear();


                            llenardatagrid();

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
