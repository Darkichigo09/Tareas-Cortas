using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Corta_3
{
    class Program
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
                Tarea Corta 3
                Estudiante: [Jose Carlos Acuna Rojas]

                Enunciado:
                Cree una funcion que identifique si un elemento existe en una lista, debe retornar la cantidad de veces que el elemento aparece en la lista, retornara 0 si no aparece.
            */
            /*Basicamente este codigo toma un string y lo que hace es buscar cada elemento para evaluar si es o no el elmento que se buscaba si lo encuentra suma uno al contador.
             * no se realmente si esta solucion es optima posiblemente hay otras mejores soluciones pero esta fue la que pense y que hasta donde la he probado funciona.
             */
            //Your code starts here
            public class elemento_encontrado
        {
     
            public int contadorelemento(string elemento)
            {
                int contelemento = 0;
                for (int i = 0; i < elemento.Length; i++)
                {
                    if (i == 0)
                    {
                        if (elemento[i] == elemento[i + 1])
                            contelemento++;
                        continue;

                    }
                    if (i == elemento.Length - 1)
                    {
                        if (elemento[i] != elemento[i - 1])
                            contelemento++;
                        continue;
                    }
                    if (elemento[i] != elemento[i - 1] || elemento[i] != elemento[i + 1])
                    {
                        contelemento++;
                        continue;
                    }

                }

                return contelemento;

            }



        }
            static void Main(string[] args)
            {
                elemento_encontrado elemento_aux = new elemento_encontrado();
                string aux = "HTHTHTHHTHHHTTHHTH";
                int val = elemento_aux.contadorelemento(aux);
                Console.WriteLine("Monto de elementos similares encontrados encontradas: {0}", val);
                Console.Read();


            }
        }
    }
    
