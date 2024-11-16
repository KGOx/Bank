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

6. Créer une classe « SavingsAccount » pour la gestion d’un carnet d’épargne
implémentant :

Les propriétés publiques:
• string Number
• double Balance (lecture seule)
• DateTime DateLastWithdraw
• Person Owner

Les méthodes publiques :
• void Withdraw(double amount)
• void Deposit(double amount)

7. Définir la classe « Account » reprenant les parties commune aux classes
« CurrentAccount » et « SavingsAccount » en utilisant les concepts
d’héritage, de redéfinition de méthodes et si besoin, de surcharge de
méthodes et d’encapsulation.
Attention le niveau d’accessibilité du mutateur de la propriété Balance doit
rester « private ».

8. Modifier la classe « Bank » afin qu’elle ne travaille qu’avec des comptes.

9. Définir la classe « Account » comme étant abstraite.

10.Ajouter une méthode abstraite « protected » à la classe « Account » ayant le
prototype « double CalculInterets() » en sachant que pour un livret d’épargne le
taux est toujours de 4.5% tandis que pour le compte courant si le solde est positif
le taux sera de 3% sinon de 9.75%.

11. Ajouter une méthode « public » à la classe « Account » appelée « ApplyInterest »
qui additionnera le solde avec le retour de la méthode « CalculInterest ».

12. Définir l'interface "IAccount", afin de limiter l'accès à consulter la propriété "Balance" et d'utiliser les méthodes "Deposite" et "Withdraw"

13. Définir l'interface "IBankAccount" ayant les mêmes fonctionnalités que "IAccount". Elle lui permettra, en plus, d'invoquer la méthode du "ApplyInteret" et offrira un accès en lecture au "Owner" et au "Number".
