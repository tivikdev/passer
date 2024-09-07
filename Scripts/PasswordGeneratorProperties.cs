using System.Collections;

namespace WinPasser.Scripts
{
    internal class PasswordGeneratorProperties: IEnumerable
    {
        public PasswordProperty Uppercase = new PasswordProperty() 
        {
            Characters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' }
        };
        public PasswordProperty Lowercase = new PasswordProperty()
        {
            Characters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }
        };
        public PasswordProperty Numbers = new PasswordProperty()
        {
            Characters = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }
        };
        public PasswordProperty Minus = new PasswordProperty()
        {
            Characters = new char[] { '-' }
        };
        public PasswordProperty Underscore = new PasswordProperty()
        {
            Characters = new char[] { '_' }
        };
        public PasswordProperty Brackets = new PasswordProperty()
        {
            Characters = new char[] {'(',')','<','>','{','}','[',']' }
        };
        public PasswordProperty SpecialCharacters = new PasswordProperty()
        {
            Characters = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', ':', '?', '/', '.', ','}
        };

        public IEnumerator GetEnumerator()
        {
            yield return Uppercase;
            yield return Lowercase;
            yield return Numbers;
            yield return Minus;
            yield return Underscore;
            yield return Brackets;
            yield return SpecialCharacters;
        }
    }
}
