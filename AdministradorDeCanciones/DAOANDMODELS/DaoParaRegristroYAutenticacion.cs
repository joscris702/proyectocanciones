using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace AdministradorDeCanciones.DAOANDMODELS
{


    public class UsuarioDAO
    {
        private string connectionString;

        public UsuarioDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool RegistrarUsuario(string username, string password)
        {
            string query = "INSERT INTO usuarios (username, passwordh) VALUES (@Username, @Password)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al registrar usuario: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public Usuario Login(string username, string password)
        {
            string query = "SELECT id, username FROM usuarios WHERE username = @Username AND passwordh = @Password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string usernameDB = reader["username"].ToString();
                                return new Usuario(id, usernameDB);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al intentar iniciar sesión: " + ex.Message);
                    }
                }
            }
            return null;
        }
    }

}
