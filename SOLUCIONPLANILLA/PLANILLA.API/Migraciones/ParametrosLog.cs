using PLANILLA.CONEXION;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS;
using static PLANILLA.UTILITARIOS.GlobalEnum;

namespace PLANILLA.API.Migraciones
{
    public class ParametrosLog
    {
        public int Insert(Parametros obj)
        {
            string cadena = $@"INSERT INTO Parametros
                                (RemBasico
                                ,PorcAsigancionFamiliar
                                ,PorcExtra1
                                ,PorcExtra2
                                {GlobalConstantes.AuditoriaInsertColumna})
                          VALUES
                                (@RemBasico
                                ,@PorcAsigancionFamiliar
                                ,@PorcExtra1
                                ,@PorcExtra2
                                {GlobalConstantes.AuditoriaInsertValues})
                                {GlobalConstantes.SelectIdentity}";

            new _AuditoriaLog().SetAuditFieldsForInsert(obj);
            return DapperSQL.Execute_Int(cadena, obj);
        }
        public int Update(Parametros obj)
        {
            string cadena = $@"UPDATE Parametros
                                 SET RemBasico = @RemBasico
                                    ,PorcAsigancionFamiliar = @PorcAsigancionFamiliar
                                    ,PorcExtra1 = @PorcExtra1
                                    ,PorcExtra2 = @PorcExtra2 {GlobalConstantes.AuditoriaUpdate} where IdParametro=@IdParametro";
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            return DapperSQL.Execute_Bool(cadena, obj) ? 1 : 0;

        }
        public int CambiarEstado(int id)
        {
            var obj = new Parametros { IdParametro = id };
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            string cadena = $@"UPDATE Parametros
                                SET Activo = CASE 
                                             WHEN Activo = 1 THEN 0 
                                             ELSE 1 
                                             END
                                    {GlobalConstantes.AuditoriaUpdate}
                                WHERE IdParametro=@IdParametro;
                               select 1;";
            return DapperSQL.Execute_Int(cadena, obj);

        }
        public IEnumerable<Parametros> Busqueda(_Estado estado = _Estado.Todos)
        {
            string cadena = $@"Select * from Parametros {(estado != _Estado.Todos ? $@" where Activo={(int)estado}" : "")}";


            return DapperSQL.Lista<Parametros>(cadena);
        }
        public Parametros BusquedaOne()
        {
            string cadena = $@"Select Top 1 * from Parametros ";


            return DapperSQL.Objeto<Parametros>(cadena);
        }
    }
}
