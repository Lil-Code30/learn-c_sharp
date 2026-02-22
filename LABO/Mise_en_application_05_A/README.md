# Exercices – Récursivité

---

## Exercice 01 : Calcul du PGCD

Écrire une fonction récursive qui calcule le Plus Grand Commun Diviseur (PGCD) de deux nombres entiers positifs en utilisant l’algorithme d’Euclide.

### 1. Nom de la fonction  
`PGCD(n, m)`

### 2. Arguments  
- `n` (entier)  
- `m` (entier)

### 3. Sortie  
- `result` (entier)

**Exemple :**  
`PGCD(48, 18)` → `6`

---

## Exercice 02 : Conversion décimale en binaire

Écrire une fonction récursive qui prend un entier positif et affiche sa représentation binaire.

### 1. Nom de la fonction  
`Dec2Bin(n)`

### 2. Arguments  
- `n` (entier)

### 3. Sortie  
Affichage de la représentation binaire.

**Exemple :**  
`Dec2Bin(10)` → `1010`

---

## Exercice 03 : Trouver la valeur maximale dans un tableau

Écrire une fonction récursive qui trouve le maximum dans un tableau d’entiers.

### 1. Nom de la fonction  
`MaxTab(tab, n)`

### 2. Arguments  
- `tab` (entier[])  
- `n` (entier)

### 3. Sortie  
- `result` (entier)

**Exemple :**  
`MaxTab([1, 5, 3, 9, 2], 5)` → `9`

---

## Exercice 04 : Vérifier si un mot est un palindrome

Écrire une fonction récursive qui vérifie si une chaîne de caractères est un palindrome.

### 1. Nom de la fonction  
`Palin(mot)`

### 2. Arguments  
- `mot` (chaîne)

### 3. Sortie  
- `rep` (booléen)

**Exemples :**  
`Palin("radar")` → `Vrai`  
`Palin("bonjour")` → `Faux`

---

## Exercice 05 : Triangle de Pascal

Écrire une fonction récursive qui calcule une valeur du triangle de Pascal à une position donnée `(col, lin)`.

### 1. Nom de la fonction  
`Pascal(col, lin)`

### 2. Arguments  
- `col` (entier)  
- `lin` (entier)

### 3. Sortie  
- `result` (entier)

**Exemple :**  
`Pascal(2, 4)` → `6`

---

## Exercice 06 : Tour de Hanoï

Écrire une fonction récursive qui résout le problème des tours de Hanoï :

- Un disque ne peut être déplacé qu’un par un.  
- Un disque ne peut jamais être placé sur un disque plus petit.

### 1. Nom de la fonction  
`Hanoi(n, source, destination, auxiliaire)`

### 2. Arguments  
- `n` (entier)  
- `source` (chaîne)  
- `destination` (chaîne)  
- `auxiliaire` (chaîne)

### 3. Sortie  
Affichage des étapes du déplacement.

---

## Exercice 07 : Suite de Fibonacci

Écrire une fonction récursive qui renvoie le nième terme de la suite de Fibonacci.

### 1. Nom de la fonction  
`Fibonacci(n)`

### 2. Arguments  
- `n` (entier)

### 3. Sortie  
- `result` (entier)

**Exemple :**  
`Fibonacci(7)` → `13`

---

## Exercice 08 : Somme des chiffres d’un nombre

Écrire une fonction récursive qui calcule la somme des chiffres d’un nombre entier positif.

### 1. Nom de la fonction  
`SumDigits(n)`

### 2. Arguments  
- `n` (entier)

### 3. Sortie  
- `result` (entier)

**Exemple :**  
`SumDigits(1234)` → `10`

---

## Exercice 09 : Exponentiation rapide

Écrire une fonction récursive qui calcule une puissance de manière efficace.

### 1. Nom de la fonction  
`Power(base, exposant)`

### 2. Arguments  
- `base` (entier)  
- `exposant` (entier)

### 3. Sortie  
- `result` (entier)

**Exemple :**  
`Power(2, 5)` → `32`

---

## Exercice 10 : Produit de deux nombres sans multiplication

Écrire une fonction récursive qui calcule le produit de deux entiers en utilisant uniquement l’addition.

### 1. Nom de la fonction  
`Multiply(a, b)`

### 2. Arguments  
- `a` (entier)  
- `b` (entier)

### 3. Sortie  
- `result` (entier)

**Exemple :**  
`Multiply(4, 3)` → `12`

---

## Exercice 11 : Inversion d’une chaîne

Écrire une fonction récursive qui inverse une chaîne de caractères.

### 1. Nom de la fonction  
`ReverseStr(mot)`

### 2. Arguments  
- `mot` (chaîne)

### 3. Sortie  
Chaîne inversée.

**Exemple :**  
`ReverseStr("chat")` → `"tahc"`

---

## Exercice 12 : Nombre d’occurrences d’un caractère

Écrire une fonction récursive qui compte le nombre d’occurrences d’un caractère dans une chaîne.

### 1. Nom de la fonction  
`CountChar(mot, c)`

### 2. Arguments  
- `mot` (chaîne)  
- `c` (caractère)

### 3. Sortie  
- `result` (entier)

**Exemple :**  
`CountChar("programmation", 'o')` → `2`

---

## Exercice 13 : Somme des éléments d’un tableau

Écrire une fonction récursive qui calcule la somme des éléments d’un tableau.

### 1. Nom de la fonction  
`SumArray(tab, n)`

### 2. Arguments  
- `tab` (entier[])  
- `n` (entier)

### 3. Sortie  
- `result` (entier)

**Exemple :**  
`SumArray([1, 2, 3, 4, 5], 5)` → `15`

---

## Exercice 14 : Permutations d’une chaîne

Écrire une fonction récursive qui génère toutes les permutations possibles d’une chaîne de caractères.

### 1. Nom de la fonction  
`Permute(mot)`

### 2. Arguments  
- `mot` (chaîne)

### 3. Sortie  
Liste de chaînes.

**Exemple :**  
`Permute("abc")` →  
`["abc", "acb", "bac", "bca", "cab", "cba"]`