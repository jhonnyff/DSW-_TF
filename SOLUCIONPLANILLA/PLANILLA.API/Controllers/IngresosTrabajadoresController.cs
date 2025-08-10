using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PLANILLA.API.Migraciones;
using PLANILLA.ENTIDADES;
using PROYECTO.UTILITARIOS;

namespace PLANILLA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresosTrabajadoresController : ControllerBase
    {
        [HttpPost("Insert")]
        public IActionResult Insert(IngresosTrabajadores obj)
        {
            try
            {
                var res = new IngresosTrabajadoresLog().Insert(obj);
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
        public IActionResult Update(IngresosTrabajadores obj)
        {
            try
            {
                var res = new IngresosTrabajadoresLog().Update(obj);
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
                var res = new IngresosTrabajadoresLog().CambiarEstado(id);
                var respuesta = new ToReturn<int>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<int>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpGet("BusquedaIngresosTrabajadores")]
        public IActionResult BusquedaIngresosTrabajadores()
        {
            try
            {
                var res = new IngresosTrabajadoresLog().Busqueda();
                var respuesta = new ToReturnList<IngresosTrabajadores>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<IngresosTrabajadores>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpGet("BusquedaOne")]
        public IActionResult BusquedaOne(int id)
        {
            try
            {
                var res = new IngresosTrabajadoresLog().BusquedaOne(id);
                var respuesta = new ToReturn<IngresosTrabajadores>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<IngresosTrabajadores>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        
    }
}
