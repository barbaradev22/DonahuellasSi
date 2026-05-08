using System;
using System.Collections.Generic;
using System.Configuration;
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

        public bool insertar(Usuario t)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO usuario (nombre, password) VALUES (@nombre, @password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = t.Nombre;
                    command.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = t.Password;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<Usuario> listar()
        {
            var lista = new List<Usuario>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_usuario, nombre_usuario, password_usuario FROM usuario";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuario
                            {
                                Id = Convert.ToInt32(reader["id_usuario"]),
                                Nombre = reader["nombre_usuario"].ToString(),
                                Password = reader["password_usuario"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public bool eliminar(int id)
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

        public bool actualizar(Usuario t)
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

        public Usuario buscarPorId(int id)
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
