using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComercioPrueba
{
    class ChangeString
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar palabra: ");
            var word = Console.ReadLine();

            Console.WriteLine(build(word.ToString()));

            Console.ReadLine();
        }

        private static string build(string word)
        {
            string newWord = string.Empty;
            char[] character = word.ToCharArray();
            char[] newCharacter = new char[word.Length];

            string letters = getAbc();
            for (int i = 0; i < character.Length; i++)
            {
                char c = character[i];

                if (letters.IndexOf(c) > -1)
                {
                    c = getNextCharacter(c);
                }

                newCharacter[i] = c;

            }
            newWord = new string(newCharacter);
            return newWord;
        }

        private static string getAbc()
        {
            string letters = string.Empty;

            for (var letter = 'a'; letter <= 'z'; letter++)
            {
                letters = letters.ToString() + letter.ToString();

                if (letter == 'n')
                {
                    letters = letters.ToString() + 'ñ';

                }
            }

            return letters;
        }

        private static char getNextCharacter(char letter)
        {
            char newLetter;
            int pos;
            string letters = getAbc(); 

            if (letter == 'z')
            {
                newLetter = 'a';
            }
            else
            {
                pos = letters.IndexOf(letter);

                newLetter = char.Parse(letters.Substring(pos + 1, 1));
            }

            return newLetter;
        }
    }
}
