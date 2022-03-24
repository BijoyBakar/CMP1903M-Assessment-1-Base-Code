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
            List<string> word = new List<string>();
            int length = 7;
            Console.WriteLine("The long words are : ");

            foreach (string s in words.Distinct())
            {
                string longword=(s.Trim( new Char[] { ' ', '*', '.',','} ));
                if (longword.Length > length)
                {
                    word.Add(longword);
                    Console.WriteLine(longword);

                }


            }

            File.WriteAllLines(@$"../../../../NewFile.txt",word);
            Console.WriteLine(" ");
            Console.WriteLine("The long words have been added to NewFile.txt file");

        }



        }
        

    
}
