using System;

namespace Task_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            string wrongstr = "exTensiON claSSi staTIc OLMalIdiR";            
            Console.WriteLine(wrongstr.IsCapitalized());


            string words = "Hello How are You.";
            Console.WriteLine(words.FindWord("are"));

        }
    }
}
