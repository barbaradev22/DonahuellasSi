using DonahuellasSi.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonahuellasSi.dao
{
    internal class DAOAporteDetalle
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public List<AporteDetalle> listarTodo()
        {
            var lista = new List<AporteDetalle>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT 
                        a.id, 
                        p.nombre_proyecto AS proyecto, 
                        d.nombre_donante AS donante, 
                        a.cantidad_donada AS montodonado, 
                        a.fecha_aporte
                    FROM aporte a
                    INNER JOIN proyecto p ON a.id_proyecto = p.id_proyecto
                    INNER JOIN donante d ON a.id_donante = d.id_donante";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new AporteDetalle
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Proyecto = reader["proyecto"].ToString(),
                                Donante = reader["donante"].ToString(),
                                Montodonado = Convert.ToInt32(reader["montodonado"]),
                                FechaAporte = Convert.ToDateTime(reader["fecha_aporte"])
                            });
                        }
                    }
                }
            }
            return lista;
        }

        /// Busca un aporte específico por su ID, devolviendo el detalle legible.
        /// Objeto AporteDetalle o null si no se encuentra
        public AporteDetalle buscarDetallePorId(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT 
                        a.id, 
                        p.nombre_proyecto AS proyecto, 
                        d.nombre_donante AS donante, 
                        a.cantidad_donada AS montodonado, 
                        a.fecha_aporte
                    FROM aporte a
                    INNER JOIN proyecto p ON a.id_proyecto = p.id_proyecto
                    INNER JOIN donante d ON a.id_donante = d.id_donante
                    WHERE a.id = @id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AporteDetalle
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Proyecto = reader["proyecto"].ToString(),
                                Donante = reader["donante"].ToString(),
                                Montodonado = Convert.ToInt32(reader["montodonado"]),
                                FechaAporte = Convert.ToDateTime(reader["fecha_aporte"])
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
