class CurrentAccount : Account
{
    public double CreditLine {get; set;}

    public CurrentAccount(string number, double creditLine, Personne owner):base(number, owner)
    {
        CreditLine = creditLine;
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

        base.Withdraw(amount); // Retire le montant si les fonds sont suffisants
        Console.WriteLine($"Retrait de {amount} effectué. Nouveau solde : {Balance}");
    }
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Le montant doit être positif");
            return;
        }
        base.Deposit(amount); // Ajoute le montant au solde
        Console.WriteLine($"Dépôt de {amount} effectué. Nouveau solde : {Balance}");
    }
    }