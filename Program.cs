//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CMP1903M_Assessment_1_Base_Code;



namespace CMP1903M_Assessment_1_Base_Code
{ 
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            static void choice()
            {
                //var path = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)
                var path = Environment.CurrentDirectory;

                Console.WriteLine(path);
                Console.WriteLine("1. Do you want to enter the text via the keyboard?");
                Console.WriteLine("2. Do you want to read the text from a file?");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Input Input = new Input();
                    Input.manualTextInput();
                }   
                else if (userInput == "2")
                {
                    Input Input = new Input();
                    Input.fileTextInput("/Users/seanquinton/Documents/University/OOP/OOP_assessment1/CMP1903M Assessment 1 Test File.txt");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    choice();
                }
            }
            choice();
            //Get either manually entered text, or text from a file


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }
        
        
    
    }
}
