using Newtonsoft.Json;
using OfficeOpenXml;
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
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarios.WindowsControls;

namespace PLANILLA.ESCRITORIO.Formularios.Planilla
{
    public partial class FrmCargaAsistencia : FrmBase
    {
        List<AsistenciaTrabajadorResponse> ArrAsistencia = new List<AsistenciaTrabajadorResponse>();
        public FrmCargaAsistencia()
        {
            InitializeComponent();
        }

        private void FrmCargaAsistencia_Load(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        private void Descarga_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Hoja1");

                    // Asigna los nombres de las columnas en la primera fila
                    worksheet.Cells[1, 1].Value = "Dni";
                    worksheet.Cells[1, 2].Value = "DiasLaborales";
                    worksheet.Cells[1, 3].Value = "DiasDescanso";
                    worksheet.Cells[1, 4].Value = "DiasInasistencia";
                    worksheet.Cells[1, 5].Value = "DiasFeriados";
                    worksheet.Cells[1, 6].Value = "HorasExtra25";
                    worksheet.Cells[1, 7].Value = "HorasExtra35";

                    // Escribe los datos desde el DataGridView al archivo Excel
                    for (int i = 0; i < DgInasitencias.Rows.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = DgInasitencias.Rows[i].Cells[0].Value;
                        worksheet.Cells[i + 2, 2].Value = DgInasitencias.Rows[i].Cells[1].Value;
                        worksheet.Cells[i + 2, 3].Value = DgInasitencias.Rows[i].Cells[2].Value;
                        worksheet.Cells[i + 2, 4].Value = DgInasitencias.Rows[i].Cells[3].Value;
                        worksheet.Cells[i + 2, 5].Value = DgInasitencias.Rows[i].Cells[4].Value;
                        worksheet.Cells[i + 2, 6].Value = DgInasitencias.Rows[i].Cells[5].Value;
                        worksheet.Cells[i + 2, 7].Value = DgInasitencias.Rows[i].Cells[6].Value;
                    }

                    // Guarda el archivo Excel
                    using (var saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                        saveFileDialog.FilterIndex = 2;
                        saveFileDialog.RestoreDirectory = true;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo fi = new FileInfo(saveFileDialog.FileName);
                            package.SaveAs(fi);
                            mensaje_Informativo("Exito!!!", "Exportación completada");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                mensaje_error(ex);
            }
        }

        private void BtCarga_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var filePath = openFileDialog.FileName;

                        using (var package = new ExcelPackage(new FileInfo(filePath)))
                        {
                            var worksheet = package.Workbook.Worksheets[0];

                            // Limpia el DataGridView antes de importar
                            DgInasitencias.Rows.Clear();

                            // Lee los datos del archivo Excel
                            int rowCount = worksheet.Dimension.Rows;
                            for (int row = 2; row <= rowCount; row++)  // Saltar la fila de encabezados
                            {
                                string dni = (worksheet.Cells[row, 1].Value.ToString());

                                if (ArrAsistencia.Select(r => r.Documento.Trim()).Contains(dni.Trim()))
                                {
                                    int diasLaborales = int.Parse(worksheet.Cells[row, 2].Value.ToString());
                                    int diasDescanso = int.Parse(worksheet.Cells[row, 3].Value.ToString());
                                    int diasInasistencia = int.Parse(worksheet.Cells[row, 4].Value.ToString());
                                    int diasFeriados = int.Parse(worksheet.Cells[row, 5].Value.ToString());
                                    decimal horasExtra25 = decimal.Parse(worksheet.Cells[row, 6].Value.ToString());
                                    decimal horasExtra35 = decimal.Parse(worksheet.Cells[row, 7].Value.ToString());

                                    DgInasitencias.Rows.Add(dni, diasLaborales, diasDescanso, diasInasistencia, diasFeriados, horasExtra25, horasExtra35);

                                }

                            }

                            mensaje_Informativo("Exito!!!!!!", "Importación completada");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {

                    DgInasitencias.Rows.Clear();
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiAsistenciaTrabajador}BusquedaAsistenciaByPeriodo", new BusquedaByPeriodo { año = ConvertForce.toInt(CbAño.SelectedValue), mes = ConvertForce.toInt(CbMes.SelectedValue) });
                    if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                    using (HttpContent content = response.Content)
                    {
                        var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                        switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                        {
                            case 200:
                                ArrAsistencia = JsonConvert.DeserializeObject<List<AsistenciaTrabajadorResponse>>(System.Convert.ToString(obj["data"]));

                                if (ArrAsistencia != null && ArrAsistencia.Any())
                                {
                                    ArrAsistencia.OrderByDescending(r => r.Nombre).ToList().ForEach(list =>
                                    {
                                        DgInasitencias.Rows[DgInasitencias.Rows.Add(
                                            list.Documento, list.DiasLaborales, list.DiasDescanso, list.DiasInasistencia, list.DiasFeriados, list.HorasExtra25, list.HorasExtra35
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

        private async void BGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                List<AsistenciasTrabajadores> arr = new List<AsistenciasTrabajadores>();
                DgInasitencias.Rows.Cast<DataGridViewRow>().ToList().ForEach(c =>
                {
                    if (ArrAsistencia.Select(r => r.Documento.Trim()).Contains(c.Cells[0].Value.ToString().Trim()))
                    {
                        arr.Add(new AsistenciasTrabajadores
                        {
                            Año = ConvertForce.toInt(CbAño.SelectedValue),
                            Mes = ConvertForce.toInt(CbMes.SelectedValue),
                            IdTrabajador = ArrAsistencia.FirstOrDefault(r => r.Documento.Trim() == c.Cells[0].Value.ToString().Trim()).IdTrabajador,
                            DiasLaborales = ConvertForce.toInt(c.Cells[1].Value),
                            DiasDescanso = ConvertForce.toInt(c.Cells[2].Value),
                            DiasInasistencia = ConvertForce.toInt(c.Cells[3].Value),
                            DiasFeriados = ConvertForce.toInt(c.Cells[4].Value),
                            HorasExtra25 = ConvertForce.toDecimal(c.Cells[5].Value),
                            HorasExtra35 = ConvertForce.toDecimal(c.Cells[6].Value),


                        });
                    }
                });
                if (arr.Any())
                {

                    HttpResponseMessage response = new HttpResponseMessage();

                    response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiAsistenciaTrabajador}InsertLista", arr);

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
                            }
            catch (Exception ex)
            {
                mensaje_error(ex);
            }
        }
    }
}
