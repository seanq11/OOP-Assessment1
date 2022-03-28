using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMP1903M_Assessment_1_Base_Code;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = " ";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("Enter the text you would like analysed sentence by sentence");
            Console.WriteLine("use (*) at the end of your final sentence to signal the end:");
            while(true)
            {
                char lastChar = text.Last();
                if (lastChar is '*')
                {
                    text = text.Remove(0, 2);
                    text = text.Remove(text.Length - 1, 1);
                    Console.WriteLine(text);
                    Analyse Analyse = new Analyse();
                    Analyse.analyseText(text);
                    break;
                }
                else
                {
                    string sentence = Console.ReadLine();
                    text = text + " ";
                    text = text + sentence;
                }
            }
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            //Read text file
            string fileText = System.IO.File.ReadAllText(fileName);
            Console.WriteLine(fileText);
            Analyse Analyse = new Analyse();
            Analyse.analyseText(fileText);
            return text;
        }

    }
}
