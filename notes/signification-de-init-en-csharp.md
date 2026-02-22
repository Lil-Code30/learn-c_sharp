# Signification de init en C#

En C#, dans cette propriété :

```csharp
public double Area { get; init; }
```

`init` signifie que la propriété est **initialisable uniquement lors de la création de l’objet**, puis elle devient **immutable (non modifiable)**.

---

## 🔎 Différence entre `set` et `init`

### ✅ Avec `set`

```csharp
public double Area { get; set; }
```

Tu peux modifier la valeur **à tout moment** :

```csharp
var shape = new Shape();
shape.Area = 10;
shape.Area = 20; // ✅ autorisé
```

---

### ✅ Avec `init`

```csharp
public double Area { get; init; }
```

Tu peux définir la valeur **uniquement à l'initialisation** :

```csharp
var shape = new Shape { Area = 10 }; // ✅ OK
```

Mais après :

```csharp
shape.Area = 20; // ❌ Erreur de compilation
```

---

## 🧠 Pourquoi utiliser `init` ?

`init` (introduit en **C# 9**) permet de :

- Créer des objets **immutables**
- Éviter les modifications accidentelles
- Rendre ton code plus sûr
- Idéal pour les **DTO**, **records**, modèles backend

---

## 🔥 Exemple concret (clean backend style)

```csharp
public class Rectangle
{
    public double Width { get; init; }
    public double Height { get; init; }
    public double Area => Width * Height;
}

var rect = new Rectangle { Width = 5, Height = 4 };

// rect.Width = 10; ❌ Impossible
```

Ça force la création correcte dès le départ.

---

## 🎯 Résumé rapide

| Mot-clé | Modifiable après création ? |
| ------- | --------------------------- |
| `set`   | ✅ Oui                      |
| `init`  | ❌ Non                      |
