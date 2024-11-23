// Personne personne = new();
// personne.Firstname = "Gérard";
// personne.Lastname = "Menvusa";
// personne.Birthdate = new DateTime(1997, 5, 20);

// CurrentAccount currentAccount = new CurrentAccount("BE14001938544781", 1000, personne);

// Bank bank = new Bank("Belfius");
// bank.AddAccount(currentAccount);

// currentAccount.Deposit(500);
// currentAccount.Withdraw(200);

// double balance = bank.GetAccountBalance(currentAccount.Number);
// Console.WriteLine($"Le solde du compte {currentAccount.Number} est : {balance}€");
class Program
    {
    static void Main(string[] args)
    {
        // Création de la personne
        Personne personne = new Personne();
        personne.Firstname = "Gérard";
        personne.Lastname = "Menvusa";
        personne.Birthdate = new DateTime(1997, 5, 20);
        
        // Création de la banque
        Bank bank = new Bank("Belfius");
        
        // Création et ajout d'un compte courant
        CurrentAccount currentAccount = new CurrentAccount(
        "BE14001938544781", // Numéro de compte
        1000,              // Ligne de crédit (par exemple)
        personne           // Propriétaire (objet 'personne' que vous avez déjà initialisé)
        );
        bank.AddAccount(currentAccount);
        
        // Effectuer des actions bancaires
        currentAccount.Deposit(500);  // Dépôt de 500€
        currentAccount.Withdraw(200); // Retrait de 200€
        
        // Affichage du solde du compte
        double balance = bank.GetAccountBalance(currentAccount.Number);
        Console.WriteLine($"Le solde du compte {currentAccount.Number} est : {balance}€");
        
        // Tester avec un autre utilisateur
        Personne autrePersonne = new Personne("Alice", "Dupont", new DateTime(1990, 8, 15));
        CurrentAccount autreAccount = new CurrentAccount("BE14009487541546", 500, autrePersonne);
        bank.AddAccount(autreAccount);
        
        autreAccount.Deposit(200); // Dépôt sur le compte d'Alice
        balance = bank.GetAccountBalance(autreAccount.Number);
        Console.WriteLine($"Le solde du compte {autreAccount.Number} est : {balance}€");
    }
    }

public enum Actionbancaire{Withdraw, Deposit}

interface IAccount 
{
    double balance {get;}
    public void Deposite(double amount);
    public void Withdraw(double amount);
}

interface IBankAccount : IAccount
{
    public string Number {get; set;}

}