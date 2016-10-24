using System;
//using 

namespace HelloWorld
{
    public class HomeWork
    {
        public string SentenceCase(string[] words)
        {
            string result = "";
            int i;

            if (words.Length > 0)
            {
                
                for (i=0; i < words.Length; i++)
                {
                    
                    if (WordValidation(words[i]))
                    {
                        result = string.Concat(string.Concat(result, " "), WordFirstUpper(WordToLowerCase(words[i])));

                    }
                }
                
            }
            
            return result.Substring(1, result.Length - 1);
        }

        private string WordToLowerCase(string word)
        {
            return word.ToLower();
        }

        public string WordFirstUpper(string word)
        {
            if (word.Length != 1)
            {
                return word.Substring(0, 1).ToUpper() + word.Substring(1, word.Length-1);
            }
            else
            {
                return word.Substring(0, 1).ToUpper();
            }
        }

        private bool WordValidation(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class HomeWorkV2 : HomeWork
    {

        public string MaxSymbol(string word)
        {
            SymbolHistogram wsd = new SymbolHistogram();

            wsd.LoadHistogram(word);


            return wsd.Result();
        }
    }




    
}


