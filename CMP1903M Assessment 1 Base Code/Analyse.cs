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
        char [] sentence = {'.','?','!'};
        char[] VowelsLowerCase = {'a','e','i','o','u'};
        char[] VowelsUpperCase = {'A','E','I','O','U'};
        char[] ConsonantsLowerCase = {'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z', 'w', 'y'};
        char[] ConsonantsUpperCase = {'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'X', 'Z', 'W', 'Y'};


        int SentenceCount = 0;
        int uppervowelcount = 0;
        int lowervowelcount = 0;
        int lowerconsonantcount = 0;
        int upperconsonantcount = 0;
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
                    lowervowelcount++;
                    
                }
                if (VowelsUpperCase.Contains(i))
                {
                    uppervowelcount++;
                    
                }
                if (ConsonantsLowerCase.Contains(i))
                {
                    lowerconsonantcount++;
                    
                }
                if (ConsonantsUpperCase.Contains(i))
                {
                    upperconsonantcount++;
                    
                }

                TotalCharacters = lowervowelcount + lowerconsonantcount + uppervowelcount + upperconsonantcount;
               
                




            }
            Console.WriteLine("Number of sentences entered = " + SentenceCount);
            Console.WriteLine("Number of vowels = " + (lowervowelcount+uppervowelcount));
            Console.WriteLine("Number of consonants = " + (lowerconsonantcount+upperconsonantcount));
            Console.WriteLine("Number of upper case letters = "+ (uppervowelcount+upperconsonantcount));
            Console.WriteLine("Number of lower case letters = "+(lowervowelcount+lowerconsonantcount));
            Console.WriteLine("Total characters in the sentence is = "+TotalCharacters);
            
            
    
            return values;
            
            
            
        }
        
        
        
        
        public string FrequencyLetters(string text)
        {
            Console.WriteLine("Would like you view letter frequency ?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No");
            string userinput = Console.ReadLine();
            if (userinput == "1")
            {
                string input = text;
                string LowercaseInput = input.ToLower();
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
                

                int freqA = LowercaseInput.Count(f => (f == chA));
                int freqB = LowercaseInput.Count(f => (f == chB));
                int freqC = LowercaseInput.Count(f => (f == chC));
                int freqD = LowercaseInput.Count(f => (f == chD));
                int freqE = LowercaseInput.Count(f => (f == chE));
                int freqF = LowercaseInput.Count(f => (f == chF));
                int freqG = LowercaseInput.Count(f => (f == chG));
                int freqH= LowercaseInput.Count(f => (f == chH));
                int freqI = LowercaseInput.Count(f => (f == chI));
                int freqJ = LowercaseInput.Count(f => (f == chJ));
                int freqK= LowercaseInput.Count(f => (f == chK));
                int freqL= LowercaseInput.Count(f => (f == chL));
                int freqM= LowercaseInput.Count(f => (f == chM));
                int freqN = LowercaseInput.Count(f => (f == chN));
                int freqO= LowercaseInput.Count(f => (f == chO));
                int freqP = LowercaseInput.Count(f => (f == chP));
                int freqQ = LowercaseInput.Count(f => (f == chQ));
                int freqR = LowercaseInput.Count(f => (f == chR));
                int freqS = LowercaseInput.Count(f => (f == chS));
                int freqT= LowercaseInput.Count(f => (f == chT));
                int freqU = LowercaseInput.Count(f => (f == chU));
                int freqV = LowercaseInput.Count(f => (f == chV));
                int freqW = LowercaseInput.Count(f => (f == chW));
                int freqX = LowercaseInput.Count(f => (f == chX));
                int freqY = LowercaseInput.Count(f => (f == chY));
                int freqZ = LowercaseInput.Count(f => (f == chZ));


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
            else if (userinput == "2")
            {
                Console.WriteLine("Program closed");
                System.Environment.Exit(1);
                
                
            }






            return text;
        }
        
        
        
    }
    
    
}
