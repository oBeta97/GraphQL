namespace GraphQL.entities;

public class BankDetail
{
    public int Id { get; set; }               // Chiave primaria
    public string BankName { get; set; }     // Nome della banca (es. "Banco di Padova")

    public List<BankData> BankData { get; set; } = new();
    // Navigational property: elenco dei dati bancari associati a questa banca
}

