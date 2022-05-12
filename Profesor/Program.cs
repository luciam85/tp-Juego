using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    using System;

    public class EstudianteProfesorTest
    {
        public static void Main()
        {
            Persona miPersona = new Persona();
            miPersona.Saludar();

            Estudiante miEstudiante = new Estudiante();
            miEstudiante.SetEdad(21);
            miEstudiante.Saludar();
            miEstudiante.MostrarEdad();
            miEstudiante.Estudiar();

            Profesor miProfesor = new Profesor();
            miProfesor.SetEdad(30);
            miProfesor.Saludar();
            miProfesor.Explicar();
        }
    }

      
}
