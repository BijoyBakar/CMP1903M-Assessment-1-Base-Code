﻿using System;
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
            Analyse statistics = new Analyse();
            statistics.analyseText(text);
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file

        
        public string fileTextInput(string fileName) //harry.txt
        {
            string Error = ("Incorrect file, please try again");
            
            string file = File.ReadAllText(@$"../../../../{fileName}");
            Console.WriteLine(file);
            return file;
        }

    }
}