// Créer une classe "personne" implémentant : Les propriétés publiques - String firstname, string lastname, datetime birthdate

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
        }
        if (Balance - amount < CreditLine){
            Console.WriteLine("Fond insufissants");
            return;
        }
    }
    public void Deposit(double amount){

    }
    }


// Ex2
// Créer une classe "CurrentAccount" qui permet la gestion d'un compte courant implémentant :
// Les propriétés publiques 
//     - string number, double balance (lecture seule), double CreditLine, Person Owner
// Les méthodes publiques 
//     - void Withdraw (double amount), void Deposit(double amount)