public class Account
{
    private double balance;
    protected string type {get; private set; }
    public string Number {get; set; }
    public double Balance {get {return balance; } }
    public Personne Owner {get; set; }
    public string Type
    {
        get => type;
        set => type = value;
    }

    public Account(string number, Personne owner)
    {
        Number = number;
        Owner = owner;
    }

    public void Withdraw(double amount)
    {
        balance -= amount;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

}