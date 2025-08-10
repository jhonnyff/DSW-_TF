using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using OpenHtmlToPdf;
using System.IO;
using iText.Html2pdf;

namespace WebConsulta.Pages
{
    public class IndexModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public IndexModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [BindProperty]
        public int Year { get; set; }

        [BindProperty]
        public int Month { get; set; }

        [BindProperty]
        public string DocumentNumber { get; set; }
        [BindProperty]
        public string HtmlContent { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var data = new
            {
                año = Year,
                mes = Month,
                documento = DocumentNumber
            };

          
            try
            {
                var response = await _httpClient.PostAsJsonAsync("https://localhost:7096/api/PlanillaMensual/BuscarBoletas", data);

                if (response.IsSuccessStatusCode)
                {
                    //using (HttpContent content = response.Content)
                    //{
                    //    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    //    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    //    {
                    //        case 200:
                    //            HtmlContent = JsonConvert.DeserializeObject<string>(Convert.ToString( obj["data"]));


                    //            break;
                    //        case 500: throw new Exception(System.Convert.ToString(obj["message"]));

                    //    }
                    //}


                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    // Parsear la respuesta JSON
                    var apiResponse = System.Text.Json.JsonDocument.Parse(jsonResponse);

                    // Extraer el contenido HTML de la propiedad "data"
                    HtmlContent = apiResponse.RootElement.GetProperty("data").GetString();
                }
                else
                {
                    HtmlContent = "Error en la consulta de la API";
                }
            }
            catch (Exception ex)
            {
                HtmlContent = $"Error: {ex.Message}";
            }

            return Page();
        }


        public IActionResult OnPostDownloadPdf()
        {
            if (!string.IsNullOrEmpty(HtmlContent))
            {
                var pdfBytes = ConvertHtmlToPdfBytes(HtmlContent);

                // Establecer el nombre del archivo
                var fileName = "boleta_pago.pdf";

                // Devolver el archivo PDF
                return File(pdfBytes, "application/pdf", fileName);
            }

            return Page();
        }
        private byte[] ConvertHtmlToPdfBytes(string htmlContent)
        {
            // Crear un MemoryStream para almacenar el PDF
            using (var memoryStream = new MemoryStream())
            {
                // Convertir el HTML a PDF con iTextSharp HtmlConverter
                HtmlConverter.ConvertToPdf(htmlContent, memoryStream);

                // Devolver el PDF como un array de bytes
                return memoryStream.ToArray();
            }
        }
        //private byte[] HtmlToPdfConvert(string htmlContent)
        //{
        //    // Convertimos el HTML a PDF con OpenHtmlToPdf
        //    var pdfDocument = Pdf
        //              .From(htmlContent)
        //              .WithGlobalSetting("encoding", "UTF-8") // Establecer la codificación UTF-8
        //              .Content();

        //    // Convertimos el documento PDF en un array de bytes
        //    using (var memoryStream = new MemoryStream())
        //    {
        //       pdfDocument.SaveAs(memoryStream); // Guardar el PDF en el MemoryStream
        //        return memoryStream.ToArray(); // Convertir el MemoryStream a byte[]
        //    }
        //}
    }
}
