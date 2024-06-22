using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace AdministradorDeCanciones.DAOANDMODELS
{
    public class DAOPlaylist
    {
        private string connectionString = ConnectionManager.connectionString;

     
        public int CrearPlaylist(string nombrePlaylist, int idUsuario)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO playlists (nombre, usuario_id) VALUES (@Nombre, @IdUsuario); SELECT LAST_INSERT_ID();";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombrePlaylist);
                        command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                        int idPlaylist = Convert.ToInt32(command.ExecuteScalar());
                        return idPlaylist;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la playlist: " + ex.Message);
                throw;
            }
        }

        public List<Playlist> ObtenerPlaylistsDeUsuario(int idUsuario)
        {
            List<Playlist> playlists = new List<Playlist>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id, nombre FROM playlists WHERE usuario_id = @IdUsuario";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Playlist playlist = new Playlist()
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Nombre = reader["nombre"].ToString()
                                };

                                playlists.Add(playlist);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener playlists: " + ex.Message);
                throw;
            }

            return playlists;
        }

        public bool EliminarPlaylist(int idPlaylist)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM playlists WHERE id = @IdPlaylist";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdPlaylist", idPlaylist);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar la playlist: " + ex.Message);
                throw;
            }
        }

        public bool AgregarCancionAPlaylist(int idPlaylist, int idCancion)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO playlists_canciones (playlist_id, cancion_id) VALUES (@PlaylistId, @CancionId)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PlaylistId", idPlaylist);
                        command.Parameters.AddWithValue("@CancionId", idCancion);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar canción a la playlist: " + ex.Message);
                throw;
            }
        }
    }
}


