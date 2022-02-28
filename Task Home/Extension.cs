using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Home
{
    static class Extension
    {
        public static string IsCapitalized(this string word)
        {
            string text = " ";
            word = word.ToLower();
            string[] words = word.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i][0].ToString().ToUpper() + words[i].Substring(1);
            }
            text = string.Join(" ", words);
            return text;
        }


        public static bool FindWord(this string words, string search)
        {
            string[] word = words.Split(' ');
            foreach (string item in word)
            {
                if (item == search)
                {
                    return true;
                }                
            }
            return false;
        }
    }
}
