namespace GraphQL.entities;
public class User
{
    public int Id { get; set; }            // Chiave primaria
    public string Name { get; set; }       // Nome dell'utente

    public int RoleId { get; set; }       // Chiave esterna verso Ruolo
    public Role Role { get; set; }       // Navigational property verso Ruolo

    public List<BankData> BankData { get; set; } = new(); 
    // Lista dei dati bancari associati all'utente (uno-a-molti)
}

