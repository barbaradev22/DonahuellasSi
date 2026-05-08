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
    internal class DAOAporte : Crud<Aporte>
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public bool Insertar(Aporte t)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO aporte (id_proyecto, id_donante, cantidad_donada, fecha_aporte) VALUES (@idProyecto, @idDonante, @cantidad, @fecha)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@idProyecto", SqlDbType.Int).Value = t.IdProyecto;
                    command.Parameters.Add("@idDonante", SqlDbType.Int).Value = t.IdDonante;
                    command.Parameters.Add("@cantidad", SqlDbType.Int).Value = t.CantidadDonada;
                    command.Parameters.Add("@fecha", SqlDbType.DateTime).Value = t.FechaAporte;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<Aporte> Listar()
        {
            var lista = new List<Aporte>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, id_proyecto, id_donante, cantidad_donada, fecha_aporte FROM aporte";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Aporte
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdProyecto = Convert.ToInt32(reader["id_proyecto"]),
                                IdDonante = Convert.ToInt32(reader["id_donante"]),
                                CantidadDonada = Convert.ToInt32(reader["cantidad_donada"]),
                                FechaAporte = Convert.ToDateTime(reader["fecha_aporte"])
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public bool Eliminar(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM aporte WHERE id = @id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Actualizar(Aporte t)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE aporte SET id_proyecto = @idProyecto, id_donante = @idDonante, cantidad_donada = @cantidad, fecha_aporte = @fecha WHERE id = @id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@idProyecto", SqlDbType.Int).Value = t.IdProyecto;
                    command.Parameters.Add("@idDonante", SqlDbType.Int).Value = t.IdDonante;
                    command.Parameters.Add("@cantidad", SqlDbType.Int).Value = t.CantidadDonada;
                    command.Parameters.Add("@fecha", SqlDbType.DateTime).Value = t.FechaAporte;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = t.Id;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public Aporte BuscarPorId(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, id_proyecto, id_donante, cantidad_donada, fecha_aporte FROM aporte WHERE id = @id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Aporte
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdProyecto = Convert.ToInt32(reader["id_proyecto"]),
                                IdDonante = Convert.ToInt32(reader["id_donante"]),
                                CantidadDonada = Convert.ToInt32(reader["cantidad_donada"]),
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
