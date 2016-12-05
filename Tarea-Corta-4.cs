using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Corta_4
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
                Tarea Corta 4
                Estudiante: [Your Name]

                Enunciado:
                Haga una funcion que identifique si una cadena de caracteres es un palindromo. 
                La funcion debe recibir un string con la palabra y retornar un booleano que indique si es un palindromo o no
                Palindromo: https://es.wikipedia.org/wiki/Pal%C3%ADndromo
            */

            //Your code starts here
            /*para saber si la palabra es palindroma se debe de realizar una funcion que recorra el string y que despues le de vueta al striny 
             lo compare para ver si los resultados son iguales si lo son es palindroma si no no lo es
             esta solucion es la que haye optima ya que me muestra la palabra invertida por si hay algun error y 
             siento es optima porque utiliza la misma libreria que trae visual por lo que lo hace hasta cierto punto 
             funcional y optimo*/

            string palabra1 = "", palabra2 = "";
            string aux = "";
            int i = 0, tl = 0;
            Console.Write("Ingrese la cadena de caracteres: ");
            palabra1 = Console.ReadLine();
            tl = palabra1.Length;
            for (i = tl - 1; i >= 0; i--)
            {
                aux = palabra1.Substring(i, 1);
                palabra2 = palabra2 + aux;
            }

            Console.Write("\nPalabra invertida  : " + palabra2);
            if (palabra1.Equals(palabra2))
            {
                Console.WriteLine("\nAl invertirla el resultado es igual por lo tanto es palindroma");
            }
            else
            {
                Console.WriteLine("\nNo es palindroma forma otra palabra");
            }
            Console.ReadKey();
        }
    }
}
