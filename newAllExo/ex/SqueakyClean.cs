namespace newAllExo.ex;

class SqueakyClean
{

    public static string Clean(string identifier)
    {
        string newIdentifier = "";
        char[] greekLetters = ['Α', 'Β', 'Γ', 'Δ', 'Ε', 'Ζ', 'Η', 'Θ', 'Ι', 'Κ', 'Λ', 'Μ', 'Ν', 'Ξ', 'Π', 'Ρ', 'Σ', 'Τ', 'Υ', 'Φ', 'Χ', 'Ψ', 'Ω', 'α', 'β', 'γ', 'δ', 'ε', 'ζ', 'η', 'θ', 'ι', 'κ', 'λ', 'μ', 'ν', 'ξ', 'π', 'ρ', 'σ', 'τ', 'υ', 'φ', 'χ', 'ψ', 'ω' ];

        for(int i = 0; i < identifier.Length; i++){

            if (identifier[i] == ' ') {
                newIdentifier += '_';
            } else if (identifier[i] == '\0') {
                newIdentifier += "CTRL";
            } else if (identifier[i] == '-')
            {
                char nextLetter = char.ToUpper(identifier[i + 1]);
                newIdentifier += nextLetter;
                i++;

            } else if (Array.Exists(greekLetters, letter => letter == identifier[i] )){
                continue;

                
                // Greek uppercase: U+0391–U+03A9
                // Greek lowercase: U+03B1–U+03C9
                /*
                if ((c >= '\u0391' && c <= '\u03A9') || (c >= '\u03B1' && c <= '\u03C9'))
                {
                    continue; // Skip Greek letters
                }
                */
            }else{
               newIdentifier += identifier[i];
           }
        }

        return newIdentifier;            
    }
}