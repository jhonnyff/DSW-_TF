using Microsoft.AspNetCore.Mvc;
using PLANILLA.API.Migraciones;
using PLANILLA.ENTIDADES;
using PROYECTO.UTILITARIOS;


namespace PLANILLA.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CargosController : ControllerBase
    {
        [HttpPost("Insert")]
        public  IActionResult Insert(Cargos obj)
        {
            try
            {
                var res =  new CargoLog().Insert(obj);
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
        public IActionResult Update(Cargos obj)
        {
            try
            {
                var res = new CargoLog().Update(obj);
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
                var res = new CargoLog().CambiarEstado(id);
                var respuesta = new ToReturn<int>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<int>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpGet("BusquedaCargos")]
        public IActionResult BusquedaCargos()
        {
            try
            {
                var res = new CargoLog().Busqueda();
                var respuesta = new ToReturnList<Cargos>(res);
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
