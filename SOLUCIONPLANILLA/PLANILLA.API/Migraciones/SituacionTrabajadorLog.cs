using PLANILLA.CONEXION;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS;
using static PLANILLA.UTILITARIOS.GlobalEnum;

namespace PLANILLA.API.Migraciones
{
    public class SituacionTrabajadorLog
    {
        public int Insert(SituacionTrabajador obj)
        {
            string cadena = $@"INSERT INTO SituacionTrabajador
                              (Nombre{GlobalConstantes.AuditoriaInsertColumna})
                                 VALUES (@Nombre{GlobalConstantes.AuditoriaInsertValues})
                                {GlobalConstantes.SelectIdentity}";

            new _AuditoriaLog().SetAuditFieldsForInsert(obj);
            return DapperSQL.Execute_Int(cadena, obj);
        }
        public int Update(SituacionTrabajador obj)
        {
            string cadena = $@"Update SituacionTrabajador set Nombre=@Nombre {GlobalConstantes.AuditoriaUpdate} where IdSituacion=@IdSituacion";
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            return DapperSQL.Execute_Bool(cadena, obj) ? 1 : 0;

        }
        public int CambiarEstado(int id)
        {
            var obj = new SituacionTrabajador { IdSituacion = id };
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            string cadena = $@"UPDATE SituacionTrabajador
                                SET Activo = CASE 
                                             WHEN Activo = 1 THEN 0 
                                             ELSE 1 
                                             END
                                    {GlobalConstantes.AuditoriaUpdate}
                                WHERE IdSituacion=@IdSituacion;
                               select 1;";
            return DapperSQL.Execute_Int(cadena, obj);

        }
        public IEnumerable<SituacionTrabajador> Busqueda(_Estado estado = _Estado.Todos)
        {
            string cadena = $@"Select * from SituacionTrabajador {(estado != _Estado.Todos ? $@" where Activo={(int)estado}" : "")}";


            return DapperSQL.Lista<SituacionTrabajador>(cadena);
        }
    }
}
