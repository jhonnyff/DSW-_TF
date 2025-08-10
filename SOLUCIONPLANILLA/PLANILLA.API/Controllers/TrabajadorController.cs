using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PLANILLA.API.Migraciones;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS.Request;
using PROYECTO.UTILITARIOS;

namespace PLANILLA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadorController : ControllerBase
    {
        [HttpPost("Insert")]
        public IActionResult Insert(Trabajadores obj)
        {
            try
            {
                var res = new TrabajadorLog().Insert(obj);
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
        public IActionResult Update(Trabajadores obj)
        {
            try
            {
                var res = new TrabajadorLog().Update(obj);
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
                var res = new TrabajadorLog().CambiarEstado(id);
                var respuesta = new ToReturn<int>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<int>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpPost("BusquedaTrabajadores")]
        public IActionResult BusquedaCargos(BuquedaTrabajador obj)
        {
            try
            {
                var res = new TrabajadorLog().Busqueda(obj);
                var respuesta = new ToReturnList<Trabajadores>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<Cargos>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
    }
}
