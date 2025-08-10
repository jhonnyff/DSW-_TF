using PLANILLA.CONEXION;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS;
using static PLANILLA.UTILITARIOS.GlobalEnum;

namespace PLANILLA.API.Migraciones
{
    public class GeneroLog
    {
        public int Insert(Generos obj)
        {
            string cadena = $@"INSERT INTO Generos
                              (Nombre{GlobalConstantes.AuditoriaInsertColumna})
                                 VALUES (@Nombre{GlobalConstantes.AuditoriaInsertValues})
                                {GlobalConstantes.SelectIdentity}";

            new _AuditoriaLog().SetAuditFieldsForInsert(obj);
            return DapperSQL.Execute_Int(cadena, obj);
        }
        public int Update(Generos obj)
        {
            string cadena = $@"Update Generos set Nombre=@Nombre {GlobalConstantes.AuditoriaUpdate} where IdGenero=@IdGenero";
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            return DapperSQL.Execute_Bool(cadena, obj) ? 1 : 0;

        }
        public int CambiarEstado(int id)
        {
            var obj = new Generos { IdGenero = id };
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            string cadena = $@"UPDATE Generos
                                SET Activo = CASE 
                                             WHEN Activo = 1 THEN 0 
                                             ELSE 1 
                                             END
                                    {GlobalConstantes.AuditoriaUpdate}
                                WHERE IdGenero=@IdGenero;
                               select 1;";
            return DapperSQL.Execute_Int(cadena, obj);

        }
        public IEnumerable<Generos> Busqueda(_Estado estado = _Estado.Todos)
        {
            string cadena = $@"Select * from Generos {(estado != _Estado.Todos ? $@" where Activo={(int)estado}" : "")}";


            return DapperSQL.Lista<Generos>(cadena);
        }
    }
}
