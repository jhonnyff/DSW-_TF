using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS;
using PLANILLA.UTILITARIOS.Request;
using PLANILLA.WEB.Data.Interfase;
using PLANILLA.WEB.Models;
using System;
using System.Net.Http;
using System.Text;
using static PLANILLA.UTILITARIOS.GlobalEnum;

namespace PLANILLA.WEB.Controllers
{
    public class TrabajadorController : Controller
    {
        public HttpClient _httpClient;
        Trabajadores objTrabajador = new Trabajadores();
        List<Cargos> ArrCargos = new List<Cargos>();
        List<SituacionTrabajador> ArrSituacion = new List<SituacionTrabajador>();
        List<TipoDocumentos> ArrTpoDocumento = new List<TipoDocumentos>();
        List<Generos> ArrGenero = new List<Generos>();
        List<EstadosCiviles> ArrEstadocivil = new List<EstadosCiviles>();
        List<SistemaPensiones> ArrSistemaPensiones = new List<SistemaPensiones>();

        public TrabajadorController()
        { 
            _httpClient = new HttpClient();
            
        }
        async Task CargarParametros()
        {
            try
            {
                HttpResponseMessage response = new HttpResponseMessage();
                response = await _httpClient.GetAsync($"{GlobalConstantes.ApiParametro}ParametrosFormularioTrabajador");
                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                using (HttpContent content = response.Content)
                {
                    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    {
                        case 200:
                            var objarr = JsonConvert.DeserializeObject<dynamic>(System.Convert.ToString(obj["data"]));
                            ArrCargos =             JsonConvert.DeserializeObject<List<Cargos>>             (System.Convert.ToString(objarr["cargos"]));
                            ArrSituacion =          JsonConvert.DeserializeObject<List<SituacionTrabajador>>(System.Convert.ToString(objarr["situaciones"]));
                            ArrTpoDocumento =       JsonConvert.DeserializeObject<List<TipoDocumentos>>     (System.Convert.ToString(objarr["tipoDocumentos"]));
                            ArrGenero =             JsonConvert.DeserializeObject<List<Generos>>            (System.Convert.ToString(objarr["generos"]));
                            ArrEstadocivil =        JsonConvert.DeserializeObject<List<EstadosCiviles>>     (System.Convert.ToString(objarr["estadosCiviles"]));
                            ArrSistemaPensiones =   JsonConvert.DeserializeObject<List<SistemaPensiones>>   (System.Convert.ToString(objarr["sistemaPensiones"]));

                            break;
                        case 500: throw new Exception(System.Convert.ToString(obj["message"]));

                    }
                }
            }
            catch (Exception ex)
            {
                throw; //mensaje_error(ex);
            }

        }
        public async Task<IActionResult> Index(string busqueda, int page = 1)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            BuquedaTrabajador objBusqueda = new BuquedaTrabajador();
            List<Trabajador> Lista = new List<Trabajador>();
            _httpClient = new HttpClient();
            try
            {
                Lista = await GetTrabajadores(busqueda);

                int totalRegistros = Lista.Count;
                int regisroPorPagina = 5;

                int totalPaginas = (int)Math.Ceiling((double)totalRegistros / regisroPorPagina);
                int omitir = (page - 1) * regisroPorPagina;
                ViewBag.totalPaginas = totalPaginas;

                return View(Lista.Skip(omitir).Take(regisroPorPagina));                
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IActionResult> Empleado()
        {
            await CargarParametros();
            ViewBag.h1 = "Registro de Trabajador";
            ViewBag.tipoDocumento = new SelectList( ArrTpoDocumento, "IdTipoDocumento", "Nombre");
            ViewBag.genero = new SelectList(ArrGenero, "IdGenero","Nombre");
            ViewBag.estCivil = new SelectList(ArrEstadocivil, "IdEstadoCivil", "Nombre");
            ViewBag.situacion = new SelectList(ArrSituacion, "IdSituacion", "Nombre");
            ViewBag.cargo = new SelectList(ArrCargos, "IdCargo", "Nombre");
            ViewBag.sistPension = new SelectList(ArrSistemaPensiones, "IdSistemaPension", "Nombre");

            return View(new Trabajador());
        }

        public async Task<IActionResult> EditarRegistro(string busqueda)
        {
            try
            {
                await CargarParametros();
                ViewBag.h1 = "Editar Trabajador";
                ViewBag.tipoDocumento = new SelectList(ArrTpoDocumento, "IdTipoDocumento", "Nombre");
                ViewBag.genero = new SelectList(ArrGenero, "IdGenero", "Nombre");
                ViewBag.estCivil = new SelectList(ArrEstadocivil, "IdEstadoCivil", "Nombre");
                ViewBag.situacion = new SelectList(ArrSituacion, "IdSituacion", "Nombre");
                ViewBag.cargo = new SelectList(ArrCargos, "IdCargo", "Nombre");
                ViewBag.sistPension = new SelectList(ArrSistemaPensiones, "IdSistemaPension", "Nombre");

                var Obj = await GetTrabajadores(busqueda);
                
                return View("Empleado", Obj.FirstOrDefault());
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<List<Trabajador>> GetTrabajadores(string busqueda)
        {
            HttpResponseMessage response = new HttpResponseMessage();            
            List<Trabajador> Lista = new List<Trabajador>();

            try
            {
                response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiTrabajador}BusquedaTrabajadores", new BuquedaTrabajador { Busqueda = busqueda, estado = GlobalEnum._Estado.Todos });
                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());
                using (HttpContent content = response.Content)
                {
                    var obj = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    switch (JsonConvert.DeserializeObject<int>(System.Convert.ToString(obj["status"])))
                    {
                        case 200:
                            Lista = JsonConvert.DeserializeObject<List<Trabajador>>(System.Convert.ToString(obj["data"]));

                            break;
                        case 500: throw new Exception(System.Convert.ToString(obj["message"]));
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        [HttpPost]
        public async Task<IActionResult> RegistroEmpleadoAsync(Trabajador newTrabajador)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                if (newTrabajador.IdTrabajador == 0)
                {
                    response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiTrabajador}Insert", newTrabajador);
                }
                else
                {
                    response = await _httpClient.PostAsJsonAsync($"{GlobalConstantes.ApiTrabajador}Update", newTrabajador);
                }

                if (!response.IsSuccessStatusCode) throw new Exception("Error: " + response.RequestMessage.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return RedirectToAction("Index");
        }
    }
}
