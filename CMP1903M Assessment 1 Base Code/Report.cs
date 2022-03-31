using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;



namespace CMP1903M_Assessment_1_Base_Code
{
    /// <summary>
    /// This class is responsible for outputting the sentence count etc.. 
    /// </summary>
    class Report
    {
        
        List<int> Parameters;
       

        public Report (string text,  List<int> parameters)
        {
            Parameters = parameters;
            Parameters.ToString();

        }
        
        public void OutputConsole()
        {
            // each of the values for the sentence count etc is printed out along side the values which i have gotten from the analysis file 

            List<string> report = new List<string>()
            {
                "Number of sentences entered: " + Parameters[0], 
                "Number of vowels: " + Parameters[1],
                "Number of consantants: " + Parameters[2],
                "Number of upper case letters: " + Parameters[3], 
                "Number of lower case letters: " + Parameters[4], 
                "Total characters: " + Parameters[5] };
            foreach(string reports in report)
            {
                Console.WriteLine(reports);
            }
           
        }
        
    }
    
    }

    





