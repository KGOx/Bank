public class SavingsAccount : Account
{
    public DateTime DateLastWithdraw {get; set; }

    public SavingsAccount(string number, DateTime datelastwithdraw, double balance, Personne owner):base(number, owner)
    {
        DateLastWithdraw = datelastwithdraw;
    }
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

        base.Withdraw(amount); // Retire le montant si les fonds sont suffisants
        DateLastWithdraw = DateTime.Now;
        Console.WriteLine($"Retrait de {amount}€ effectué. Nouveau solde : {Balance}€");
    }
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Le montant doit être positif");
            return;
        }

        base.Deposit(amount); // Ajoute le montant au solde
        Console.WriteLine($"Dépôt de {amount}€ effectué. Nouveau solde : {Balance}€");
    }
}