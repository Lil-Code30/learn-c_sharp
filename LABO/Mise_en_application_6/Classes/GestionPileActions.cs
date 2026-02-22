namespace Mise_en_application_6.Classes
{
    public class GestionPileActions
    {
        public static Stack<string> pileUndo = new Stack<string>();
        public static Stack<string> pileRedo = new Stack<string>();
        public static string textActuel = "";

        public static string GererHistorique(string action, string texte = null)
        {
            switch (action)
            {
                case "ajouter":
                    pileUndo.Push(textActuel);
                    textActuel = textActuel + texte;
                    pileRedo.Clear();
                    break;

                case "undo":
                    if(pileUndo.Count != 0)
                    {
                        pileRedo.Push(textActuel);
                        textActuel = pileUndo.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Rien à annuler");
                    }
                    break;
                case "redo":
                    if (pileRedo.Count != 0)
                    {
                        pileUndo.Push(textActuel);
                        textActuel = pileRedo.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Rien à refaire");
                    }
                    break;

                default:
                    Console.WriteLine("Option Invalide");
                    break;
            }

            return textActuel;
        }
    }
}
