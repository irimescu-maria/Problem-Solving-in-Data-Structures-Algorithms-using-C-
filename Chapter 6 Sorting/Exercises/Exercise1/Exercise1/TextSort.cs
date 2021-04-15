using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Given a text file, print the words with their frequency. Now print the kth words in term of frequency.
 */

namespace Exercise1
{
    public class TextSort
    {
        private string[] text;

        public TextSort(string[] txt)
        {
            text = txt;
        }


        public virtual void frequency()
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (wordFrequency.ContainsKey(text[i]))
                {
                    int value = wordFrequency[text[i]];
                    wordFrequency[text[i]] = value+1;
                }
                else
                {
                    wordFrequency.Add(text[i], 1);
                }
            }

            Console.WriteLine("The number of counts for each words are:");
            foreach (KeyValuePair<string, int> kvp in wordFrequency)
            {
                Console.WriteLine("Counts: " + kvp.Value + " for " + kvp.Key);           // Print the number of counts for each word
            }
            //Console.ReadKey();

        }
    }
}
