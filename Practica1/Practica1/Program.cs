using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno _alumno = new Alumno();
            Profesor _profesor = new Profesor();
            _alumno.edad = 17;
            _alumno.nombre = "daniela";
            _alumno.NoControl = 0694;

            _profesor.edad = 34;
            _profesor.nombre = "Mene";
            _profesor.Sueldo = 1600;

            Console.WriteLine("La edad del alumno es: {0} su nombre es {1} y su no de Control es {2}", _alumno.edad, _alumno.nombre, _alumno.NoControl);
            Console.WriteLine("La edad del maestro es: {0} su nombre es {1} y su sueldo es {2}", _profesor.edad, _profesor.nombre, _profesor.Sueldo);
            Console.ReadKey();
        }

    }
}
