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
    internal class DAOProyecto : Crud<Proyecto>
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public bool insertar(Proyecto t)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO proyecto (nombre_proyecto, descripcion_proyecto, monto_donado) VALUES (@nombre, @descripcion, @monto)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = t.NombreProyecto;
                    command.Parameters.Add("@descripcion", SqlDbType.VarChar, 255).Value = t.DescripcionProyecto;
                    command.Parameters.Add("@monto", SqlDbType.Int).Value = t.CostoProyecto;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<Proyecto> listar()
        {
            var lista = new List<Proyecto>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_proyecto, nombre_proyecto, descripcion_proyecto, monto_donado FROM proyecto";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Proyecto
                            {
                                IdProyecto = Convert.ToInt32(reader["id_proyecto"]),
                                NombreProyecto = reader["nombre_proyecto"].ToString(),
                                DescripcionProyecto = reader["descripcion_proyecto"].ToString(),
                                CostoProyecto = Convert.ToInt32(reader["monto_donado"])
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
                string query = "DELETE FROM proyecto WHERE id_proyecto = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool actualizar(Proyecto t)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE proyecto SET nombre_proyecto = @nombre, descripcion_proyecto = @descripcion, monto_donado = @monto WHERE id_proyecto = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = t.NombreProyecto;
                    command.Parameters.Add("@descripcion", SqlDbType.VarChar, 255).Value = t.DescripcionProyecto;
                    command.Parameters.Add("@monto", SqlDbType.Int).Value = t.CostoProyecto;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = t.IdProyecto;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public Proyecto buscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_proyecto, nombre_proyecto, descripcion_proyecto, monto_donado FROM proyecto WHERE id_proyecto = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Proyecto
                            {
                                IdProyecto = Convert.ToInt32(reader["id_proyecto"]),
                                NombreProyecto = reader["nombre_proyecto"].ToString(),
                                DescripcionProyecto = reader["descripcion_proyecto"].ToString(),
                                CostoProyecto = Convert.ToInt32(reader["monto_donado"])
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
