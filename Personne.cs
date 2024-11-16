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