using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    public class Estudiante : Persona
    {
        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }

        public void MostrarEdad()
        {
            Console.WriteLine("My edad es {0} ", edad);

        }
    }
}
