using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGenerator
{
    public class heuuuuu
    {
        static Random rnd = new Random();
        public List<int> GenerateGreatNumbers()
        {
            
            // Pathern => int1 * int2 - int3 + int4 / int5
            int int1;   // Premier chiffre
            int int2;   // Multiplié par le deuxième
            int int3;   // Soustrait par le troisième   => Test positif
            int int4;   // Additionné par le quatrième
            int int5;   // Divisé par le cinquième      => Test entier
            int resultFois;
            int resultMoins;
            int resultPlus;
            int Mathador;
            int incr = 0;
            do
            {
                int1 = rnd.Next(1, 12);
                int2 = rnd.Next(1, 12);
                resultFois = int1 * int2;           // Obligatoirement un entier postif
                do
                {                                // Test et trouve un chiffre qui va soustraire le premier résultat en étant positif
                    int3 = rnd.Next(1, 20);
                }
                while (resultFois - int3 < 1);
                resultMoins = resultFois - int3;    // Stocke le deuxième résulat
                int4 = rnd.Next(1, 20);
                resultPlus = resultMoins + int4;
                int5 = rnd.Next(1, 20);
                Console.WriteLine(incr++);
            } while (resultPlus % int5 != 0);
            Mathador = resultPlus / int5;

            List<int> numb = new List<int>();
            numb.Add(int1);
            numb.Add(int2);
            numb.Add(int3);
            numb.Add(int4);
            numb.Add(int5);
            numb.Add(Mathador);

            return numb;
        }

        public void CreateFileJson()
        {
            List<int> numb1 = GenerateGreatNumbers();
            List<int> numb2 = GenerateGreatNumbers();
            List<int> numb3 = GenerateGreatNumbers();
            List<int> numb4 = GenerateGreatNumbers();
            List<int> numb5 = GenerateGreatNumbers();
            List<List<int>> numbers = new List<List<int>> { numb1, numb2, numb3, numb4, numb5};

            string json = JsonConvert.SerializeObject(numbers, Formatting.Indented);

            //write string to file
            System.IO.File.WriteAllText(@"./game.txt", json);
        }
    }
}
