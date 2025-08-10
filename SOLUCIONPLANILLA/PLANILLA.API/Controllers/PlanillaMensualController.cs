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
    public class PlanillaMensualController : ControllerBase
    {
        [HttpPost("CalcularPlanillaByPeriodo")]
        public IActionResult CalcularPlanillaByPeriodo(BusquedaByPeriodo obj) {
            try
            {
                var res = new PlanillaMensualLog().CalcularPlanillaByPeriodo(obj.año,obj.mes);
                var respuesta = new ToReturnList<PlanillaMensual>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<PlanillaMensual>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }
        
        }
        [HttpPost("InsertLista")]
        public IActionResult InsertLista(List<PlanillaMensual> arr)
        {
            try
            {
                var res = new PlanillaMensualLog().InsertarLista(arr);
                var respuesta = new ToReturn<bool>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<int>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpPost("BuscarListaBoletasByPeriodo")]
        public IActionResult BuscarListaBoletasByPeriodo(BusquedaByPeriodo obj)
        {
            try
            {
                var res = new PlanillaMensualLog().Lista(obj.año, obj.mes);
                var respuesta = new ToReturnList<PlanillaMensual>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<AsistenciaTrabajadorResponse>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpPost("BuscarBoletas")]
        public IActionResult BuscarBoletas(BusquedaBoleta obj)
        {
            try
            {
                var res = new PlanillaMensualLog().BuscarBoleta(obj);
                var respuesta = new ToReturn<string>(res);
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
