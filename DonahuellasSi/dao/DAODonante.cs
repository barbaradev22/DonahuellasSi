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
    internal class DAODonante : Crud<Donante>
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public bool Insertar(Donante t)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO donante (nombre_donante, telefono_donante, rut_donante) VALUES (@nombre, @telefono, @rut)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = t.NombreDonante;
                    command.Parameters.Add("@telefono", SqlDbType.VarChar, 20).Value = t.TelefonoDonante;
                    command.Parameters.Add("@rut", SqlDbType.VarChar, 12).Value = t.RutDonante;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<Donante> Listar()
        {
            var lista = new List<Donante>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_donante, nombre_donante, telefono_donante, rut_donante FROM donante";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Donante
                            {
                                IdDonante = Convert.ToInt32(reader["id_donante"]),
                                NombreDonante = reader["nombre_donante"].ToString(),
                                TelefonoDonante = reader["telefono_donante"].ToString(),
                                RutDonante = reader["rut_donante"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public bool Eliminar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM donante WHERE id_donante = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Actualizar(Donante t)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE donante SET nombre_donante = @nombre, telefono_donante = @telefono, rut_donante = @rut WHERE id_donante = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = t.NombreDonante;
                    command.Parameters.Add("@telefono", SqlDbType.VarChar, 20).Value = t.TelefonoDonante;
                    command.Parameters.Add("@rut", SqlDbType.VarChar, 12).Value = t.RutDonante;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = t.IdDonante;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public Donante BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_donante, nombre_donante, telefono_donante, rut_donante FROM donante WHERE id_donante = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Donante
                            {
                                IdDonante = Convert.ToInt32(reader["id_donante"]),
                                NombreDonante = reader["nombre_donante"].ToString(),
                                TelefonoDonante = reader["telefono_donante"].ToString(),
                                RutDonante = reader["rut_donante"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
