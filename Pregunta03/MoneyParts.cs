using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta03
{
    class MoneyParts
    {
        private static void Main(string[] args)
        {
            Console.Write("Ingresar monto:");
            var money = double.Parse(Console.ReadLine());
            Build(money);
            Console.ReadLine();
        }

        private static void build(double money)
        {
            double[] den = {0.05,0.1,0.2,0.5,1,2,5,10,20,50,100,200};
            List<double> listNumbers = new List<double>();

            foreach (double d in den)
            {
                if (money >= d)
                {
                    double result = money/d;
                    if(!result.ToString().Contains(","))
                    { 
                        Console.WriteLine("Combinacion con ", d);

                        for (int i = 0; i < result; i++)
                        {
                            Console.WriteLine(d);
                        }
                    }
                }
            }
        }
    }
}
