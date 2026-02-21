# Exercices – Structures de données

---

## Exercice 01 : Gestion d’une pile de dossiers d’assurance

Créer un programme qui simule la gestion d’une pile de dossiers d’assurance.  
Chaque dossier peut être ajouté, consulté ou supprimé selon son statut.

### 1. Nom de la fonction  
`GererPileDossiers(action, dossier)`

### 2. Arguments  
- `action` (string) : `"ajouter"`, `"consulter"`, `"retirer"`  
- `dossier` (objet contenant `code`, `requérant`, `type`, `statut`)

### 3. Sortie  
Affichage de l’état actuel de la pile après exécution des actions.

---

## Exercice 02 : Gestion des commandes d’une pizzeria (file d’attente)

Créer un programme simulant une file de commandes de pizzas, où les commandes sont ajoutées et traitées dans l’ordre d’arrivée.

### 1. Nom de la fonction  
`GererCommandes(action, commande)`

### 2. Arguments  
- `action` (string) : `"ajouter"`, `"traiter"`, `"annuler"`  
- `commande` (objet contenant `code`, `typePizza`, `prix`, `statut`)

### 3. Sortie  
Affichage des commandes en attente.

---

## Exercice 03 : Construction et parcours d’un arbre binaire

Construire et afficher un arbre binaire illustré dans la figure ci-dessous, en utilisant des classes pour représenter les nœuds.

### 1. Nom de la fonction  
`ConstruireArbre()`

### 2. Arguments  
Aucun

### 3. Sortie  
Affichage des éléments de l’arbre en :
- Parcours préfixé  
- Parcours infixé  
- Parcours postfixé  

---

## Exercice 04 : Inversion d’une chaîne avec une pile

Écrire une fonction qui utilise une pile pour inverser une chaîne de caractères.

### 1. Nom de la fonction  
`InverserChaine(chaine)`

### 2. Arguments  
- `chaine` (string)

### 3. Sortie  
Chaîne inversée.

---

## Exercice 05 : Vérification de parenthèses équilibrées (pile)

Écrire une fonction qui vérifie si une expression contenant des parenthèses `{}`, `[]`, et `()` est bien formée.

### 1. Nom de la fonction  
`VerifParentheses(expression)`

### 2. Arguments  
- `expression` (string)

### 3. Sortie  
- `true` si l’expression est bien formée  
- `false` sinon  

---

## Exercice 06 : Gestion de l'historique des actions (Undo/Redo) avec une pile

Créer un programme qui gère l'historique des actions d'un éditeur de texte en utilisant une pile.

### 1. Nom de la fonction  
`GererHistorique(action, texte)`

### 2. Arguments  
- `action` (string) : `"ajouter"`, `"undo"`, `"redo"`  
- `texte` (string)

### 3. Sortie  
Affichage du texte actuel.

---

## Exercice 07 : Simulation d’une file d’attente dans une banque (file)

Créer une file d’attente simulant l’arrivée et le traitement des clients dans une banque.

### 1. Nom de la fonction  
`GererFileAttente(action, client)`

### 2. Arguments  
- `action` (string) : `"arrivée"`, `"traiter"`  
- `client` (string)

### 3. Sortie  
Affichage des clients en attente.

---

## Exercice 08 : Calcul de la profondeur d’un arbre binaire

Écrire une fonction qui calcule la profondeur d’un arbre binaire.

### 1. Nom de la fonction  
`CalculerProfondeur(arbre)`

### 2. Arguments  
- `arbre` (arbre binaire)

### 3. Sortie  
Profondeur de l’arbre (`int`).

---

## Exercice 09 : Fusion de deux listes triées (listes chaînées)

Créer une fonction qui fusionne deux listes triées en une seule liste triée.

### 1. Nom de la fonction  
`FusionnerListes(liste1, liste2)`

### 2. Arguments  
- `liste1` (liste triée)  
- `liste2` (liste triée)

### 3. Sortie  
Liste triée fusionnée.

---

## Exercice 10 : Recherche d’un élément dans un arbre binaire

Écrire une fonction qui recherche un élément dans un arbre binaire.

### 1. Nom de la fonction  
`RechercherElement(arbre, valeur)`

### 2. Arguments  
- `arbre` (arbre binaire)  
- `valeur` (valeur à rechercher)

### 3. Sortie  
- `true` si trouvé  
- `false` sinon  