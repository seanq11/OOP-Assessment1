using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //loop the text
            int sentences = 0;
            foreach (char c in input)
            {
                if (c is '.')
                {
                    sentences++;

                }
            }
            //2. Number of vowels
            //string[] vowel_list = {"A","E","I","O","U","a","e","i","o","u"};
            int vowel_count = 0;
            int consonant_count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if ( input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U' || input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    vowel_count++;
                }
                //3. Number of consonants
                else if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
                {
                    consonant_count++;
                }
            }

            //4. Number of upper case letters
            int upper_count = 0;
            int lower_count = 0;
            foreach (char c in input)
            {
                if (Char.IsUpper(c) == true)
                {
                    upper_count++;
                }
                //5. Number of lower case letters
                else if (Char.IsLower(c) == true)
                {
                    lower_count++;
                }
            }
            
            //6. Word count
            string[] words = input.Split(' ','.','*',',');
            int word_count = 0;
            foreach (var word in words)
            {
                word_count++;
            }

            //Create file of big words
            List<string> long_words = new List<string>();
            int long_word_count = 0;
            foreach (var word in words)
            {
                if (word.Length >= 7)
                {
                    long_words.Add(word);
                }
            }
            foreach (var long_word in long_words)
            {
                long_word_count++;
            }

            Report Report = new Report();
            Report.longWordFile(long_words);
            Report Report2 = new Report();
            Report.dataReport(sentences, vowel_count, consonant_count, upper_count, lower_count,word_count,long_word_count);

            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            } 


            return values;
        }
    }
}
