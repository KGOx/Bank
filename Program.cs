Personne personne = new();
personne.Firstname = "Gérard";
personne.Lastname = "Menvusa";
personne.Birthdate = new DateTime(1997, 5, 20);


public enum Actionbancaire{Withdraw, Deposit}
class Personne {
    public string? Firstname {get; set;}
    public string? Lastname {get; set;}
    public DateTime Birthdate {get; set;}
    public Personne(string firstname, string lastname, DateTime birthdate){
        Firstname = firstname;
        Lastname = lastname;
        Birthdate = birthdate;
    }

    public Personne()
    {
    }
}

class Bank { // La classe Bank représente une banque qui peut gérer plusieurs comptes bancaires

    public string Name { get; set; }// La propriété Name stocke le nom de la banque.
    /* Dictionary<string, CurrentAccount> : un dictionnaire qui associe une clé de type string (le numéro de compte)
     à une valeur de type CurrentAccount (le compte courant associé à ce numéro).
     Le dictionnaire est en lecture seule (seul un get est défini), ce qui signifie qu'on ne peut pas le remplacer
     directement, mais on peut toujours y ajouter ou retirer des éléments via ses méthodes.*/
    public Dictionary<string, CurrentAccount> Accounts { get; } = new Dictionary<string, CurrentAccount>();

    // Constructeur qui initialise le nom de la banque
    public Bank(string name)
    {
        Name = name;
    }

    // Méthode qui retourne le solde de tous les comptes d'un seul "owner"
    public double GetAllAccountBalance(Personne Owner)
    {
        double totalBalance = 0;
        bool OwnerFound = false;
        
        foreach (var account in Accounts.Values)
        {
            if (Owner == account.Owner)
            {
            OwnerFound = true;
            totalBalance += account.Balance;
            }
        }
        if (!OwnerFound)
        {
            throw new ArgumentException("Aucun client de ce nom");
        }
        return totalBalance;
    }

    // Méthode pour ajouter un compte dans le dictionnaire
    public void AddAccount(CurrentAccount account)
    {
        if (Accounts.ContainsKey(account.Number)) // Vérifie si un compte existe déjà dans le dictio.
        {
            Console.WriteLine("Un compte avec ce numéro existe déjà.");
            return;
        }

        Accounts[account.Number] = account; // Ajoute un nouveau compte si inexistant
        Console.WriteLine($"Compte {account.Number} ajouté avec succès."); // Account.number = clé | account = valeur
    }

    // Méthode qui retourne le solde d'un compte courant
    public double GetAccountBalance(string accountNumber)
    {
        if (!Accounts.ContainsKey(accountNumber))
        {
            throw new ArgumentException("Le compte spécifié n'existe pas.");
        }
        return Accounts[accountNumber].Balance; 
    }

    // Méthode pour supprimer un compte
    public void DeleteAccount(string number)
    {
        if (Accounts.Remove(number)) // Si le compte existe, il le supprime
        {
            Console.WriteLine($"Compte {number} supprimé avec succès.");
        }
        else // Si inexistant, envoie ce message
        {
            Console.WriteLine("Le compte n'existe pas.");
        }
    }
}

class SavingsAccount {
    private double balance;
    public string? Number {get; set; }
    public double Balance {get {return balance;} }
    public DateTime DateLastWithdraw {get; set; }
    public Personne Owner {get; set; }

    public void Withdraw(double amount)
    {
        if (amount <= 0){
            Console.WriteLine("Le montant doit être positif");
            return;
        }
        if (Balance - amount < 0){
            Console.WriteLine("Fond insufissants");
            return;
        }

        balance -= amount; // Retire le montant si les fonds sont suffisants
        DateLastWithdraw = DateTime.Now;
        Console.WriteLine($"Retrait de {amount} effectué. Nouveau solde : {Balance}");
    }
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Le montant doit être positif");
            return;
        }

        balance += amount; // Ajoute le montant au solde
        Console.WriteLine($"Dépôt de {amount} effectué. Nouveau solde : {Balance}");
    }
}

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

class CurrentAccount {
    public string Number{get; set;}
    public double balance; // lecture seule: => (=> veut dire uniquement GET, sinon on aurait mis (get; set;))
    public double CreditLine {get; set;}
    public Personne Owner;

    public CurrentAccount(string number, double creditLine, Personne owner){
        Number = number;
        CreditLine = creditLine;
        Owner = owner;
        balance = 0;
    }
    public double Balance {
        get {return balance;}
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0){
            Console.WriteLine("Le montant doit être positif");
            return;
        }
        if (Balance - amount < CreditLine){
            Console.WriteLine("Fond insufissants");
            return;
        }

        balance -= amount; // Retire le montant si les fonds sont suffisants
        Console.WriteLine($"Retrait de {amount} effectué. Nouveau solde : {Balance}");
    }
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Le montant doit être positif");
            return;
        }
        balance += amount; // Ajoute le montant au solde
        Console.WriteLine($"Dépôt de {amount} effectué. Nouveau solde : {Balance}");
    }
    }