using PLANILLA.CONEXION;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS;
using PLANILLA.UTILITARIOS.Response;

namespace PLANILLA.API.Migraciones
{
    public class AsistenciaTrabajadorLog
    {
        public List<AsistenciaTrabajadorResponse> BuscarAsistenciaByPeriodo(int año, int mes)
        {
            string cadena = $@"SELECT T.IdTrabajador,T.Documento,CONCAT(t.ApellidoPaterno,' ',t.ApellidoMaterno,' ',t.Nombres)[Nombre],
                                      a.DiasLaborales,a.DiasDescanso,a.DiasInasistencia,a.DiasFeriados,a.HorasExtra25,a.HorasExtra35
                               FROM Trabajadores t
                               left join (select * from  AsistenciasTrabajadores where Año={año} and Mes={mes})a on a.IdTrabajador=t.IdTrabajador";
            return DapperSQL.Lista<AsistenciaTrabajadorResponse>(cadena);
        }

        public bool InsertarLista(List<AsistenciasTrabajadores> arr)
        {
            foreach (var item in arr)
            {
               new _AuditoriaLog().SetAuditFieldsForInsert(item);
            }
            DapperSQL.Execute_Bool(" delete AsistenciasTrabajadores where Año=@Año and Mes=@Mes;",arr[0]);


            string cadena = $@"
                              
                               INSERT INTO AsistenciasTrabajadores
                                          (IdTrabajador,Año,Mes,DiasLaborales,DiasDescanso,
                               		   DiasInasistencia,DiasFeriados,HorasExtra25,HorasExtra35{GlobalConstantes.AuditoriaInsertColumna})
                                    VALUES
                                          (@IdTrabajador,@Año,@Mes,@DiasLaborales,@DiasDescanso,
                               		   @DiasInasistencia,@DiasFeriados,@HorasExtra25,@HorasExtra35{GlobalConstantes.AuditoriaInsertValues})";
            return DapperSQL.InsertarLista(cadena, arr);

        }



    }
}
