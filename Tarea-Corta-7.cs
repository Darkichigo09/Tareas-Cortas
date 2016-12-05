using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Corta_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int caracter1 = 0, caracter2 = 0, num = 0;//para efectos le pido al usuario que ingrese los datos antes de analizarlos
            Console.WriteLine("Cuantos numeros va ingresar");
            int numeros = int.Parse(Console.ReadLine());
            for (int i = 0; i < numeros; i++)//para no quemar la informacion 
            {
                Console.WriteLine("Digite un numero: ");
                num = int.Parse(Console.ReadLine());//un ciclo que analiza los caracteres numericos y coloca cuales son los caracteres mayormente repetidos

                if (i == 0)
                {
                    caracter1 = num;
                    caracter2 = num;
                }
                if (num > caracter1)
                {
                    caracter1 = num;
                }
                if (num < caracter2)
                {
                    caracter2 = num;
 }
                num = 0;
            }

            Console.WriteLine("["+caracter1+" , "+caracter2+"]");
            Console.ReadKey();
        }
    }
}
