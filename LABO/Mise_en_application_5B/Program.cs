

// Exercice 01 : Recherche linéaire
static int LinearSearch(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target)
        {
            return i;
        }
    }
    
    return -1;
}

// Exercice 05 : Recherche d’un élément minimum dans un tableau

static int MinElement(int[] arr)
{
    int min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }

    return min;
}

// Exercice 07 : Recherche du premier et du dernier indice d’une valeur
static (int, int) FindFirstLast(int[] arr, int target)
{
    int first = FindFirst(arr, target);
    int last = FindLast(arr, target);
    return (first, last);
}

static int FindFirst(int[] arr, int target)
{
    int min = 0;
    int max = arr.Length - 1;
    int result = -1;

    while (min <= max)
    {
        int mid = (min + max) / 2;
        if (arr[mid] == target)
        {
            result = mid;
            max = mid - 1;
        }else if (arr[min] < target)
        {
            min = mid + 1;
        }
        else
        {
            max = mid - 1;
        }
    }
    return result;
}

static int FindLast(int[] arr, int target)
{
    int min = 0;
    int max = arr.Length - 1;
    int result = 1;

    while (min <= max)
    {
        int mid = (min + max) / 2;

        if (arr[min] == target)
        {
            result = mid;
            min = mid + 1;
        }else if (arr[mid] < target)
        {
            min = mid + 1;
        }else
        {
            max = mid - 1;
        }
    }
    
    return result;
}

// Exercice 09 : Recherche de la médiane dans un tableau non trié

// Exercice 11 : Vérification si un tableau est trié
static bool IsSorted(int[] arr, int n)
{
    for (int i = 0; i <= n - 1; i++)
    {
        if (arr[i] > arr[i + 1])
        {
            return false;
        }
    }
    
    return true;
}