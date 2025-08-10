using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PLANILLA.API.Migraciones;
using PLANILLA.ENTIDADES;
using PROYECTO.UTILITARIOS;

namespace PLANILLA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDocumentoController : ControllerBase
    {
        [HttpPost("Insert")]
        public IActionResult Insert(TipoDocumentos obj)
        {
            try
            {
                var res = new TipoDocumentolog().Insert(obj);
                var respuesta = new ToReturn<int>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<int>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpPost("Update")]
        public IActionResult Update(TipoDocumentos obj)
        {
            try
            {
                var res = new TipoDocumentolog().Update(obj);
                var respuesta = new ToReturn<int>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<int>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpGet("CambiarEstado")]
        public IActionResult CambiarEstado(int id)
        {
            try
            {
                var res = new TipoDocumentolog().CambiarEstado(id);
                var respuesta = new ToReturn<int>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<int>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpGet("BusquedaTipoDocumento")]
        public IActionResult BusquedaCargos()
        {
            try
            {
                var res = new TipoDocumentolog().Busqueda();
                var respuesta = new ToReturnList<TipoDocumentos>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<TipoDocumentos>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
    }
}
