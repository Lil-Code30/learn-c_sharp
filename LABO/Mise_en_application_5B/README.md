# Exercices – Recherche et Tri

---

## Exercice 01 : Recherche linéaire

Écrire une fonction qui implémente la recherche linéaire dans un tableau.  
Cette fonction prend un tableau et une valeur en entrée, et renvoie l’indice de la valeur si elle est trouvée, sinon `-1`.

### 1. Nom de la fonction
`LinearSearch(tab, val)`

### 2. Arguments
- `tab` (entier[])
- `val` (entier)

### 3. Sortie
- `index` (entier, `-1` si absent)

**Exemples :**  
`LinearSearch([3, 8, 4, 9, 1], 9)` → `3`  
`LinearSearch([3, 8, 4, 9, 1], 7)` → `-1`

---

## Exercice 02 : Tri par sélection (Selection Sort)

Écrire une fonction qui implémente le tri par sélection.

### 1. Nom de la fonction
`SelectionSort(tab, n)`

### 2. Arguments
- `tab` (entier[])
- `n` (entier)

### 3. Sortie
Tableau trié.

**Exemple :**  
`SelectionSort([5, 2, 9, 1, 6], 5)` → `[1, 2, 5, 6, 9]`

---

## Exercice 03 : Recherche binaire (tableau trié)

Écrire une fonction qui implémente la recherche binaire (récursive ou itérative).  
Cette fonction prend un tableau trié et une valeur en entrée, et renvoie l’indice de la valeur si elle est trouvée, sinon `-1`.

### 1. Nom de la fonction
`BinarySearch(tab, val, gauche, droite)`

### 2. Arguments
- `tab` (entier[])
- `val` (entier)
- `gauche` (entier)
- `droite` (entier)

### 3. Sortie
- `index` (entier, `-1` si absent)

**Exemple :**  
`BinarySearch([1, 3, 4, 8, 9], 4, 0, 4)` → `2`

---

## Exercice 04 : Tri par insertion (Insertion Sort)

Écrire une fonction qui implémente le tri par insertion.

### 1. Nom de la fonction
`InsertionSort(tab, n)`

### 2. Arguments
- `tab` (entier[])
- `n` (entier)

### 3. Sortie
Tableau trié.

**Exemple :**  
`InsertionSort([8, 4, 6, 2, 9], 5)` → `[2, 4, 6, 8, 9]`

---

## Exercice 05 : Recherche d’un élément minimum dans un tableau

Écrire une fonction qui trouve l’élément minimum d’un tableau en parcourant tous les éléments.

### 1. Nom de la fonction
`MinElement(tab, n)`

### 2. Arguments
- `tab` (entier[])
- `n` (entier)

### 3. Sortie
- `min` (entier)

**Exemple :**  
`MinElement([5, 2, 8, 1, 6], 5)` → `1`

---

## Exercice 06 : Tri à bulles (Bubble Sort)

Écrire une fonction qui implémente le tri à bulles.

### 1. Nom de la fonction
`BubbleSort(tab, n)`

### 2. Arguments
- `tab` (entier[])
- `n` (entier)

### 3. Sortie
Tableau trié.

**Exemple :**  
`BubbleSort([9, 3, 7, 4, 1], 5)` → `[1, 3, 4, 7, 9]`

---

## Exercice 07 : Recherche du premier et du dernier indice d’une valeur

Écrire une fonction qui trouve la première et la dernière occurrence d’un élément dans un tableau trié.

### 1. Nom de la fonction
`FindFirstLast(tab, val)`

### 2. Arguments
- `tab` (entier[])
- `val` (entier)

### 3. Sortie
- `(first, last)` (entiers)

**Exemple :**  
`FindFirstLast([1, 2, 2, 2, 3, 4, 5], 2)` → `(1, 3)`

---

## Exercice 08 : Tri rapide (Quick Sort - Récursif)

Écrire une fonction qui implémente le tri rapide (Quick Sort).

### 1. Nom de la fonction
`QuickSort(tab, gauche, droite)`

### 2. Arguments
- `tab` (entier[])
- `gauche` (entier)
- `droite` (entier)

### 3. Sortie
Tableau trié.

**Exemple :**  
`QuickSort([10, 7, 8, 9, 1, 5], 0, 5)` → `[1, 5, 7, 8, 9, 10]`

---

## Exercice 09 : Recherche de la médiane dans un tableau non trié

Écrire une fonction qui trouve la médiane d’un tableau non trié sans le trier entièrement (en utilisant l’algorithme de sélection).

### 1. Nom de la fonction
`FindMedian(tab, n)`

### 2. Arguments
- `tab` (entier[])
- `n` (entier)

### 3. Sortie
- `mediane` (entier)

**Exemple :**  
`FindMedian([7, 3, 5, 1, 9], 5)` → `5`

---

## Exercice 10 : Tri fusion (Merge Sort - Récursif)

Écrire une fonction qui implémente le tri fusion (Merge Sort).

### 1. Nom de la fonction
`MergeSort(tab, gauche, droite)`

### 2. Arguments
- `tab` (entier[])
- `gauche` (entier)
- `droite` (entier)

### 3. Sortie
Tableau trié.

**Exemple :**  
`MergeSort([12, 11, 13, 5, 6, 7], 0, 5)` → `[5, 6, 7, 11, 12, 13]`

---

## Exercice 11 : Vérification si un tableau est trié

Écrire une fonction qui vérifie si un tableau est déjà trié (ordre croissant).

### 1. Nom de la fonction
`IsSorted(tab, n)`

### 2. Arguments
- `tab` (entier[])
- `n` (entier)

### 3. Sortie
- Booléen

**Exemples :**  
`IsSorted([1, 2, 3, 4, 5], 5)` → `Vrai`  
`IsSorted([1, 3, 2, 4, 5], 5)` → `Faux`