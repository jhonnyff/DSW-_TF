using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PLANILLA.API.Migraciones;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS.Request;
using PLANILLA.UTILITARIOS.Response;
using PROYECTO.UTILITARIOS;

namespace PLANILLA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsistenciaTrabajadorController : ControllerBase
    {
        [HttpPost("InsertLista")]
        public IActionResult InsertLista(List<AsistenciasTrabajadores> arr)
        {
            try
            {
                var res = new AsistenciaTrabajadorLog().InsertarLista(arr);
                var respuesta = new ToReturn<bool>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<int>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpPost("BusquedaAsistenciaByPeriodo")]
        public IActionResult BusquedaAsistenciaByPeriodo(BusquedaByPeriodo obj)
        {
            try
            {
                var res = new AsistenciaTrabajadorLog().BuscarAsistenciaByPeriodo(obj.año,obj.mes);
                var respuesta = new ToReturnList<AsistenciaTrabajadorResponse>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<AsistenciaTrabajadorResponse>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
    }
}
