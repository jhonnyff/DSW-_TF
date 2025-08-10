using PLANILLA.WEB.Models;

namespace PLANILLA.WEB.Data.Interfase
{
    public interface ITrabajador
    {
        bool Actualizar(Trabajador cliente);
        bool Eliminar(int id);
        List<Trabajador> Listar();
        Trabajador ObtenerPorID(int id);
        int Registrar(Trabajador cliente);
    }
}
