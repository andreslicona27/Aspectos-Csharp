using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Menu
    {
        public delegate void MyDelegate();


        // Constructores 
        public Menu(params string[] nombres)
        {

        }

        // PROPIEDADES 
       

        private string[] nombres;
        public string[] Nombres
        {
            set
            {
                Nombres = value;
            }
            get
            {
                return Nombres;
            }
        }


        // FUNCIONES
        public static void Inicio()
        {
            int opcCont = 1;
            string opcMenu;
            int result;
            string[] opciones;
            MyDelegate[] funciones;

            opciones = (new string[]
            {   
                "Calcular la media de notas de toda la tabla",
                "Media de un alumno",
                "Media de una asignatura",
                "Visualizar notas de un alumno",
                "Visualizar notas de una asignatura",
                "Nota máxima y mínima de un alumno",
                "Visualizar tabla completa" });
            funciones = new MyDelegate[]
            {
                Media,
                MediaAlumno,
                MediaAsignatura,
                NotasAlumno,
                NotasAsignatura,
                NotaMaxMin,
                TablaDeNotas

            };

            if (opciones.Length != funciones.Length)
            {
                Console.WriteLine("Hay un error con los parámetros.");
            }
            else
            {
                do
                {
                    opcCont = 1;
                    Console.WriteLine("\nMENU DE OPCIONES");
                    Array.ForEach(opciones, item => Console.WriteLine("{0}) {1}", opcCont++, item));
                    Console.WriteLine("{0}) Salir", opcCont);
                    opcMenu = Console.ReadLine();

                    if (int.TryParse(opcMenu, out result))
                    {
                        result = int.Parse(opcMenu);

                        if (result < opciones.Length + 1 && result >= 1)
                        {
                            funciones[result - 1]();
                        }
                        else if (result != opciones.Length + 1)
                        {
                            Console.WriteLine("Esa opción esta fuera de rango, intenta de nuevo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("La opción seleccionada tiene que ser un número.");
                    }


                } while (result != opciones.Length + 1);
            }

        }
   

        private static void Media()
        {
            Aula a = new Aula();
            a[2] = 12;
            //int sumatoria = 0;
            //for (int x = 0; x < arreglo.length; x++)
            //{
            //    sumatoria += arreglo[x];
            //}
            //double media = sumatoria / arreglo.length;
            //Console.WriteLine("La media de todas las notas es de: {0}", media);

        }

        private static void MediaAlumno()
        {

        }

        private static void MediaAsignatura()
        {

        }

        private static void NotasAlumno()
        {

        }

        private static void NotasAsignatura()
        {

        }

        private static void NotaMaxMin()
        {

        }

        private static void TablaDeNotas()
        {

        }

    }


}

