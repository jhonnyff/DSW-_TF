using PLANILLA.ENTIDADES;

namespace PLANILLA.API.Migraciones
{
    public class _AuditoriaLog
    {
        public void SetAuditFieldsForInsert(_Auditoria entity)
        {

            entity.FecCreacion = DateTime.Now;
            entity.Activo = true;
        }

        public void SetAuditFieldsForUpdate(_Auditoria entity)
        {
            entity.FecCreacion = DateTime.Now;
            entity.FecUltimaModificacion = DateTime.Now;
        }
    }
}
