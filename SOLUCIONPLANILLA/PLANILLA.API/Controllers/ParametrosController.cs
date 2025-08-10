using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PLANILLA.API.Migraciones;
using PLANILLA.ENTIDADES;
using PROYECTO.UTILITARIOS;

namespace PLANILLA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParametrosController : ControllerBase
    {
        [HttpPost("Insert")]
        public IActionResult Insert(Parametros obj)
        {
            try
            {
                var res = new ParametrosLog().Insert(obj);
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
        public IActionResult Update(Parametros obj)
        {
            try
            {
                var res = new ParametrosLog().Update(obj);
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
                var res = new ParametrosLog().CambiarEstado(id);
                var respuesta = new ToReturn<int>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<int>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpGet("BusquedaParametros")]
        public IActionResult BusquedaParametros()
        {
            try
            {
                var res = new ParametrosLog().Busqueda();
                var respuesta = new ToReturnList<Parametros>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<Parametros>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpGet("BusquedaOne")]
        public IActionResult BusquedaOne()
        {
            try
            {
                var res = new ParametrosLog().BusquedaOne();
                var respuesta = new ToReturn<Parametros>(res);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<Parametros>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }


        }
        [HttpGet("ParametrosFormularioTrabajador")]
        public IActionResult ParametrosFormularioTrabajador()
        {
            try
            {
                var cargosLis = new CargoLog().Busqueda(UTILITARIOS.GlobalEnum._Estado.Activo);
                var SituacionesLis = new SituacionTrabajadorLog().Busqueda(UTILITARIOS.GlobalEnum._Estado.Activo);
                var TipodocumentoList = new TipoDocumentolog().Busqueda(UTILITARIOS.GlobalEnum._Estado.Activo);
                var GenerosList = new GeneroLog().Busqueda(UTILITARIOS.GlobalEnum._Estado.Activo);
                var estadoscivileslist = new EstadoCivilLog().Busqueda(UTILITARIOS.GlobalEnum._Estado.Activo);
                var SistemaPensionesLis = new SistemaPensionLog().Busqueda(UTILITARIOS.GlobalEnum._Estado.Activo);


                var arr = new
                {
                    TipoDocumentos = TipodocumentoList,
                    Generos = GenerosList,
                    EstadosCiviles = estadoscivileslist,
                    situaciones = SituacionesLis,
                    cargos = cargosLis,
                    SistemaPensiones = SistemaPensionesLis
                };

                var respuesta = new ToReturn<object>(arr);
                return StatusCode(respuesta.Status, respuesta);
            }
            catch (Exception ex)
            {
                var error = new ToReturnError<Parametros>($"{ex.Message} {ex.InnerException}");
                return StatusCode(error.Status, error);
            }
        }
    }
}
