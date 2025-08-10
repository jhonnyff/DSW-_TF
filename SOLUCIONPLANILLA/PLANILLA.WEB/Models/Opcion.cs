namespace PLANILLA.WEB.Models
{
    public class EstadosCivil
    {    
        public int IdEstadoCivil { get; set; }
        public string Nombre { get; set; }
    }

    public class Cargo
    {
        public int? IdCargo { get; set; }
        public string Nombre { get; set; }
    }

    public class TipoDocumento
    {
        public int IdTipoDocumento { get; set; }
        public string Nombre { get; set; }
    }

    public class Genero
    {     
        public int IdGenero { get; set; }
        public string Nombre { get; set; }
    }

    public class SistemaPension
    {
        public int IdSistemaPension { get; set; }
        public string Nombre { get; set; }
        public decimal? Aporte { get; set; }
        public decimal? Comision { get; set; }
        public decimal? Prima { get; set; }
    }

    public class SituacionTrabajador
    {
        public int IdSituacion { get; set; }
        public string Nombre { get; set; }
    }
}
