using PLANILLA.CONEXION;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS;
using PLANILLA.UTILITARIOS.Request;
using System.Numerics;
using static PLANILLA.UTILITARIOS.GlobalEnum;

namespace PLANILLA.API.Migraciones
{
    public class PlanillaMensualLog
    {
        public List<PlanillaMensual> CalcularPlanillaByPeriodo(int año, int mes)
        {
            List<PlanillaMensual> arr = new List<PlanillaMensual>();
            var parametro = new ParametrosLog().BusquedaOne();
            var Arrtrabajador = new TrabajadorLog().Busqueda(new UTILITARIOS.Request.BuquedaTrabajador { Busqueda = "", estado = UTILITARIOS.GlobalEnum._Estado.Activo });
            var ArrIngresos = new IngresosTrabajadoresLog().Busqueda();
            var ArrAsistencia = new AsistenciaTrabajadorLog().BuscarAsistenciaByPeriodo(año, mes);
            var ArrSistemaPension = new SistemaPensionLog().Busqueda();
            int diasMes = DateTime.DaysInMonth(año, mes);
            foreach (var ItemTrabajador in Arrtrabajador)
            {



                PlanillaMensual obj = new PlanillaMensual();
                var itemAsistencia = ArrAsistencia.FirstOrDefault(r => r.IdTrabajador == ItemTrabajador.IdTrabajador);
                var itemIngreso = ArrIngresos.FirstOrDefault(r => r.IdTrabajador == ItemTrabajador.IdTrabajador);
                int diascalculo = (int)itemAsistencia.DiasLaborales + (int)itemAsistencia.DiasDescanso;


                obj.Año = año;
                obj.Mes = mes;
                obj.IdTrabajador = ItemTrabajador.IdTrabajador;
                obj.IdSituacion = ItemTrabajador.IdSituacion;
                obj.IdCargo = ItemTrabajador.IdCargo;
                obj.Apellido = $"{ItemTrabajador.ApellidoPaterno} {ItemTrabajador.ApellidoMaterno}";
                obj.Nombre = ItemTrabajador.Nombres;
                obj.IdSistemaPension = ItemTrabajador.IdSistemaPension;
                obj.IdEstadoCivil = ItemTrabajador.IdEstadoCivil;
                obj.Hijos = (short)ItemTrabajador.Hijos;
                obj.FechaIngreso = ItemTrabajador.FecIngreso;
                obj.SueldoBasico = itemIngreso?.Remuneracion;
                obj.PorcHoraExtra1 = parametro.PorcExtra1;
                obj.PorcHoraExtra2 = parametro.PorcExtra2;
                obj.PorcDescansoTrab = 2;
                obj.PorcFeriadoTrab = 2;
                obj.PorcAsigFamiliar = parametro.PorcAsigancionFamiliar;
                obj.nHorasNormal = itemAsistencia.DiasLaborales * 8;
                obj.nHorasExtra1 = itemAsistencia.HorasExtra25;
                obj.nHorasExtra2 = itemAsistencia.HorasExtra35;
                obj.nDiasTrab = (short)itemAsistencia.DiasLaborales;
                obj.nDiasDescansos = (short)itemAsistencia.DiasDescanso;
                obj.nFeriadosTrab = (short)itemAsistencia.DiasFeriados;
                obj.nDescansosTrab = 0;
                obj.nDiasInasistencias = (short)itemAsistencia.DiasInasistencia;
                obj.HaberBasico =Math.Round( ((decimal)itemIngreso?.Remuneracion / diasMes) * diascalculo,2,MidpointRounding.AwayFromZero);
                obj.ValesEmpleado = Math.Round(((decimal)itemIngreso?.Vale / diasMes) * diascalculo, 2, MidpointRounding.AwayFromZero);
                decimal valorhora = (decimal)obj.SueldoBasico / 30 / 8;
                obj.vHorasExtra1 = Math.Round((valorhora * (1 + (decimal)obj.PorcHoraExtra1)) * (decimal)obj.nHorasExtra1, 2, MidpointRounding.AwayFromZero);
                obj.vHorasExtra2 = Math.Round((valorhora * (1 + (decimal)obj.PorcHoraExtra2)) * (decimal)obj.nHorasExtra2, 2, MidpointRounding.AwayFromZero);
                obj.vAsigFamiliar =ItemTrabajador.Hijos==0?0: Math.Round((decimal)obj.SueldoBasico * (decimal)obj.PorcAsigFamiliar, 2, MidpointRounding.AwayFromZero);
                obj.vDescansoTrab = 0;
                obj.vFeriadoTrab = Math.Round((valorhora * 8) * (decimal)obj.PorcFeriadoTrab, 2, MidpointRounding.AwayFromZero);
                obj.BonificacionCargo = Math.Round(((decimal)itemIngreso?.Vale / diasMes) * diascalculo, 2, MidpointRounding.AwayFromZero);
                obj.BonificacionMovilidad = 0;
                obj.CanastaNavidad = 0;
                obj.Escolaridad = 0;
                obj.DiaTrabajador = 0;
                obj.TotalIngreso = Math.Round((decimal)obj.HaberBasico + (decimal)obj.ValesEmpleado + (decimal)obj.vHorasExtra1 + (decimal)obj.vHorasExtra2 + (decimal)obj.vAsigFamiliar +
                                   (decimal)obj.vDescansoTrab + (decimal)obj.vFeriadoTrab + (decimal)obj.BonificacionCargo + (decimal)obj.BonificacionMovilidad + (decimal)obj.CanastaNavidad +
                                   (decimal)obj.Escolaridad + (decimal)obj.DiaTrabajador, 2, MidpointRounding.AwayFromZero);
                var itemsistemapension = ArrSistemaPension.FirstOrDefault(r => r.IdSistemaPension == ItemTrabajador.IdSistemaPension);
                obj.PorcAporte = itemsistemapension.Aporte;
                obj.Aporte = Math.Round((decimal)obj.TotalIngreso * ((decimal)obj.PorcAporte / 100), 2, MidpointRounding.AwayFromZero);
                obj.PorcComision = itemsistemapension.Comision;
                obj.Comision = Math.Round((decimal)obj.TotalIngreso * ((decimal)obj.PorcComision / 100), 2, MidpointRounding.AwayFromZero);
                obj.PorcPrima = itemsistemapension.Prima;
                obj.Prima = Math.Round((decimal)obj.TotalIngreso * ((decimal)obj.PorcPrima / 100), 2, MidpointRounding.AwayFromZero);
                obj.TotalDescuento = Math.Round((decimal)obj.Aporte + (decimal)obj.Comision + (decimal)obj.Prima, 2, MidpointRounding.AwayFromZero);
                obj.TotalNetoBoleta= Math.Round((decimal)obj.TotalIngreso- (decimal)obj.TotalDescuento, 2, MidpointRounding.AwayFromZero);
                obj.TotalNetoBoletaCad = NumberToLetters.ToCardinal((decimal)obj.TotalNetoBoleta) + " SOLES";
                arr.Add(obj);
            }


            return arr;



        }

        public bool InsertarLista(List<PlanillaMensual> arr)
        {
            foreach (var item in arr)
            {
                new _AuditoriaLog().SetAuditFieldsForInsert(item);
            }
            DapperSQL.Execute_Bool(" delete PlanillaMensual where Año=@Año and Mes=@Mes;", arr[0]);


            string cadena = $@"
                              
                               INSERT INTO PlanillaMensual
                                          (Año,Mes,IdTrabajador,IdSituacion,IdCargo,Apellido,Nombre,IdSistemaPension,IdEstadoCivil
                                            ,Hijos,FechaIngreso,SueldoBasico,PorcHoraExtra1,PorcHoraExtra2,PorcDescansoTrab,PorcFeriadoTrab,PorcAsigFamiliar,nHorasNormal
                                            ,nHorasExtra1,nHorasExtra2,nDiasTrab,nDiasDescansos,nFeriadosTrab,nDescansosTrab,nDiasInasistencias,HaberBasico,ValesEmpleado
                                            ,vHorasExtra1,vHorasExtra2,vAsigFamiliar,vDescansoTrab,vFeriadoTrab,BonificacionCargo,BonificacionMovilidad,CanastaNavidad,Escolaridad
                                            ,DiaTrabajador,TotalIngreso,Renta5ta,DescuentoJud1,DescuentoJud2,DescuentoJud3,OtrosAdelantos,AdelantoCaja,AdelantoQuincena
                                            ,AdelantoVac,AdelantoGratificacion,AdelantoLiquidacion,AdelantoCTS,PorcAporte,Aporte,PorcComision,Comision,PorcPrima
                                            ,Prima,OTDSeg,OTDPacifico,IdBanco1,Prestamo1,Tardanza,TotalDescuento,PorcEsSalud,EsSalud
                                            ,AccidenteTrab,Senati,SeguroVidaLey,TotalNeto,TotalNetoCad,TotalNetoBoleta,TotalNetoBoletaCad{GlobalConstantes.AuditoriaInsertColumna})
                                    VALUES
                                          (@Año,@Mes,@IdTrabajador,@IdSituacion,@IdCargo,@Apellido,@Nombre,@IdSistemaPension,@IdEstadoCivil
                                            ,@Hijos,@FechaIngreso,@SueldoBasico,@PorcHoraExtra1,@PorcHoraExtra2,@PorcDescansoTrab,@PorcFeriadoTrab,@PorcAsigFamiliar,@nHorasNormal
                                            ,@nHorasExtra1,@nHorasExtra2,@nDiasTrab,@nDiasDescansos,@nFeriadosTrab,@nDescansosTrab,@nDiasInasistencias,@HaberBasico,@ValesEmpleado
                                            ,@vHorasExtra1,@vHorasExtra2,@vAsigFamiliar,@vDescansoTrab,@vFeriadoTrab,@BonificacionCargo,@BonificacionMovilidad,@CanastaNavidad,@Escolaridad
                                            ,@DiaTrabajador,@TotalIngreso,@Renta5ta,@DescuentoJud1,@DescuentoJud2,@DescuentoJud3,@OtrosAdelantos,@AdelantoCaja,@AdelantoQuincena
                                            ,@AdelantoVac,@AdelantoGratificacion,@AdelantoLiquidacion,@AdelantoCTS,@PorcAporte,@Aporte,@PorcComision,@Comision,@PorcPrima
                                            ,@Prima,@OTDSeg,@OTDPacifico,@IdBanco1,@Prestamo1,@Tardanza,@TotalDescuento,@PorcEsSalud,@EsSalud
                                            ,@AccidenteTrab,@Senati,@SeguroVidaLey,@TotalNeto,@TotalNetoCad,@TotalNetoBoleta,@TotalNetoBoletaCad{GlobalConstantes.AuditoriaInsertValues})";
            return DapperSQL.InsertarLista(cadena, arr);

        }

        public List<PlanillaMensual> Lista(int año, int mes) {
            string cadena = $@"Select * from PlanillaMensual where año={año} and mes={mes}";
            return DapperSQL.Lista<PlanillaMensual>(cadena);

        }

        public string BuscarBoleta(BusquedaBoleta objboleta) {
            string cadena = $@" select * from planillamensual where año={objboleta.año} and mes={objboleta.mes} and idtrabajador in (select idtrabajador from trabajadores where documento='{objboleta.Documento}')";
            var obj = DapperSQL.Objeto<PlanillaMensual>(cadena);
            Trabajadores objtrabajadores = new TrabajadorLog().Busqueda(new BuquedaTrabajador()).FirstOrDefault(r => r.IdTrabajador == obj.IdTrabajador);
            Cargos objCargos = new CargoLog().Busqueda().FirstOrDefault(r => r.IdCargo == obj.IdCargo);
            SituacionTrabajador ObjSituacion = new SituacionTrabajadorLog().Busqueda().FirstOrDefault(r => r.IdSituacion == obj.IdSituacion);
            TipoDocumentos objTpoDocumento = new TipoDocumentolog().Busqueda().FirstOrDefault(r => r.IdTipoDocumento == objtrabajadores.IdTipoDocumento);
            SistemaPensiones objSistemaPensiones = new SistemaPensionLog().Busqueda().FirstOrDefault(r => r.IdSistemaPension == obj.IdSistemaPension);
            // Aquí debes personalizar los datos dinámicos (puedes usar datos de tu base de datos)
            string html = @"
            <!DOCTYPE html>
            <html lang='es'>
            <head>
                <meta charset='UTF-8'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <title>Boleta de Pago</title>
                <style>
                    body { font-family: Arial, sans-serif; margin: 0; padding: 0; }
                    .boleta { width: 800px; margin: 0 auto; padding: 20px; border: 1px solid #ccc; }
                    header { display: flex; justify-content: space-between; align-items: center; border-bottom: 2px solid #000; padding-bottom: 10px; }
                    header h1 { font-size: 24px; color: #0046ad; }
                    header h1 span { color: orange; }
                    .empresa-logo img { width: 150px; height: auto; }
                    .trabajador-info, .detalles, .resumen { margin-top: 20px; }
                    .detalles { display: flex; justify-content: space-between; }
                    .detalles div { width: 30%; }
                    .detalles table { width: 100%; border-collapse: collapse; }
                    .detalles table td { padding: 5px; border-bottom: 1px solid #ccc; }
                    footer { text-align: center; margin-top: 30px; }
                </style>
            </head>" +
$@"
            <body>
                <div class='boleta'>
                    <header>
                        <div class='empresa-info'>
                            <h1>BOLETA DE PAGO <span>ENERO DEL 2024</span></h1>
                            <p><strong>Razón Social:</strong> Nombre Empresa Contratada</p>
                            <p><strong>Dirección:</strong> Direccion Empresa Contratada</p>
                            <p><strong>NIT:</strong> 25263987456 &nbsp; <strong>Reg. Patronal:</strong> 070710-00156</p>
                        </div>
                        <div class='empresa-logo'>
                            <img src='logo.png' alt='Logo de la Empresa'>
                            <p>D.S. N° 001-98-TR del 22/01/1998</p>
                        </div>
                    </header>

                    <section class='trabajador-info'>
                        <h2>Trabajador</h2>
                        <p><strong>Trabajador:</strong> {objtrabajadores.Documento} {objtrabajadores.Nombres} {objtrabajadores.ApellidoPaterno} {objtrabajadores.ApellidoMaterno}</p>
                        <p><strong>Fecha Ingreso:</strong> {objtrabajadores.FecIngreso.ToString("dd/MM/yyyy")}</p>
                        <p><strong>Cargo:</strong>{objCargos.Nombre}</p>
                        <p><strong>AFP/ONP:</strong> {objSistemaPensiones.Nombre} &nbsp; <strong>Código SPP:</strong> 652940CABEÑ3</p>
                        <p><strong>Días Trab.:</strong> {obj.nDiasTrab} &nbsp; <strong>Horas:</strong> {obj.nHorasNormal}</p>
                    </section>

                    <section class='detalles'>
                        <div class='ingresos'>
                            <h3>Ingresos</h3>
                            <table>
                                <tr><td>Rem. Básico</td><td>S/ {obj.HaberBasico}</td></tr>
                                <tr><td>Asig. Familiar</td><td>S/ {obj.vAsigFamiliar}</td></tr>
                                <tr><td>Horas Extras 25%</td><td>S/ {obj.vHorasExtra1}</td></tr>
                                <tr><td>Horas Extras 35%</td><td>S/ {obj.vHorasExtra2}</td></tr>
                                <tr><td>Dias Feriados</td><td>S/ {obj.vFeriadoTrab}</td></tr>
                                <tr><td>Dias Feriados</td><td>S/ {obj.ValesEmpleado}</td></tr>
                                <tr><td>Dias Feriados</td><td>S/ {obj.BonificacionCargo}</td></tr>
        
                                <tr><td>Total Ingresos</td><td><strong>S/ {obj.TotalIngreso}</strong></td></tr>
                            </table>
                        </div>
                        
                        <div class='descuentos'>
                            <h3>Descuentos de Ley</h3>
                            <table>
                                <tr><td>Aporte</td><td>S/ {obj.Aporte}</td></tr>
                                <tr><td>Comision</td><td>S/ {obj.Comision}</td></tr>
                                <tr><td>Prima</td><td>S/ {obj.Prima}</td></tr>
                                
                                <tr><td>Total Descuentos</td><td><strong>S/ {obj.TotalDescuento}</strong></td></tr>
                            </table>
                        </div>

                        <div class='aportes'>
                            <h3>Aportes del Empleador</h3>
                            <table>
                                <tr><td>ESSALUD</td><td>S/ {obj.EsSalud}</td></tr>
                                <tr><td>Seguro Vida Ley</td><td>S/ {obj.SeguroVidaLey}</td></tr>
                                <tr><td>Total Empleador</td><td><strong>S/ {obj.EsSalud + obj.SeguroVidaLey}</strong></td></tr>
                            </table>
                        </div>
                    </section>

                    <section class='resumen'>
                        <div class='neto'>
                            <h3>Resumen</h3>
                            <p><strong>Neto a Pagar:</strong> S/ {obj.TotalNetoBoleta}</p>
                            <p><strong>Son:</strong> {obj.TotalNetoBoletaCad}</p>
                        </div>
                    </section>

                    <footer>
                        <p><strong>Emp. Nombre de Sistema</strong></p>
                        <p>Recibí Conforme: <span>____________</span> DNI: <span>____________</span></p>
                    </footer>
                </div>
            </body>
            </html>";



            return html;
        }
    
    }
}
