using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Corta_6
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
	Tarea Corta 6
	Estudiante: [Jose Carlos Acuña Rojas]
	
	Enunciado:
	El palindromo mas corto, 
	Dado un string S, usted debe formar un palindromo al agregarle caracteres al final, forme el palindromo mas corto posible en base al string S recibido
	"aace" -> aacecaa
	"abcd" -> "abcdcba"
*/
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
