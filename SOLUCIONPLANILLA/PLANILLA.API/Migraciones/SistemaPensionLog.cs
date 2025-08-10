using PLANILLA.CONEXION;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS;
using static PLANILLA.UTILITARIOS.GlobalEnum;

namespace PLANILLA.API.Migraciones
{
    public class SistemaPensionLog
    {
        public int Insert(SistemaPensiones obj)
        {
            string cadena = $@"INSERT INTO SistemaPensiones
                              (Nombre,Aporte,Comision,Prima{GlobalConstantes.AuditoriaInsertColumna})
                                 VALUES (@Nombre,@Aporte,@Comision,@Prima{GlobalConstantes.AuditoriaInsertValues})
                                {GlobalConstantes.SelectIdentity}";

            new _AuditoriaLog().SetAuditFieldsForInsert(obj);
            return DapperSQL.Execute_Int(cadena, obj);
        }
        public int Update(SistemaPensiones obj)
        {
            string cadena = $@"Update SistemaPensiones set Nombre=@Nombre
                            ,Aporte=@Aporte,Comision=@Comision,Prima=@Prima
                            {GlobalConstantes.AuditoriaUpdate} where IdSistemaPension=@IdSistemaPension";
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            return DapperSQL.Execute_Bool(cadena, obj) ? 1 : 0;

        }
        public int CambiarEstado(int id)
        {
            var obj = new SistemaPensiones { IdSistemaPension = id };
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            string cadena = $@"UPDATE SistemaPensiones
                                SET Activo = CASE 
                                             WHEN Activo = 1 THEN 0 
                                             ELSE 1 
                                             END
                                    {GlobalConstantes.AuditoriaUpdate}
                                WHERE IdSistemaPension=@IdSistemaPension;
                               select 1;";
            return DapperSQL.Execute_Int(cadena, obj);

        }
        public IEnumerable<SistemaPensiones> Busqueda(_Estado estado = _Estado.Todos)
        {
            string cadena = $@"Select * from SistemaPensiones {(estado != _Estado.Todos ? $@" where Activo={(int)estado}" : "")}";
            return DapperSQL.Lista<SistemaPensiones>(cadena);
        }

    }
}
