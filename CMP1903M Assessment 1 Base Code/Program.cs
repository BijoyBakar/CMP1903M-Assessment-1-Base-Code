//Base code project for CMP1903M Assessment 1
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            string text = "hello";

            Console.WriteLine("Please pick one of the following options");
            Console.WriteLine("1) Manual text analyser");
            Console.WriteLine("2) Analyse from file");
            string userchoice = Console.ReadLine();

            if (userchoice == "1")
            {
                Input userInput = new Input();
                text = userInput.manualTextInput();

            }
            else if (userchoice == "2")
            {
                Input userInput = new Input();
                Console.WriteLine("please enter the filename");
                string filename = Console.ReadLine(); 
                text = userInput.fileTextInput(filename);
                
            }

            else
            {
                Console.WriteLine("Invalid input");
            }


            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Analyse statistics = new Analyse();
            statistics.analyseText(text);

            Console.WriteLine("  ");
            
            //Report the results of the analysis
            Report LongWords = new Report();
            LongWords.outputConsole(text);

            Console.WriteLine("");
            
            //TO ADD: Get the frequency of individual letters?
            Analyse Letters = new Analyse();
            Letters.FrequencyLetters(text);


        }
        
        
        
    
    }
}
