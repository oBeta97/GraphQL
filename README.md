# GraphQL con Hot Chocolate su .NET 8

Questo progetto è un esercizio pratico per esplorare l'integrazione di GraphQL in un'applicazione ASP.NET Core utilizzando il framework [Hot Chocolate](https://chillicream.com/docs/hotchocolate).

L'obiettivo è comprendere le basi della configurazione di un server GraphQL, la definizione dello schema e la gestione delle query.

## 🧰 Tecnologie utilizzate

- .NET 8
- ASP.NET Core
- Hot Chocolate (GraphQL per .NET)
- Entity Framework Core
- SQLite (per ambiente di test)

## 🚀 Avvio rapido

1. **Clona la repository**  
   ```bash
   git clone https://github.com/oBeta97/GraphQL.git
   cd GraphQL
   ```

2. **Ripristina i pacchetti**  
   ```bash
   dotnet restore
   ```

3. **Crea il database**  
   Se il progetto utilizza Entity Framework Core con le migration, esegui:
   ```bash
   dotnet ef database update
   ```

4. **Avvia l'applicazione**  
   ```bash
   dotnet run
   ```

5. **Apri Banana Cake Pop**  
   Una volta avviata l'applicazione, visita `https://localhost:[nr_porta]/graphql` per accedere alla UI di esplorazione delle query GraphQL.

## 📌 Funzionalità implementate

- Query base per recuperare dati
- Mutazioni per aggiungere entità
- Mappatura tramite record e DTO
- Configurazione di base di Hot Chocolate
- Integrazione con EF Core e database SQLite in memoria
