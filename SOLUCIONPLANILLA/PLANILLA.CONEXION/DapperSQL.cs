using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PLANILLA.UTILITARIOS.GlobalConstantes;

namespace PLANILLA.CONEXION
{
    public class DapperSQL
    {
        static string cadenaConexion = Base.ConnectionString;
        public static int Execute_Int(String sql, DynamicParameters parametros = null, CommandType Tipo = CommandType.Text)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            int escalar = 0;
            try
            {

                connection = new SqlConnection(cadenaConexion);
                connection.Open();
                transaction = connection.BeginTransaction();
                escalar = connection.ExecuteScalar<int>(sql, parametros, transaction, null, Tipo);
                transaction.Commit();
            }
            catch (Exception)
            {
                if (transaction != null)
                    transaction.Rollback();
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                throw;
            }
            finally
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                connection.Dispose();
            }
            return escalar;
        }
        public static string Execute_String(String sql, DynamicParameters parametros = null, CommandType Tipo = CommandType.Text)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            string escalar = "";
            try
            {

                connection = new SqlConnection(cadenaConexion);
                connection.Open();
                transaction = connection.BeginTransaction();
                escalar = connection.ExecuteScalar<string>(sql, parametros, transaction, null, Tipo);
                transaction.Commit();
            }
            catch (Exception)
            {
                if (transaction != null)
                    transaction.Rollback();
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                throw;
            }
            finally
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                connection.Dispose();
            }
            return escalar;
        }
        public static bool Execute_Bool(String sql, DynamicParameters parametros = null, CommandType Tipo = CommandType.Text)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            bool escalar = false;
            try
            {

                connection = new SqlConnection(cadenaConexion);
                connection.Open();
                transaction = connection.BeginTransaction();
                escalar = connection.ExecuteScalar<bool>(sql, parametros, transaction, null, Tipo);
                transaction.Commit();
            }
            catch (Exception)
            {
                if (transaction != null)
                    transaction.Rollback();
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                throw;
            }
            finally
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                connection.Dispose();
            }
            return escalar;
        }
        public static DateTime ExecuteDatetime(String sql, DynamicParameters parametros = null, CommandType Tipo = CommandType.Text)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            DateTime escalar = new DateTime();
            try
            {

                connection = new SqlConnection(cadenaConexion);
                connection.Open();
                transaction = connection.BeginTransaction();
                escalar = connection.ExecuteScalar<DateTime>(sql, parametros, transaction, null, Tipo);
                transaction.Commit();
            }
            catch (Exception)
            {
                if (transaction != null)
                    transaction.Rollback();
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                throw;
            }
            finally
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                connection.Dispose();
            }
            return escalar;
        }
        public static int Execute_Int(String sql, object parametros = null, CommandType Tipo = CommandType.Text)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            int escalar = 0;
            try
            {

                connection = new SqlConnection(cadenaConexion);
                connection.Open();
                transaction = connection.BeginTransaction();
                escalar = connection.ExecuteScalar<int>(sql, parametros, transaction, null, Tipo);
                transaction.Commit();
            }
            catch (Exception)
            {
                if (transaction != null)
                    transaction.Rollback();
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                throw;
            }
            finally
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                connection.Dispose();
            }
            return escalar;
        }
        public static string Execute_String(String sql, object parametros = null, CommandType Tipo = CommandType.Text)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            string escalar = "";
            try
            {

                connection = new SqlConnection(cadenaConexion);
                connection.Open();
                transaction = connection.BeginTransaction();
                escalar = connection.ExecuteScalar<string>(sql, parametros, transaction, null, Tipo);
                transaction.Commit();
            }
            catch (Exception)
            {
                if (transaction != null)
                    transaction.Rollback();
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                throw;
            }
            finally
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                connection.Dispose();
            }
            return escalar;
        }
        public static bool Execute_Bool(String sql, object parametros = null, CommandType Tipo = CommandType.Text)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            bool escalar = false;
            try
            {

                connection = new SqlConnection(cadenaConexion);
                connection.Open();
                transaction = connection.BeginTransaction();
                escalar = connection.ExecuteScalar<bool>(sql, parametros, transaction, null, Tipo);
                transaction.Commit();
            }
            catch (Exception)
            {
                if (transaction != null)
                    transaction.Rollback();
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                throw;
            }
            finally
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                connection.Dispose();
            }
            return escalar;
        }
        public static DateTime ExecuteDatetime(String sql, object parametros = null, CommandType Tipo = CommandType.Text)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            DateTime escalar = new DateTime();
            try
            {

                connection = new SqlConnection(cadenaConexion);
                connection.Open();
                transaction = connection.BeginTransaction();
                escalar = connection.ExecuteScalar<DateTime>(sql, parametros, transaction, null, Tipo);
                transaction.Commit();
            }
            catch (Exception)
            {
                if (transaction != null)
                    transaction.Rollback();
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                throw;
            }
            finally
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                connection.Dispose();
            }
            return escalar;
        }


        public static T Objeto<T>(String Cadena, DynamicParameters parametros = null, CommandType Tipo = CommandType.Text)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(cadenaConexion);
                connection.Open();
                return connection.Query<T>(Cadena, parametros, null, true, null, Tipo).FirstOrDefault();
            }
            catch (Exception)
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                throw;
            }
            finally
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
            }
        }
        public static List<T> Lista<T>(String Cadena, DynamicParameters parametros = null, CommandType Tipo = CommandType.Text)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(cadenaConexion);
                connection.Open();
                return connection.Query<T>(Cadena, parametros, null, true, null, Tipo).ToList();

            }
            catch (Exception ex)
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                throw;
            }
            finally
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
            }
        }
        public static DataTable Reader(String Cadena, DynamicParameters parametros = null, CommandType Tipo = CommandType.Text)
        {
            SqlConnection connection = null;
            DataTable Dt = new DataTable();

            try
            {
                connection = new SqlConnection(cadenaConexion);
                connection.Open();
                var r = connection.ExecuteReader(Cadena, parametros, null, null, Tipo);
                Dt.Load(r);
                return Dt;

            }
            catch (Exception ex)
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                throw;
            }
            finally
            {
                if (connection != null)
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
            }
        }
        public static bool InsertarLista< TDetail1>( String CadenaDetalle1, IEnumerable<TDetail1> Detalle1)
        {
       
            using (var connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {

                        foreach (var item in Detalle1)
                        {
                            
                            connection.Execute(CadenaDetalle1, item, transaction);
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }


                }
            }

            return false;

        }

        public static int InsertarCabeceraListDetalle<THeader, TDetail1>(String CadenaCabecera, THeader Cabecera, String CadenaDetalle1, IEnumerable<TDetail1> Detalle1)
        {
            int escalar = 0;
            using (var connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        escalar = connection.ExecuteScalar<int>(CadenaCabecera, Cabecera, transaction);
                        if (escalar == 0) throw new Exception("Operacion Incompleta al Grabar");
                        foreach (var item in Detalle1)
                        {
                            var tipo = item.GetType();
                            var propiedades = tipo.GetProperties();

                            foreach (var propiedad in propiedades)
                            {
                                var aliasAttr = propiedad.GetCustomAttributes(typeof(AliasAttribute), false)
                                                         .FirstOrDefault() as AliasAttribute;

                                if (aliasAttr != null && aliasAttr.Name == AliasCabecera)
                                {
                                    // Encuentra la propiedad original relacionada y asigna el valor
                                    var originalProp = propiedades.FirstOrDefault(p => p.Name == propiedad.Name);
                                    if (originalProp != null && originalProp.CanWrite)
                                    {
                                        originalProp.SetValue(item, System.Convert.ChangeType(escalar, originalProp.PropertyType));

                                    }
                                }
                            }
                            connection.Execute(CadenaDetalle1, item, transaction);
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }


                }
            }

            return escalar;

        }
        public static int InsertarCabeceraDosListDetalle<THeader, TDetail1, TDetail2>(String CadenaCabecera, THeader Cabecera, String CadenaDetalle1, IEnumerable<TDetail1> Detalle1, String CadenaDetalle2, IEnumerable<TDetail2> Detalle2)
        {
            int escalar = 0;
            using (var connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        escalar = connection.ExecuteScalar<int>(CadenaCabecera, Cabecera, transaction);
                        if (escalar == 0) throw new Exception("Operacion Incompleta al Grabar");
                        foreach (var item in Detalle1)
                        {
                            var tipo = item.GetType();
                            var propiedades = tipo.GetProperties();

                            foreach (var propiedad in propiedades)
                            {
                                var aliasAttr = propiedad.GetCustomAttributes(typeof(AliasAttribute), false)
                                                         .FirstOrDefault() as AliasAttribute;

                                if (aliasAttr != null && aliasAttr.Name == AliasCabecera)
                                {
                                    // Encuentra la propiedad original relacionada y asigna el valor
                                    var originalProp = propiedades.FirstOrDefault(p => p.Name == propiedad.Name);
                                    if (originalProp != null && originalProp.CanWrite)
                                    {
                                        originalProp.SetValue(item, System.Convert.ChangeType(escalar, originalProp.PropertyType));

                                    }
                                }
                            }
                            connection.Execute(CadenaDetalle1, item, transaction);
                        }
                        foreach (var item in Detalle2)
                        {
                            var tipo = item.GetType();
                            var propiedades = tipo.GetProperties();

                            foreach (var propiedad in propiedades)
                            {
                                var aliasAttr = propiedad.GetCustomAttributes(typeof(AliasAttribute), false)
                                                         .FirstOrDefault() as AliasAttribute;

                                if (aliasAttr != null && aliasAttr.Name == AliasCabecera)
                                {
                                    // Encuentra la propiedad original relacionada y asigna el valor
                                    var originalProp = propiedades.FirstOrDefault(p => p.Name == propiedad.Name);
                                    if (originalProp != null && originalProp.CanWrite)
                                    {
                                        originalProp.SetValue(item, System.Convert.ChangeType(escalar, originalProp.PropertyType));

                                    }
                                }
                            }
                            connection.Execute(CadenaDetalle2, item, transaction);
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }


                }
            }

            return escalar;

        }
        public static int InsertarCabeceraDetalle<THeader, TDetail1>(String CadenaCabecera, THeader Cabecera, String CadenaDetalle1, TDetail1 Detalle1)
        {
            int escalar = 0;
            using (var connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        escalar = connection.ExecuteScalar<int>(CadenaCabecera, Cabecera, transaction);
                        if (escalar == 0) throw new Exception("Operacion Incompleta al Grabar");

                        var tipo = Detalle1.GetType();
                        var propiedades = tipo.GetProperties();

                        foreach (var propiedad in propiedades)
                        {
                            var aliasAttr = propiedad.GetCustomAttributes(typeof(AliasAttribute), false)
                                                     .FirstOrDefault() as AliasAttribute;

                            if (aliasAttr != null && aliasAttr.Name == AliasCabecera)
                            {
                                // Encuentra la propiedad original relacionada y asigna el valor
                                var originalProp = propiedades.FirstOrDefault(p => p.Name == propiedad.Name);
                                if (originalProp != null && originalProp.CanWrite)
                                {
                                    originalProp.SetValue(Detalle1, System.Convert.ChangeType(escalar, originalProp.PropertyType));

                                }
                            }
                        }
                        connection.Execute(CadenaDetalle1, Detalle1, transaction);


                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }


                }
            }

            return escalar;

        }
    }

}
