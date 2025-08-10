using PLANILLA.CONEXION;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS;
using static PLANILLA.UTILITARIOS.GlobalEnum;

namespace PLANILLA.API.Migraciones
{
    public class IngresosTrabajadoresLog
    {
        public int Insert(IngresosTrabajadores obj)
        {
            string cadena = $@"INSERT INTO IngresosTrabajadores
                              (IdTrabajador,Remuneracion,Vale,BonifCargo{GlobalConstantes.AuditoriaInsertColumna})
                                 VALUES (@IdTrabajador,@Remuneracion,@Vale,@BonifCargo{GlobalConstantes.AuditoriaInsertValues})
                                {GlobalConstantes.SelectIdentity}";

            new _AuditoriaLog().SetAuditFieldsForInsert(obj);
            return DapperSQL.Execute_Int(cadena, obj);
        }
        public int Update(IngresosTrabajadores obj)
        {
            string cadena = $@"Update IngresosTrabajadores set 
                               Remuneracion=@Remuneracion,
                               Vale=@Vale,
                               BonifCargo=@BonifCargo  
                               {GlobalConstantes.AuditoriaUpdate} where IdTrabajador=@IdTrabajador";
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            return DapperSQL.Execute_Bool(cadena, obj) ? 1 : 0;

        }
        public int CambiarEstado(int id)
        {
            var obj = new IngresosTrabajadores { IdTrabajador = id };
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            string cadena = $@"UPDATE IngresosTrabajadores
                                SET Activo = CASE 
                                             WHEN Activo = 1 THEN 0 
                                             ELSE 1 
                                             END
                                    {GlobalConstantes.AuditoriaUpdate}
                                WHERE IdTrabajador=@IdTrabajador;
                               select 1;";
            return DapperSQL.Execute_Int(cadena, obj);

        }
        public IngresosTrabajadores BusquedaOne( int id)
        {
            string cadena = $@"Select Top 1 * from IngresosTrabajadores WHERE IdTrabajador={id}";


            return DapperSQL.Objeto<IngresosTrabajadores>(cadena);
        }
        public IEnumerable<IngresosTrabajadores> Busqueda(_Estado estado = _Estado.Todos)
        {
            string cadena = $@"Select * from IngresosTrabajadores {(estado != _Estado.Todos ? $@" where Activo={(int)estado}" : "")}";


            return DapperSQL.Lista<IngresosTrabajadores>(cadena);
        }
    }
}
