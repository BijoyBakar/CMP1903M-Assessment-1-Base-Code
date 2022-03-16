//Base code project for CMP1903M Assessment 1
using System;
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

            Console.WriteLine("Please pick one of the following options");
            Console.WriteLine("1) Manual text analyser");
            Console.WriteLine("2) Analyse from file");
            string userinput = Console.ReadLine();
            if (userinput == "1")
            {

            }
            else if (userinput == "2")
            {

            }
            else
            {
                Console.WriteLine("Invalid input");
            }


            //Create 'Input' object
            //Get either manually entered text, or text from a file


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}
