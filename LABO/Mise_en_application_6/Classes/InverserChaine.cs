using System.Text;

namespace Mise_en_application_6.Classes
{
    public static class InverserChaine
    {
        public static string Inverser_Chaine(string chaine)
        {
            Stack<char> stackOfChar = new Stack<char>();

            foreach(char el in chaine)
            {
                stackOfChar.Push(el);
            }

            string reverseString = "";

            while(stackOfChar.Count != 0)
            {
                char str = stackOfChar.Pop();
                reverseString += str;
            }

            return reverseString;
        }
    }
}
