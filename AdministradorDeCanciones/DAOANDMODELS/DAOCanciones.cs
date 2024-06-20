using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorDeCanciones.DAOANDMODELS
{
    public class DAOCanciones
    {
        string connectioString;
        public DAOCanciones(string connectionString)
        {

            this.connectioString = connectionString;

        }

        public bool CrearCancion(string titulo, string artista, byte[] fotoDePerfil, int ano, string genero) {

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectioString))
                {
                    connection.Open();
                    string query = "INSERT INTO canciones(titulo, artista, foto_perfil, año, genero) " +
                        "VALUES (@Titulo, @Artista, @Foto_Perfil, @Ano, @Genero)";
                    using(MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Titulo", titulo);
                        command.Parameters.AddWithValue("@Artista", artista);
                        command.Parameters.AddWithValue("@Foto_Perfil", fotoDePerfil);
                        command.Parameters.AddWithValue("@Ano", ano);
                        command.Parameters.AddWithValue("@Genero", genero);


                        int filas = command.ExecuteNonQuery();


                        if (filas > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            






        
        }


        public Cancion buscarCancionPorID(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectioString))
                {
                    connection.Open();

                    string query = "SELECT * FROM canciones where id = @ID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Cancion cancion = new Cancion()
                            {
                                foto_perfil = (byte[])reader["foto_perfil"]

                            };

                            return cancion;
                        }
                        return null;


                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
