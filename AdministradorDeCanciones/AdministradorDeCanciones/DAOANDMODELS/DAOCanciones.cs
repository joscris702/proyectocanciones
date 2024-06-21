using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdministradorDeCanciones.DAOANDMODELS
{
    public class DAOCanciones
    {
        string connectioString = ConnectionManager.connectionString;

       

        public bool CrearCancion(string titulo, string artista, byte[] fotoDePerfil, int ano, string genero)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectioString))
                {
                    connection.Open();
                    string query = "INSERT INTO canciones(titulo, artista, foto_perfil, año, genero) " +
                        "VALUES (@Titulo, @Artista, @Foto_Perfil, @Ano, @Genero)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Titulo", titulo);
                        command.Parameters.AddWithValue("@Artista", artista);
                        command.Parameters.AddWithValue("@Foto_Perfil", fotoDePerfil);
                        command.Parameters.AddWithValue("@Ano", ano);
                        command.Parameters.AddWithValue("@Genero", genero);

                        int filas = command.ExecuteNonQuery();

                        return filas > 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool EditarCancion(int id, string titulo, string artista, byte[] fotoDePerfil, int ano, string genero)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectioString))
                {
                    connection.Open();
                    string query = "UPDATE Canciones SET titulo = @Titulo, artista = @Artista, " +
                        "foto_perfil = @Foto_Perfil, año = @Ano, genero = @Genero " +
                        "WHERE id = @ID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@Titulo", titulo);
                        command.Parameters.AddWithValue("@Artista", artista);
                        command.Parameters.AddWithValue("@Foto_Perfil", fotoDePerfil);
                        command.Parameters.AddWithValue("@Ano", ano);
                        command.Parameters.AddWithValue("@Genero", genero);

                        int filas = command.ExecuteNonQuery();

                        return filas > 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool EliminarCancion(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectioString))
                {
                    connection.Open();
                    string query = "DELETE FROM Canciones WHERE id = @ID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        int filas = command.ExecuteNonQuery();

                        return filas > 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public List<Cancion> ObtenerTodasLasCanciones()
        {
            List<Cancion> canciones = new List<Cancion>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectioString))
                {
                    connection.Open();
                    string query = "SELECT * FROM canciones";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cancion cancion = new Cancion()
                                {
                                    id = Convert.ToInt32(reader["id"]),
                                    titulo = reader["titulo"].ToString(),
                                    artista = reader["artista"].ToString(),
                                    foto_perfil = (byte[])reader["foto_perfil"],
                                    ano = Convert.ToInt32(reader["año"]),
                                    genero = reader["genero"].ToString()
                                };
                                canciones.Add(cancion);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return canciones;
        }

        public Cancion BuscarCancionPorID(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectioString))
                {
                    connection.Open();
                    string query = "SELECT * FROM canciones WHERE id = @ID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Cancion cancion = new Cancion()
                                {
                                    id = Convert.ToInt32(reader["id"]),
                                    titulo = reader["titulo"].ToString(),
                                    artista = reader["artista"].ToString(),
                                    foto_perfil = (byte[])reader["foto_perfil"],
                                    ano = Convert.ToInt32(reader["año"]),
                                    genero = reader["genero"].ToString()
                                };
                                return cancion;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
    }
}
