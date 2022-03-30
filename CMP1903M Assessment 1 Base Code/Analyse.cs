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
        
        // since these are constants, I changed the status of these variables to 'readonly'
        // also implemented the naming convention of using '_' before the variable to distinguish it as a private variable
        private readonly char[] _sentence = {'.','?','!'};
        private readonly char[] _vowelsLowerCase = {'a','e','i','o','u'};
        private readonly char[] _vowelsUpperCase = {'A','E','I','O','U'};
        private readonly char[] _consonantsLowerCase = {'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z', 'w', 'y'};
        private readonly char[] _consonantsUpperCase = {'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'X', 'Z', 'W', 'Y'};

        // these variables have been changed to private to ensure encapsulation
        private int _sentenceCount = 0;
        private int _uppercaseVowelCount = 0;
        private int _lowercaseVowelCount = 0;
        private int _lowercaseConsonantCount = 0;
        private int _uppercaseConsonantCount = 0;
        
        private int _lowercaseLetterCount = 0;
        private int _uppercaseLetterCount = 0;
        
        private int _totalCharacters = 0;
        
        // a method that takes in a string text and returns a list of 5 integer elements
        public List<int> AnalyseText(string input)
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
                if (_sentence.Contains (i))
                {
                    _sentenceCount++;
                }
                if (_vowelsLowerCase.Contains(i))
                {
                    _lowercaseVowelCount++;
                }
                if (_vowelsUpperCase.Contains(i))
                {
                    _uppercaseVowelCount++;
                }
                if (_consonantsLowerCase.Contains(i))
                {
                    _lowercaseConsonantCount++;
                }
                if (_consonantsUpperCase.Contains(i))
                {
                    _uppercaseConsonantCount++;
                }

                _totalCharacters = _lowercaseVowelCount + _lowercaseConsonantCount + _uppercaseVowelCount + _uppercaseConsonantCount;
                
            }
            
            Console.WriteLine("Number of sentences entered = " + _sentenceCount);
            Console.WriteLine("Number of vowels = " + (_lowercaseVowelCount+_uppercaseVowelCount));
            Console.WriteLine("Number of consonants = " + (_lowercaseConsonantCount+_uppercaseConsonantCount));
            Console.WriteLine("Number of upper case letters = "+ (_uppercaseVowelCount+_uppercaseConsonantCount));
            Console.WriteLine("Number of lower case letters = "+(_lowercaseVowelCount+_lowercaseConsonantCount));
            Console.WriteLine("Total characters in the sentence is = "+_totalCharacters);
            
            return values;
        }
        public void FrequencyLetters(string text)
        {
                string lowercaseInput = text.ToLower();
                
                char chA = 'a';
                char chB = 'b';
                char chC= 'c';
                char chD= 'd';
                char chE= 'e';
                char chF= 'f';
                char chG= 'g';
                char chH= 'h';
                char chI= 'i';
                char chJ= 'j';
                char chK= 'k';
                char chL= 'l';
                char chM= 'm';
                char chN= 'n';
                char chO= 'o';
                char chP= 'p';
                char chQ= 'q';
                char chR= 'r';
                char chS= 's';
                char chT= 't';
                char chU= 'u';
                char chV= 'v';
                char chW= 'w';
                char chX= 'x';
                char chY= 'y';
                char chZ= 'z';
                
                int freqA = lowercaseInput.Count(f => (f == chA));
                int freqB = lowercaseInput.Count(f => (f == chB));
                int freqC = lowercaseInput.Count(f => (f == chC));
                int freqD = lowercaseInput.Count(f => (f == chD));
                int freqE = lowercaseInput.Count(f => (f == chE));
                int freqF = lowercaseInput.Count(f => (f == chF));
                int freqG = lowercaseInput.Count(f => (f == chG));
                int freqH = lowercaseInput.Count(f => (f == chH));
                int freqI = lowercaseInput.Count(f => (f == chI));
                int freqJ = lowercaseInput.Count(f => (f == chJ));
                int freqK = lowercaseInput.Count(f => (f == chK));
                int freqL = lowercaseInput.Count(f => (f == chL));
                int freqM = lowercaseInput.Count(f => (f == chM));
                int freqN = lowercaseInput.Count(f => (f == chN));
                int freqO = lowercaseInput.Count(f => (f == chO));
                int freqP = lowercaseInput.Count(f => (f == chP));
                int freqQ = lowercaseInput.Count(f => (f == chQ));
                int freqR = lowercaseInput.Count(f => (f == chR));
                int freqS = lowercaseInput.Count(f => (f == chS));
                int freqT = lowercaseInput.Count(f => (f == chT));
                int freqU = lowercaseInput.Count(f => (f == chU));
                int freqV = lowercaseInput.Count(f => (f == chV));
                int freqW = lowercaseInput.Count(f => (f == chW));
                int freqX = lowercaseInput.Count(f => (f == chX));
                int freqY = lowercaseInput.Count(f => (f == chY));
                int freqZ = lowercaseInput.Count(f => (f == chZ));

                Console.WriteLine("Here is the Frequency Analysis of the text: \n");
                Console.WriteLine("A = "+freqA);
                Console.WriteLine("B = "+freqB);
                Console.WriteLine("C = "+freqC);
                Console.WriteLine("D = "+freqD);
                Console.WriteLine("E = "+freqE);
                Console.WriteLine("F = "+freqF);
                Console.WriteLine("G = "+freqG);
                Console.WriteLine("H = "+freqH);
                Console.WriteLine("I = "+freqI);
                Console.WriteLine("J = "+freqJ);
                Console.WriteLine("K = "+freqK);
                Console.WriteLine("L = "+freqL);
                Console.WriteLine("M = "+freqM);
                Console.WriteLine("N = "+freqN);
                Console.WriteLine("O = "+freqO);
                Console.WriteLine("P = "+freqP);
                Console.WriteLine("Q = "+freqQ);
                Console.WriteLine("R = "+freqR);
                Console.WriteLine("S = "+freqS);
                Console.WriteLine("T = "+freqT);
                Console.WriteLine("U = "+freqU);
                Console.WriteLine("V = "+freqV);
                Console.WriteLine("W = "+freqW);
                Console.WriteLine("X = "+freqX);
                Console.WriteLine("Y = "+freqY);
                Console.WriteLine("Z = "+freqZ);
        }
    }
}
