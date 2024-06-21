public class Usuario
{
    public int Id { get; set; }
    public string Username { get; set; }

    public Usuario(int id, string username)
    {
        Id = id;
        Username = username;
    }
}

