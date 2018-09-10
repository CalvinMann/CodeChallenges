using System;
using System.Linq;

namespace PigLatinTranslation
{
    class Program
    {
        //Translate english word to pig latin
        //instructions are here 

        readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        static void Main(string[] args)
        {


          
        }

        public string TranslateWord(string word)
        {
            char[] charsInWord = word.ToCharArray();

            for(int i = 0; i < charsInWord.Length - 1; i = 0)
            {
                if(vowels.Contains(charsInWord[i]) )
                {
                    if(i == 0)
                    {
                        //add yay and return
                        return word + "yay";
                    }
                    else
                    {
                        //convert to string and add ay

                        return "" + "ay";
                    }
                }
                else
                {
                    // move to the end of the array
                }
            }

            return "";
        }

        public string TranslateSentence(string sentence)
        {
            return "";
        }
    }
}
