using System;
using System.Collections.Generic;

namespace HomeworkDSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework_01();
        }

        private static void Homework_01()
        {
            string[] jedis = new string[10];
            jedis[0] = "Luke";
            jedis[1] = "Yoda";
            jedis[2] = "Mace Windu";
            jedis[3] = "Anakin";
            jedis[4] = "Obi Wan Kenobi";
            jedis[5] = "Count Doku";
            jedis[6] = "Ben Solo";
            jedis[7] = "Rey";
            jedis[8] = "Qui-Gon Jinn";
            jedis[9] = "Revan";

            for (int i = 0; i < jedis.Length; i++)
            {
                Console.WriteLine(jedis[i]);
            }


        }

        private static void Homework_02()
        {
            Stack<string> cars = new Stack<string>();
            cars.Push("BMW");
            cars.Push("Mercedes");
            cars.Push("Audi");
            cars.Push("Porsche");
            cars.Push("Volkswagen");
            cars.Push("Tesla");
            cars.Push("Volvo");
            cars.Push("Toyota");
            cars.Push("Mazda");
            cars.Push("Citroen");

            Console.WriteLine(cars.Contains("Aston Martin"));
            Console.WriteLine(cars.Contains("BMW"));
            foreach (var item in cars)
                Console.Write(item + ",");
        }
        private static void Homework_03()
        {
            Queue<string> strq = new Queue<string>();
            strq.Enqueue("H");
            strq.Enqueue("E");
            strq.Enqueue("L");
            strq.Enqueue("L");
            strq.Enqueue("O");
            strq.Enqueue("C");
            strq.Enqueue("3");
            strq.Enqueue("P");
            strq.Enqueue("O");

            foreach (var id in strq)
                Console.Write(id);
        }
        private static void Homework_04()
        {
            List<int> luckyNumbers = new List<int>();
            luckyNumbers.Add(15);
            luckyNumbers.Add(65);
            luckyNumbers.Add(4);
            luckyNumbers.Add(76);
            luckyNumbers.Add(41);
            luckyNumbers.Add(78);
            luckyNumbers.Add(42);
            luckyNumbers.Add(90);
            luckyNumbers.Add(123);
            luckyNumbers.Add(14);
            for (int i = 0; i < luckyNumbers.Count; i++)
                Console.WriteLine(luckyNumbers[i]);
            Console.WriteLine(luckyNumbers.Contains(200));
            Console.WriteLine(luckyNumbers.Contains(78));
        }













        


















    }
}
