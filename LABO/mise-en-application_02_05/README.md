# Exercice 05 : Les structures et les interfaces  

En utilisant les structures et les interfaces, modélisez un programme de gestion de stock. Il faut respecter les spécifications suivantes : 

1. Définir une structure Produit avec les attributs suivants : 
 	- Nom : chaîne de caractères,  
    - Prix : double, 
    - Quantité : entier. 
    
2. Ajouter une méthode Afficher() qui affiche les détails du produit. 
3. Définir une interface IStockable avec la méthode AjouterStock(int quantité). 
4. Implémenter l’interface dans la structure Produit. 
5. Dans le programme principal : 
    - Créer un produit,
    - Ajouter du stock et afficher les détails du produit. 