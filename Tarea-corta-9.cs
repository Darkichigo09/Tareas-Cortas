using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Corta_9
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
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.\\
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

            /*
                Tarea Corta 1
                Estudiante: [Jose Carlos Acuna Rojas]

                Enunciado:
                Rotacion de palabras en un string: Al recibir un string, se debe retornar un nuevo string en el que se roten sus palabras.
                Ejemplo:
                "the sky is blue" -> "blue is sky the"


            */

            // Crea e inicializa un arreglo y lo instancia.
            Array myArray = Array.CreateInstance(typeof(String), 8);
            myArray.SetValue("The", 0);
            myArray.SetValue("sky", 1);
            myArray.SetValue("is", 2);
            myArray.SetValue("blue", 3);
            myArray.SetValue("and", 4);
            myArray.SetValue("the", 5);
            myArray.SetValue("clouds", 6);
            myArray.SetValue("white", 7);
           

            // Despliega el orden original del arreglo.
            Console.WriteLine("El arreglo Inicial seria el siguiente: ");
            PrintIndexAndValues(myArray);

            // Ahora invierte el arreglo utilizando el reverse.
            Array.Reverse(myArray);

            // Despliega el arreglo invertido.
            Console.WriteLine("El arreglo invertido es: ");
            PrintIndexAndValues(myArray);
            Console.ReadKey();
            //este metodo lo busque en internet y fue sencillo entenderlo por eso me parecio idoneo utilizarlo
        }


        public static void PrintIndexAndValues(Array myArray)
        {
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
                Console.WriteLine("\t{1}", i, myArray.GetValue(i));
        }
    }
}
    
