using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Juego
{
    using System;
    public class ConstructoresDestructores
    {
        public static void Main(string[] args)
        {
            int total = 3;
            Persona[] personas = new Persona[total];

            for (int i = 0; i < total; i++)
            {
                personas[i] = new Persona(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(personas[i].ToString());
            }
        }

        public class Persona
        {
            public string Nombre { get; set; }

            public Persona(string nombre)
            {
                Nombre = nombre;
            }

            public override string ToString()
            {
                return "¡Hola! Mi nombre es " + Nombre;
            }

            ~Persona()
            {
                Nombre = string.Empty;
            }
        }
    }
}
