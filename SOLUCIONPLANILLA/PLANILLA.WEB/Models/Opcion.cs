namespace PLANILLA.WEB.Models
{
    public class EstadosCivil1
    {    
        public int IdEstadoCivil { get; set; }
        public string Nombre { get; set; }
    }

    public class Cargo1
    {
        public int? IdCargo { get; set; }
        public string Nombre { get; set; }
    }

    public class TipoDocumento1
    {
        public int IdTipoDocumento { get; set; }
        public string Nombre { get; set; }
    }

    public class Genero1
    {     
        public int IdGenero { get; set; }
        public string Nombre { get; set; }
    }

    public class SistemaPension1
    {
        public int IdSistemaPension { get; set; }
        public string Nombre { get; set; }
        public decimal? Aporte { get; set; }
        public decimal? Comision { get; set; }
        public decimal? Prima { get; set; }
    }

    public class SituacionTrabajador1
    {
        public int IdSituacion { get; set; }
        public string Nombre { get; set; }
    }
}
