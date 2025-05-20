namespace GraphQL.entities;

public class Role
{
    public int Id { get; set; }              // Chiave primaria
    public string Name { get; set; }         // Nome del ruolo (es. "Admin")

    public List<User> Users { get; set; } = new();
    // Navigational property: utenti che hanno questo ruolo (uno-a-molti)
}
