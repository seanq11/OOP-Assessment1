using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        public void dataReport(int sentences,int vowels, int consonants, int upper, int lower, int words,int long_words)
        {
            // Write report to console
            Console.WriteLine($"Sentences: {sentences}");
            Console.WriteLine($"Words: {words}");
            Console.WriteLine($"Vowels: {vowels}");
            Console.WriteLine($"Consonants: {consonants}");
            Console.WriteLine($"Uppercase letters: {upper}");
            Console.WriteLine($"Lowercase letters: {lower}");
            Console.WriteLine($"Long words(7 letters or more): {long_words}");


        }

        // Report on long words
        public void longWordFile(List<string> word)
        {

            string fileName = @"/Users/seanquinton/Documents/University/OOP/OOP_assessment1/long words.txt";
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file
                // Write to file

                System.IO.File.WriteAllLines(fileName, word);



                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

    }
}

