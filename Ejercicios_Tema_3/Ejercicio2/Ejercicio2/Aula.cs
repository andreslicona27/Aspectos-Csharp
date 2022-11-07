using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Aula
    {
        // CONSTRUCTORES
        public Aula(string[] nombres)
        {
            this.Nombres = nombres;
        }

        public Aula()
        {

        }

        // PROPIEDADES 

        // Esto es la indexación de la clase 
        private int[] clase = new int[100];
        public int this[int index]
        {
            set
            {
                clase[index] = value;
            }
            get
            {
                return clase[index];
            }
        }


        public int[,,,] notas;


        private string[] nombres;
        public string[] Nombres
        {
            set
            {
                foreach (var nombre in value)
                {
                    nombre.Trim();
                    nombre.ToUpper();
                }
                Nombres = value;
            }
            get
            {
                return Nombres;
            }
        }

        // FUNCIONES 




    }
}

