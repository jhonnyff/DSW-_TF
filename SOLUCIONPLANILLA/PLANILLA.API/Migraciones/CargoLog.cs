
using PLANILLA.CONEXION;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS;
using static PLANILLA.UTILITARIOS.GlobalEnum;

namespace PLANILLA.API.Migraciones
{
    public class CargoLog
    {
        public int Insert(Cargos obj)
        {
            string cadena = $@"INSERT INTO Cargos
                              (Nombre{GlobalConstantes.AuditoriaInsertColumna})
                                 VALUES (@Nombre{GlobalConstantes.AuditoriaInsertValues})
                                {GlobalConstantes.SelectIdentity}";

            new _AuditoriaLog().SetAuditFieldsForInsert(obj);
            return DapperSQL.Execute_Int(cadena, obj);
        }
        public int Update(Cargos obj)
        {
            string cadena = $@"Update cargos set Nombre=@Nombre {GlobalConstantes.AuditoriaUpdate} where IdCargo=@IdCargo";
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            return DapperSQL.Execute_Bool(cadena, obj) ? 1 : 0;

        }
        public int CambiarEstado(int id)
        {
            var obj = new Cargos { IdCargo = id };
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            string cadena = $@"UPDATE cargos
                                SET Activo = CASE 
                                             WHEN Activo = 1 THEN 0 
                                             ELSE 1 
                                             END
                                    {GlobalConstantes.AuditoriaUpdate}
                                WHERE IdCargo=@IdCargo;
                               select 1;";
            return DapperSQL.Execute_Int(cadena, obj);

        }
        public IEnumerable<Cargos> Busqueda(_Estado estado = _Estado.Todos)
        {
            string cadena = $@"Select * from Cargos {(estado != _Estado.Todos ? $@" where Activo={(int)estado}" : "")}";


            return DapperSQL.Lista<Cargos>(cadena);
        }

    }
}
