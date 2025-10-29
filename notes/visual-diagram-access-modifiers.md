# visual diagram of C# access modifiers

visual diagram of C# access modifiers and who can access what

---

```
Access Levels in C#

+--------------------+-----------------------------+
| Modifier           | Accessible From             |
+--------------------+-----------------------------+
| public             | Anywhere                    |
+--------------------+-----------------------------+
| private            | Only inside the same class  |
+--------------------+-----------------------------+
| protected          | Same class + subclasses     |
+--------------------+-----------------------------+
| internal           | Anywhere in the same assembly|
+--------------------+-----------------------------+
| protected internal | Same assembly OR subclasses |
+--------------------+-----------------------------+
| private protected  | Subclasses in the same assembly only |
+--------------------+-----------------------------+
```

---

### **Diagrammatic view**

```
            +---------------------+
            |      public         | <- Everyone
            +---------------------+
            |     internal        | <- Same assembly only
            +---------------------+
            |    protected        | <- Class + Subclasses
            +---------------------+
            | protected internal  | <- Class + Subclasses OR same assembly
            +---------------------+
            | private protected   | <- Subclasses in same assembly only
            +---------------------+
            |      private        | <- Class only
            +---------------------+
```

---

### **Memory Tips:**

1. **Private** → most restrictive (class only)
2. **Protected** → adds inheritance
3. **Internal** → adds assembly-level access
4. **Public** → least restrictive (everyone)
5. **Protected internal** → “union”: subclass OR same assembly
6. **Private protected** → “intersection”: subclass AND same assembly

---
