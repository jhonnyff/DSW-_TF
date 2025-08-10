using PLANILLA.CONEXION;
using PLANILLA.ENTIDADES;
using PLANILLA.UTILITARIOS;
using PLANILLA.UTILITARIOS.Request;
using static PLANILLA.UTILITARIOS.GlobalEnum;

namespace PLANILLA.API.Migraciones
{
    public class TrabajadorLog
    {
        public int Insert(Trabajadores obj)
        {
            string cadena = $@"INSERT INTO Trabajadores
                              (IdTipoDocumento,Documento,Nombres,ApellidoPaterno,ApellidoMaterno,IdGenero
                                ,IdEstadoCivil,Direccion,Email,Hijos,IdCargo,FecNacimiento
                                ,FecIngreso,IdSituacion,IdSistemaPension,Foto{GlobalConstantes.AuditoriaInsertColumna})
                                 VALUES (@IdTipoDocumento,@Documento,@Nombres,@ApellidoPaterno,@ApellidoMaterno,@IdGenero
                                ,@IdEstadoCivil,@Direccion,@Email,@Hijos,@IdCargo,@FecNacimiento
                                ,@FecIngreso,@IdSituacion,@IdSistemaPension,@Foto{GlobalConstantes.AuditoriaInsertValues})
                                {GlobalConstantes.SelectIdentity}";

            new _AuditoriaLog().SetAuditFieldsForInsert(obj);
            return DapperSQL.Execute_Int(cadena, obj);
        }
        public int Update(Trabajadores obj)
        {
            string cadena = $@"UPDATE Trabajadores
                                SET IdTipoDocumento = @IdTipoDocumento
                                   ,Documento = @Documento
                                   ,Nombres = @Nombres
                                   ,ApellidoPaterno = @ApellidoPaterno
                                   ,ApellidoMaterno = @ApellidoMaterno
                                   ,IdGenero = @IdGenero
                                   ,IdEstadoCivil = @IdEstadoCivil
                                   ,Direccion = @Direccion
                                   ,Email = @Email
                                   ,Hijos = @Hijos
                                   ,IdCargo = @IdCargo
                                   ,FecNacimiento = @FecNacimiento
                                   ,FecIngreso = @FecIngreso
                                   ,IdSituacion = @IdSituacion
                                   ,IdSistemaPension = @IdSistemaPension
                                   ,Foto = @Foto 
                                    {GlobalConstantes.AuditoriaUpdate} 
                                    where IdTrabajador=@IdTrabajador";
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            return DapperSQL.Execute_Bool(cadena, obj) ? 1 : 0;

        }
        public int CambiarEstado(int id)
        {
            var obj = new Trabajadores { IdTrabajador = id };
            new _AuditoriaLog().SetAuditFieldsForUpdate(obj);
            string cadena = $@"UPDATE Trabajadores
                                SET Activo = CASE 
                                             WHEN Activo = 1 THEN 0 
                                             ELSE 1 
                                             END
                                    {GlobalConstantes.AuditoriaUpdate}
                                WHERE IdTrabajador=@IdTrabajador;
                               select 1;";
            return DapperSQL.Execute_Int(cadena, obj);

        }
        public IEnumerable<Trabajadores> Busqueda(BuquedaTrabajador obj)
        {
            string cadena = $@"DECLARE @busqueda VARCHAR(50);
                               SET @busqueda = '{obj.Busqueda}'; -- Puedes asignar un valor para probar la búsqueda
                               
                               WITH Palabras AS (
                                   SELECT value AS palabra
                                   FROM STRING_SPLIT(@busqueda, ' ')
                               )
                               SELECT *
                               FROM Trabajadores
                               WHERE (
                                   -- Si @busqueda está vacío, devolver todos los registros
                                   @busqueda IS NULL OR @busqueda = ''
                               )
                               OR EXISTS (
                                   -- Verificar que todas las palabras del término de búsqueda coincidan en algún campo
                                   SELECT 1
                                   FROM Palabras
                                   WHERE 
                                       (ApellidoPaterno LIKE '%' + palabra + '%'
                                       OR ApellidoMaterno LIKE '%' + palabra + '%'
                                       OR Nombres LIKE '%' + palabra + '%'
                                       OR Documento LIKE '%' + palabra + '%')
                               ) {(obj.estado != _Estado.Todos ? $@" and Activo={(int)obj.estado}" : "")}";


            return DapperSQL.Lista<Trabajadores>(cadena);
        }

    }
}
