using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Corta_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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
                Escriba una funcion que retorne el elemento mas grande de una lista no ordenada	
            */

           
            //  Dentro de un array de i cantidad de numeros dentro del array la funcion tomara el elemento mayor,
            //mostrara la lista y tomara el numero mayor y lo imprime, lo hice de esta manera ya que vi que era la solucion mas optima
            //ya que incluye poco codigo y utiliza la  libreria collection que esta por defecto al abrir un nuevo poryecto, y no es complicado
            //otra solucion mas larga seria asignar a una variable int un numero en este caso 1 y que con un for se recorra todo un arreglo y si el numero en alguna posicion es mayor al int que lo asigne, y asi por todo el array.
            //Your code starts here

            int[] list_number = new int[] { 3, 4, 5, 6, 22, 33, 22, 11, 23, 345, 4535, 123, 233, 34, 3 };
            Console.WriteLine("La lista de numeros es la siguiente:", list_number[0]);
                Array.Sort(list_number);
                Array.Reverse(list_number);
                Console.WriteLine("El numero mayor es: " + list_number[0]);
                Console.WriteLine();
            Console.ReadKey();
        }
    }
}
