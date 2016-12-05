using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Corta_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int ma = 0, me = 0, num = 0;
            Console.WriteLine("Cuantos numeros va ingresar");
            int numeros = int.Parse(Console.ReadLine());
            for (int i = 0; i < numeros; i++)
            {
                Console.WriteLine("Digite un numero: ");
                num = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    ma = num;
                    me = num;
                }
                if (num > ma) { ma = num; }
                if (num < me) { me = num; }



                num = 0;
            }

            Console.WriteLine(" numero mayor es: " + ma);
            Console.WriteLine(" numero menor es: " + me);

        }
    }
}
