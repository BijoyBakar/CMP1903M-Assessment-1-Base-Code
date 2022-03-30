using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("Please enter the text you would like analysed: ");
            
            // add exception handling here in the case of unexpected input such as a null string
            string text = Console.ReadLine();
            
            // also add functionality to detect end of sentence by '*'
            return text;
        }
        
        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName) //harry.txt
        {
            
            // add exception handling in the case the file doesn't exist or the file type is not correct
            string errorMessage = ("Incorrect file, please try again");
            
            string file = File.ReadAllText(@$"../../../../{fileName}");
            //Console.WriteLine(file);
            return file;
        }
    }
}
