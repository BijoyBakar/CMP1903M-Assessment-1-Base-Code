using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text
        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        char [] sentence = {'.'};
        char[] VowelsLowerCase = {'a','e','i','o','u'};
        char[] VowelUpperCase = {'A','E','I','O','U'};
        char[] ConsonantsLowerCase = {'b', 'b', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z', 'w', 'y'};
        char[] ConsonantsUpperCase = {'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'X', 'Z', 'W', 'Y'};
        char[] lettersLowerCase= {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        char[] lettersUpperCase = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

        int SentenceCount = 0;
        int VowelCount = 0;
        int ConsonantsCount = 0;
        int LettersLowerCount = 0;
        int LettersUpperCount = 0;
        int TotalCharacters;
        
        public List<int> analyseText(string input)
        {
            
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }
            
            foreach (char i in input)
            {
                if (sentence.Contains (i))
                {
                    SentenceCount++;
                    
                }
                if (VowelsLowerCase.Contains(i))
                {
                    VowelCount++;
                    
                }
                if (VowelUpperCase.Contains(i))
                {
                    VowelCount++;
                    
                }
                if (ConsonantsLowerCase.Contains(i))
                {
                    ConsonantsCount++;
                    
                }
                if (ConsonantsUpperCase.Contains(i))
                {
                    ConsonantsCount++;
                    
                }
                if (lettersLowerCase.Contains(i))
                {
                    LettersLowerCount++;
                    
                }
                if (lettersUpperCase.Contains(i))
                {
                    LettersUpperCount++;
                    
                }

                TotalCharacters = (LettersUpperCount + LettersLowerCount + VowelCount + ConsonantsCount + SentenceCount);
                





            }
            Console.WriteLine("Number of sentences entered = " + SentenceCount);
            Console.WriteLine("Number of vowels = " + VowelCount);
            Console.WriteLine("Number of consonants = " + ConsonantsCount);
            Console.WriteLine("Number of upper case letters = "+ LettersUpperCount);
            Console.WriteLine("Number of lower case letters = "+LettersLowerCount);
            Console.WriteLine("Total characters in the sentence is = "+TotalCharacters);
            

            return values;
            
            
        }
        
        
    }
    
    
}
