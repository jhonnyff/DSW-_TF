using Microsoft.Data.SqlClient;
using PLANILLA.WEB.Data.Interfase;
using PLANILLA.WEB.Models;
using System.Data;

namespace PLANILLA.WEB.Data.Repositorio
{
    public class TrabajadorRepositorio : ITrabajador
    {
        private readonly IConfiguration config;
        private readonly string cadenaConexion;

        public TrabajadorRepositorio(IConfiguration config, string cadenaConexion)
        {
            this.config = config;
            this.cadenaConexion = config["ConnectionStrings:cnx"];
        }

        public bool Actualizar(Trabajador trabajador)
        {
            bool exito = false;
            return exito;
        }

        public bool Eliminar(int id)
        {
            bool exito = false;
            return exito;
        }

        //public List<Trabajador> Listar(string busqueda, int ID = 0)
        //{
        //    var listado = new List<Trabajador>();
        //    var query = "select * from Trabajadores ";            
            
        //    if(!string.IsNullOrEmpty(busqueda) && ID == 0)
        //        query += query + $"where (Documento + ' ' + Nombres  + ' ' + ApellidoPaterno  + ' ' + ApellidoMaterno) like '%{busqueda}%'";
            
        //    else if (ID > 0)            
        //        query += query + $"where IdTrabajador = {ID}";
                        
        //    //cnx a la bd
        //    using (var conexion = new SqlConnection(cadenaConexion))
        //    {
        //        conexion.Open();
        //        //defini el objeto coomand e indicar el comando SQL a ejecutar
        //        using (var comando = new SqlCommand(query.Trim(), conexion))
        //        {
        //            comando.CommandType = CommandType.StoredProcedure;
        //            //definir objeto de lectura de datos
        //            using (var reader = comando.ExecuteReader())
        //            {
        //                //Leer cada uno de los registros
        //                while (reader.Read())
        //                {
        //                    listado.Add(new Trabajador
        //                    {
        //                        IdTrabajador = reader.GetInt32(reader.GetOrdinal("IdTrabajador")),
        //                        IdTipoDocumento = reader.GetInt32(reader.GetOrdinal("IdTipoDocumento")),
        //                        Documento = reader.GetString(reader.GetOrdinal("Documento")),
        //                        Nombres = reader.GetString(reader.GetOrdinal("Nombres")),
        //                        ApellidoPaterno = reader.GetString(reader.GetOrdinal("ApellidoPaterno")),
        //                        ApellidoMaterno = reader.GetString(reader.GetOrdinal("ApellidoMaterno")),
        //                        IdGenero = reader.GetInt32(reader.GetOrdinal("IdGenero")),
        //                        IdEstadoCivil = reader.GetInt32(reader.GetOrdinal("IdEstadoCivil")),
        //                        Direccion = reader.GetString(reader.GetOrdinal("Direccion")),
        //                        Email = reader.GetString(reader.GetOrdinal("Email")),
        //                        Hijos = reader.GetInt32(reader.GetOrdinal("Hijos")),
        //                        IdCargo = reader.GetInt32(reader.GetOrdinal("IdCargo")),
        //                        FecNacimiento = reader.GetDateTime(reader.GetOrdinal("FecNacimiento")),
        //                        FecIngreso = reader.GetDateTime(reader.GetOrdinal("FecIngreso")),
        //                        IdSituacion = reader.GetInt32(reader.GetOrdinal("IdSituacion")),
        //                        IdSistemaPension = reader.GetInt32(reader.GetOrdinal("IdSistemaPension"))
        //                        //Foto = reader.GetByte(reader.GetOrdinal("Foto")),
        //                    });

        //                }
        //            }
        //        }
        //    }

        //    return listado;
        //}

        public List<Trabajador> Listar()
        {
            throw new NotImplementedException();
        }

        public Trabajador ObtenerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public int Registrar(Trabajador trabajador)
        {
            int nuevoID = 0;

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                //defini el objeto coomand e indicar el comando SQL a ejecutar                
                using (var comando = new SqlCommand("RegistrarCliente", conexion))
                {
                    //comando.CommandType = CommandType.StoredProcedure;
                    //Parametros
                    //comando.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
                    //comando.Parameters.AddWithValue("@nombres", cliente.Nombres);
                    //comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
                    //comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    //comando.Parameters.AddWithValue("@email", cliente.Email);
                    //comando.Parameters.AddWithValue("@TipoClienteID", cliente.TipoClienteID);
                    //nuevoID = int.Parse(comando.ExecuteScalar().ToString());
                }
            }

            return nuevoID;
        }
    }    
}
