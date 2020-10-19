using System;
using System.Collections.Generic;

namespace Quete_Dictionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> frenchDictionary = new Dictionary<char, string>();
            frenchDictionary['a'] = "abeille";
            frenchDictionary['b'] = "brebis";
            frenchDictionary['c'] = "cadeau";

            Console.WriteLine("Dictionnaire :");

            // Parcourir le dictionnaire
            foreach (KeyValuePair<char, string> letter in frenchDictionary)
            {
                Console.WriteLine("Lettre : {0}, Valeur : {1}",
                    letter.Key, letter.Value);
            }

            //suppression de la lettre C
            frenchDictionary.Remove('c');


            Console.WriteLine("Dictionnaire 2 :");

            // Parcourir le dictionnaire
            foreach (KeyValuePair<char, string> letter in frenchDictionary)
            {
                Console.WriteLine("Lettre : {0}, Valeur : {1}",
                    letter.Key, letter.Value);
            }
        }
    }
}
