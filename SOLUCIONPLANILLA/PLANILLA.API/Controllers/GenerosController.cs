using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PLANILLA.API.Migraciones;
using PLANILLA.ENTIDADES;
using PROYECTO.UTILITARIOS;

namespace PLANILLA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        [HttpPost("Insert")]
        public IActionResult Insert(Generos obj)
        {
            try
            {
                var res = new GeneroLog().Insert(obj);
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
        public IActionResult Update(Generos obj)
        {
            try
            {
                var res = new GeneroLog().Update(obj);
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
                var res = new GeneroLog().CambiarEstado(id);
                var respuesta = new ToReturn<int>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<int>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpGet("BusquedaGeneros")]
        public IActionResult BusquedaCargos()
        {
            try
            {
                var res = new GeneroLog().Busqueda();
                var respuesta = new ToReturnList<Generos>(res);
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
