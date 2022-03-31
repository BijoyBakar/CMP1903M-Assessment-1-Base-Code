//Base code project for CMP1903M Assessment 1
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    /// <summary>
    /// this is the main class which controls the outputting of the other files. Every other file and method is called her and printed out
    /// </summary>
    class Program
    {

        static void Main()
        {

            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            string text = "hello";
            // while loops has been used for error handling purpose to make the user re enter if they press wrong option
            while (true)
            {
                // user is giving options
                Console.WriteLine("Please pick one of the following options");
                Console.WriteLine("1) Manual text analyser");
                Console.WriteLine("2) Analyse from file");
                Console.WriteLine("3) Exit program");
                string userchoice = Console.ReadLine();
                // if 1 then goes directly to manual text input
                if (userchoice == "1")
                {
                    Input userInput = new Input();
                    text = userInput.manualTextInput();

                }
                // if 2 then goes directly to file input
                else if (userchoice == "2")
                {
                    Input userInput = new Input();
                    Console.WriteLine("please enter the filename");
                    string filename = Console.ReadLine();
                    text = userInput.fileTextInput(filename);

                }
                // if 3 makes the user exit the program
                else if (userchoice=="3")
                {
                    Console.WriteLine("Program closed");
                    break;
                }
                // blank space makes the user re enter the value
                else if (userchoice == "")
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                // anything else also makes them re enter the value 
                else
                {
                    Console.WriteLine("Invalid input");
                    continue;
                    
                }
                
                Analyse analyse = new Analyse();
                //Pass the text input to the 'analyseText' method
                parameters = analyse.analyseText(text);
            
                //Report the results of the analysis
                Report report = new Report(text,parameters);
                report.OutputConsole();
                
                Console.WriteLine("  ");

                //prints out the long words from analysis 
                Analyse LongWords = new Analyse();
                LongWords.Longwords(text);

                Console.WriteLine("");

                //Gets the frequency of individual letters from analysis 
                Analyse Letters = new Analyse();
                Letters.FrequencyLetters(text);
                
 

            }

        }
    }
}
