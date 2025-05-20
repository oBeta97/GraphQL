namespace GraphQL.entities;
public class BankData
{
    public int Id { get; set; }           // Chiave primaria del record di dati bancari
    public string IBAN { get; set; }      // IBAN o numero di conto

    public int UserId { get; set; }     // Chiave esterna verso User
    public User User { get; set; }    // Navigational property verso User

    public int BankDetailId { get; set; }    // Chiave esterna verso BankDetail
    public BankDetail BankDetail { get; set; }  // Navigational property verso Banca
}