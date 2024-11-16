class CurrentAccount {
    public string Number{get; set;}
    public double balance; // lecture seule: => (=> veut dire uniquement GET, sinon on aurait mis (get; set;))
    public double CreditLine {get; set;}
    public Personne Owner;

    // Constructeur par défaut
    public CurrentAccount()
    {
        // Initialisation de certaines valeurs par défaut si nécessaire
        balance = 0; // Par exemple, on peut initialiser le solde à 0 par défaut
    }
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