# Exercice 04 : Les interfaces
En mettant en oeuvre les interfaces, réalisez un système de gestion d'abonnements. Il faut respecter les spécifications suivantes :
1. Définir une interface IAbonnement avec les méthodes suivantes :
    - CalculerMontant() : calcule le montant de l’abonnement,
    - AfficherFacture() : affiche les détails de la facture.

2. Créer deux classes :
   - AbonnementMensuel : montant fixe de 50 $ par mois,

   - AbonnementAnnuel : montant fixe de 500 $ par an.
3. Implémenter l’interface dans les deux classes.
4. Dans le programme principal :
   - Créer un abonnement mensuel et un abonnement annuel,
   - Calculer et afficher le montant de chaque facture.