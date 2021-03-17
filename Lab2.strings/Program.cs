using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.strings
{
    class Program
    {
        static StreamReader filein = new StreamReader("Inlet.in");
        static StreamWriter fileout = new StreamWriter("outlet.out");

        static void Main(string[] args)
        {
            
            int n;
            int k;
            string[] lastWord;
            lastWord = DataEnter(out n, out k);
            string[] word = countLetters(lastWord, k);
            foreach (string s in word)
            fileout.WriteLine(s);
            fileout.Close();
            
        }
        static string [] DataEnter (out int n, out int k)
        {
            char[] sentSep = { '\n', '\r' };
            char[] wordSep = { ' ' };
            string[] sentence = filein.ReadToEnd().Split(sentSep, System.StringSplitOptions.RemoveEmptyEntries);
            n = sentence.Length-1;
            string[] searchedword = new string[n];
            k = Int32.Parse(sentence[n]);
            

            for (int i = 0; i < n; i++)
            {
                string[] wordAndSentences = sentence[i].Split(wordSep, System.StringSplitOptions.RemoveEmptyEntries); 
                if (wordAndSentences.Length >= 1)
                {
                    searchedword[i] = wordAndSentences[wordAndSentences.Length - 1];
                   
                }
                else
                    searchedword[i] = ""; //в моем варианте эта часть не обязательна, так как я ищу последнее, а не предпоследнее слово
            }
            return searchedword;
    }

        private static string [] countLetters(string[] lastWord, int k)
        {
            string[] word = new string[lastWord.Length];
            for (int i = 0; i < lastWord.Length; i++) 
            {
                if (lastWord[i].Length <= k)
                    word[i] = "Empty";
                else
                    word[i] = lastWord[i];
            }
            return word;
         }
    }}


