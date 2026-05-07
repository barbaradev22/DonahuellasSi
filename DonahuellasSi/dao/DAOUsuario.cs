using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonahuellasSi.model;

namespace DonahuellasSi.dao
{
    internal class DAOUsuario : Crud<Usuario>
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public bool Insertar(Usuario t)
        {
            // Buena práctica: El bloque using asegura que la conexión se cierre y libere recursos incluso si hay error.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO usuario (nombre, password) VALUES (@nombre, @password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Buena práctica: Definir explícitamente el tipo de dato (SqlDbType) 
                    // para optimizar el rendimiento y evitar conversiones implícitas en SQL.
                    command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = t.Nombre;
                    command.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = t.Password;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<Usuario> Listar()
        {
            var lista = new List<Usuario>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, nombre, password FROM usuario";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Buena práctica: Inicialización de objetos más limpia.
                            lista.Add(new Usuario
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nombre = reader["nombre"].ToString(),
                                Password = reader["password"].ToString()
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
                string query = "DELETE FROM usuario WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Actualizar(Usuario t)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE usuario SET nombre = @nombre, password = @password WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = t.Nombre;
                    command.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = t.Password;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = t.Id;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public Usuario BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, nombre, password FROM usuario WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nombre = reader["nombre"].ToString(),
                                Password = reader["password"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
