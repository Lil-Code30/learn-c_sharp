# AGRÉGATION vs COMPOSITION

## 🧩 1. Idée clé (à retenir absolument)

👉 **La différence principale**, c’est la **dépendance de vie** entre les objets.

| Concept         | Question clé                                     |
| --------------- | ------------------------------------------------ |
| **Agrégation**  | _Est-ce que l’objet peut exister sans l’autre ?_ |
| **Composition** | _Est-ce que l’objet meurt si l’autre meurt ?_    |

---

## 🟢 2. AGRÉGATION (relation faible)

### 📌 Définition simple

👉 Un objet **utilise** ou **possède** un autre objet
👉 MAIS **chaque objet peut exister seul**

💡 _« Je te prête quelque chose, mais tu peux vivre sans moi »_

---

### ✅ 5 exemples de la vraie vie (Agrégation)

#### 1️⃣ Université — Étudiant

- Une université **a des étudiants**
- Un étudiant peut :
  - changer d’université
  - exister même si l’université ferme

✔️ **Agrégation**

---

#### 2️⃣ Équipe de foot — Joueur

- Une équipe **a des joueurs**
- Si l’équipe disparaît :
  - les joueurs existent toujours
  - ils peuvent rejoindre une autre équipe

✔️ **Agrégation**

---

#### 3️⃣ Bibliothèque — Livre

- Une bibliothèque **contient des livres**
- Un livre peut :
  - être déplacé ailleurs
  - exister sans cette bibliothèque

✔️ **Agrégation**

---

#### 4️⃣ Classe — Professeur

- Une classe **a un professeur**
- Le professeur :
  - peut changer de classe
  - peut exister sans cette classe

✔️ **Agrégation**

---

#### 5️⃣ Entreprise — Employé

- Une entreprise **emploie des employés**
- Si l’entreprise ferme :
  - les employés existent toujours

✔️ **Agrégation**

---

### 🧠 Résumé Agrégation

👉 Les objets sont **indépendants**
👉 Relation **faible**
👉 Le lien peut être rompu sans détruire les objets

---

## 🔴 3. COMPOSITION (relation forte)

### 📌 Définition simple

👉 Un objet est **composé** d’autres objets
👉 SI l’objet principal est détruit → **tout disparaît**

💡 _« Si je meurs, tout ce qui est en moi meurt aussi »_

---

### ❌ 5 exemples de la vraie vie (Composition)

#### 1️⃣ Maison — Pièces

- Une maison **est composée de pièces**
- Si la maison est détruite :
  - les pièces **n’existent plus comme pièces de cette maison**

❌ **Composition**

---

#### 2️⃣ Corps humain — Cœur

- Un corps **a un cœur**
- Sans corps :
  - le cœur n’a plus de sens comme organe vivant

❌ **Composition**

---

#### 3️⃣ Voiture — Moteur

- Une voiture **est composée d’un moteur**
- Si la voiture est détruite :
  - le moteur n’a plus son rôle dans cette voiture

❌ **Composition**

---

#### 4️⃣ Compte bancaire — Transactions

- Un compte **contient des transactions**
- Si le compte est supprimé :
  - les transactions disparaissent avec

❌ **Composition**

---

#### 5️⃣ Commande — Articles

- Une commande **est composée d’articles**
- Sans commande :
  - les articles de cette commande n’existent plus

❌ **Composition**

---

#### 🧠 Résumé Composition

👉 Les objets sont **dépendants**
👉 Relation **forte**
👉 Si le parent disparaît → l’enfant disparaît

---

## 🎯 4. Astuce MÉGA SIMPLE pour ne plus confondre

Pose-toi **UNE seule question** :

> ❓ **Si l’objet A disparaît, est-ce que l’objet B peut encore exister ?**

- ✅ **OUI** → **Agrégation**
- ❌ **NON** → **Composition**

---

## 🖼️ 5. Image mentale (très importante)

- **Agrégation** 🧩 → des **Lego posés ensemble**
- **Composition** 🧱 → du **béton coulé ensemble**
