using PLANILLA.CONEXION;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS;
using static PLANILLA.UTILITARIOS.GlobalEnum;

namespace PLANILLA.API.Migraciones
{
    public class TipoDocumentolog
    {
        public int Insert(TipoDocumentos obj)
        {
            string cadena = $@"INSERT INTO TipoDocumentos
                              (Nombre{GlobalConstantes.AuditoriaInsertColumna})
                                 VALUES (@Nombre{GlobalConstantes.AuditoriaInsertValues})
                                {GlobalConstantes.SelectIdentity}";

            new _AuditoriaLog().SetAuditFieldsForInsert(obj);
            return DapperSQL.Execute_Int(cadena, obj);
        }
        public int Update(TipoDocumentos obj)
        {
            string cadena = $@"Update TipoDocumentos set Nombre=@Nombre {GlobalConstantes.AuditoriaUpdate} where IdTipoDocumento=@IdTipoDocumento";
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            return DapperSQL.Execute_Bool(cadena, obj) ? 1 : 0;

        }
        public int CambiarEstado(int id)
        {
            var obj = new TipoDocumentos { IdTipoDocumento = id };
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            string cadena = $@"UPDATE TipoDocumentos
                                SET Activo = CASE 
                                             WHEN Activo = 1 THEN 0 
                                             ELSE 1 
                                             END
                                    {GlobalConstantes.AuditoriaUpdate}
                                WHERE IdTipoDocumento=@IdTipoDocumento;
                               select 1;";
            return DapperSQL.Execute_Int(cadena, obj);

        }
        public IEnumerable<TipoDocumentos> Busqueda(_Estado estado = _Estado.Todos)
        {
            string cadena = $@"Select * from TipoDocumentos {(estado != _Estado.Todos ? $@" where Activo={(int)estado}" : "")}";
            return DapperSQL.Lista<TipoDocumentos>(cadena);
        }

    }
}
