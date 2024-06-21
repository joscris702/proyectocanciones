using System;
using MySql.Data.MySqlClient;

public class ConnectionManager
{
    public static string connectionString { get; set; } = "Server=localhost;Database=SPOTIFY;Uid=root;Pwd=admin;";

    public static MySqlConnection GetConnection()
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        return connection;
    }
}
