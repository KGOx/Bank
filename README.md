Projet Banque : 
Créer un nouveau PROJET que vous devrez commit et envoyer sur GitHub
(Raccourci pour new project)
dotnet new console -n "NomProjet"

1. Créer une classe "personne" implémentant : 
Les propriétés publiques 
    - String firstname
    - string lastname
    - datetime birthdate

2. Créer une classe "CurrentAccount" qui permet la gestion d'un compte courant implémentant :
Les propriétés publiques 
    - string number
    - double balance (lecture seule)
    - double CreditLine
    - Person Owner
Les méthodes publiques 
    - void Withdraw (double amount)
    - void Deposit(double amount)

3. Créer une classe "Bank" pour gérer les comptes de la banque implémentant : 
Les propriétés
  - Dictionary<string, Current> Accounts (lecture seule)
  - string Name
Les méthodes :
  - void AddAccount(Current account)
  - void DeleteAccount(String number)

4. Ajouter une méthode qui retourne le solde d'un compte courant.

5. Permettre à la banque de donner la somme de tous les comptes d'une personne.