using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mise_en_application_6.Classes
{
    public static class VerificationParentheses
    {
        public static bool VerifParentheses(string expression)
        {
            Stack<char> parentheses = new Stack<char>();

            foreach (char c in expression)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    parentheses.Push(c);
                }else if (c == ')' || c == '}' || c == ']')
                {
                    if(parentheses.Count == 0)
                    {
                        return false;
                    }

                    char topChar = parentheses.Pop();

                    if(c == topChar)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (parentheses.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
