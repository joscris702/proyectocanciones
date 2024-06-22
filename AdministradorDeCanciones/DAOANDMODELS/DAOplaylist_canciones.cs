using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorDeCanciones.DAOANDMODELS
{
    public class DAOplaylist_canciones
    {
        public string connectionstring = ConnectionManager.connectionString;

        public List<Cancion> ObtenerCancionesDePlaylist(int idPlaylist)
        {
            List<Cancion> canciones = new List<Cancion>() { };

            string query = @"
                
                SELECT id, titulo, artista,año, genero
                FROM Canciones
                WHERE id IN (
                    SELECT cancion_id
                    FROM playlists_canciones
                    WHERE playlist_id = @IdPlaylist
                );";

            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdPlaylist", idPlaylist);

                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cancion cancion = new Cancion();
                                cancion.id = Convert.ToInt32(reader["id"]);
                                cancion.titulo = reader["titulo"].ToString();
                                cancion.artista = reader["artista"].ToString();
                                cancion.ano = Convert.ToInt32( reader["año"]);
                                cancion.genero = reader["genero"].ToString();

                                canciones.Add(cancion);
                            }
                            
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al obtener canciones de playlist: " + ex.Message);
                    }
                }
            }

            return canciones;
        }
    }
}