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