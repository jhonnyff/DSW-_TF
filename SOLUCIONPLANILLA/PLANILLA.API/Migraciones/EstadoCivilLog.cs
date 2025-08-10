using PLANILLA.CONEXION;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS;
using static PLANILLA.UTILITARIOS.GlobalEnum;

namespace PLANILLA.API.Migraciones
{
    public class EstadoCivilLog
    {
        public int Insert(EstadosCiviles obj)
        {
            string cadena = $@"INSERT INTO EstadosCiviles
                              (Nombre{GlobalConstantes.AuditoriaInsertColumna})
                                 VALUES (@Nombre{GlobalConstantes.AuditoriaInsertValues})
                                {GlobalConstantes.SelectIdentity}";

            new _AuditoriaLog().SetAuditFieldsForInsert(obj);
            return DapperSQL.Execute_Int(cadena, obj);
        }
        public int Update(EstadosCiviles obj)
        {
            string cadena = $@"Update EstadosCiviles set Nombre=@Nombre {GlobalConstantes.AuditoriaUpdate} where IdEstadoCivil=@IdEstadoCivil";
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            return DapperSQL.Execute_Bool(cadena, obj) ? 1 : 0;

        }
        public int CambiarEstado(int id)
        {
            var obj = new EstadosCiviles { IdEstadoCivil = id };
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            string cadena = $@"UPDATE EstadosCiviles
                                SET Activo = CASE 
                                             WHEN Activo = 1 THEN 0 
                                             ELSE 1 
                                             END
                                    {GlobalConstantes.AuditoriaUpdate}
                                WHERE IdEstadoCivil=@IdEstadoCivil;
                               select 1;";
            return DapperSQL.Execute_Int(cadena, obj);

        }
        public IEnumerable<EstadosCiviles> Busqueda(_Estado estado=_Estado.Todos)
        {
            string cadena = $@"Select * from EstadosCiviles {(estado != _Estado.Todos ? $@" where Activo={(int)estado}" : "")}";


            return DapperSQL.Lista<EstadosCiviles>(cadena);
        }
    }
}
