using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Corta_2
{
    class Program
    {
        static void Main(string[] args)
        {/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

            /*
                Tarea Corta 2
                Estudiante: [Jose Carlos Acuna Rojas]

                Enunciado:
                Escriba una funcion que le de vuelta a una lista, debe imprimir primero la lista original, y luego imprimir la lista invertida.
                Preferiblemente, darle vuelta a la lista sin crear una lista nueva.
            */

            //Your code starts here
            
                //  Introducir en un array un grupo de numeros, para obtener la lista de manera original y luego invertir cada uno de sus valores asi que si el primer digito en la original ahora es el ultimo en la lista invertida
                //considero que mi conocimiento no es el mejor en este codigo pero creo que es un codigo que funciona para lo que se le asigno y que es la manera que veo que es eficaz de resolverlo, posiblemente hay mas maneras pero de esta funcion desconozco totalmente si hay una manera mas optima, se que la hay pero la desconozco
                int[] list_numbers = new int[] { 3, 4, 5, 6, 52, 33, 12, 11, 23, 345, 435, 123, 233, 34, 8, 16, 486 };

            Console.Write("La lista original es: \n");

            for (int i=0;i<list_numbers.Length;i++)
            {
                Console.Write(list_numbers[i]+"\n");
                }
                Array.Reverse(list_numbers);
            Console.WriteLine("La lista invertida es: ");
            for (int i = 0; i < list_numbers.Length; i++)
            {
                Console.WriteLine(list_numbers[i]);

            }
                      
            Console.ReadKey();
            
        }
    }
}
