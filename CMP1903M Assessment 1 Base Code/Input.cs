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
        //Handles the text input for Assessment 1
        string text;
        string textfile;
        
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        
        public string manualTextInput()
        {
            Console.WriteLine("Please enter the text you would like analysed: ");
            text = Console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        /// <summary>
        /// first attempt
        /// </summary>/Users/bijoybakar/Desktop/OOP\ Assignment\ 17th/CMP1903M\ Assessment\ 1\ Base\ Code/CMP1903M\ Assessment\ 1\ Base\ Code/Assignmenttextfile.txt
        /// <param name="fileName"></param>
        /// <returns></returns>
        
        public string fileTextInput(string fileName) //harry.txt
        {
            
            string file = File.ReadAllText(@$"../../../../{fileName}");
            Console.WriteLine(file);
            return file;
        }

    }
}
