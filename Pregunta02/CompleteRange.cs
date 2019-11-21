using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta02
{
    class CompleteRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de numeros");
            var quantityNumbers = int.Parse(Console.ReadLine());
            List<int> listNumbers = new List<int>();

            for (var i = 1; i <= quantityNumbers; i++)
            {
                Console.Write("Ingrese el numero {0}:", i);
                var number = int.Parse(Console.ReadLine());
                listNumbers.Add(number);
            }

            build(listNumbers).ForEach(Console.WriteLine);

            Console.ReadLine();
        }

        private static List<int> build(List<int> listNumbers)
        {
            List<int> newList = new List<int>();
            int k = 1;
            listNumbers.Sort();

            for (int i = 0; i < listNumbers.Count; i++)
            {
                for (int j=k; j < listNumbers[i] + 1; j++)
                {
                    newList.Add(j);
                }

                k = listNumbers[i] + 1;
            }

            return newList;
        }
    }
}
