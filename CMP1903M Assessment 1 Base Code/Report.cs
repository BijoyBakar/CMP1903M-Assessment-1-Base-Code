using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        public void outputConsole(string text)
        {
            string [] words = text.Split(new[] { " " },StringSplitOptions.None);
            string word = "";
            int length = 7;
            Console.WriteLine("The long words are : ");
            foreach (string s in words.Distinct())
            {
                if (s.Length > length)
                {
                    Console.WriteLine(s);
                }
                
            }
            


        }
        

    }
}
