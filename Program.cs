// Créer une classe "personne" implémentant : Les propriétés publiques - String firstname, string lastname, datetime birthdate

Personne personne = new();
personne.firstname = "Gérard";
personne.lastname = "Menvusa";
personne.birthdate = new DateTime(1997, 5, 20);

class Personne {
    public string? firstname;
    public string? lastname;
    public DateTime birthdate;
}