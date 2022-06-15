using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _37_PlanillaDeNotasYAsistencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de planillas:");

            Console.WriteLine("Por favor ingrese 1 para ver la planilla de ASISTENCIAS o 2 para ver la de NOTAS: ");
            int asistencias = Convert.ToInt32(Console.ReadLine());
            int notas = Convert.ToInt32(Console.ReadLine());

            Materia Programacion1a = new Materia
            {
                Nombre = "Jose",
                Apellido = "Fernandez",
                DNI = 123484012,
                AñoDeCursada = 2018,
                Genero = "Masculino",
                NombreDelProfesor = "Maxi",
                NombreDeLaMateria = "Programacion 1",
                Turno = "Noche",
                NombreDelInstituto = "ESBA",
                NumeroDelDistrito = 15,

            };

            Materia Programacion1b = new Materia
            {
                Nombre ="Pablo",
                Apellido ="Gonzales",
                DNI =25427232,
                AñoDeCursada=2018,
                Genero = "Masculino",
                NombreDelProfesor="Maxi",
                NombreDeLaMateria = "Programacion 1",
                Turno = "Noche",
                NombreDelInstituto = "ESBA",
                NumeroDelDistrito = 15,
            };

            Materia Programacion1c = new Materia
            {
                Nombre ="Laura",
                Apellido ="Gomez",
                DNI =28432257,
                AñoDeCursada=2018,
                Genero="Femenino",
                NombreDelProfesor="Maxi",
                NombreDeLaMateria="Programacion 1",
                NombreDelInstituto="ESBA",
                NumeroDelDistrito=15,
            };

            Materia Programacion1d = new Materia
            {
                Nombre ="Jesica",
                Apellido ="Santillan",
                DNI =31250435,
                AñoDeCursada =2018,
                Genero ="Femenino",
                NombreDelProfesor ="Maxi",
                NombreDeLaMateria ="Programacion 1",
                NombreDelInstituto ="ESBA",
                NumeroDelDistrito =15,
            };

            Materia Matematicas1a = new Materia
            {
                Nombre = "Jesica",
                Apellido = "Santillan",
                DNI = 31250435,
                AñoDeCursada = 2018,
                Genero = "Femenino",
                NombreDelProfesor = "Fernando",
                NombreDeLaMateria = "Matematicas",
                NombreDelInstituto = "ESBA",
                NumeroDelDistrito = 15,
            };

            Materia Matematicas1b = new Materia
            {
                Nombre = "Laura",
                Apellido = "Gomez",
                DNI = 28432257,
                AñoDeCursada = 2018,
                Genero = "Femenino",
                NombreDelProfesor = "Fernando",
                NombreDeLaMateria = "Matematicas",
                NombreDelInstituto = "ESBA",
                NumeroDelDistrito = 15,
            };

            Materia Matematicas1c = new Materia
            {
                Nombre = "Pablo",
                Apellido = "Gonzales",
                DNI = 25427232,
                AñoDeCursada = 2018,
                Genero = "Masculino",
                NombreDelProfesor = "Fernando",
                NombreDeLaMateria = "Matematicas",
                Turno = "Noche",
                NombreDelInstituto = "ESBA",
                NumeroDelDistrito = 15,
            };

            Materia Matematicas1d = new Materia
            {

                Nombre = "Jose",
                Apellido = "Fernandez",
                DNI = 123484012,
                AñoDeCursada = 2018,
                Genero = "Masculino",
                NombreDelProfesor = "Fernando",
                NombreDeLaMateria = "Matematicas",
                Turno = "Noche",
                NombreDelInstituto = "ESBA",
                NumeroDelDistrito = 15,

            };

            Materia BaseDeDatos1a = new Materia
            {
                Nombre = "Jose",
                Apellido = "Fernandez",
                DNI = 123484012,
                AñoDeCursada = 2018,
                Genero = "Masculino",
                NombreDelProfesor = "Maria",
                NombreDeLaMateria = "Base de Datos",
                Turno = "Noche",
                NombreDelInstituto = "ESBA",
                NumeroDelDistrito = 15,
            };

            Materia BaseDeDatos1b = new Materia
            {
                Nombre = "Pablo",
                Apellido = "Gonzales",
                DNI = 25427232,
                AñoDeCursada = 2018,
                Genero = "Masculino",
                NombreDelProfesor = "Maria",
                NombreDeLaMateria = "Base de Datos",
                Turno = "Noche",
                NombreDelInstituto = "ESBA",
                NumeroDelDistrito = 15,
            };
            Materia BaseDeDatos1c = new Materia
            {
                Nombre = "Laura",
                Apellido = "Gomez",
                DNI = 28432257,
                AñoDeCursada = 2018,
                Genero = "Femenino",
                NombreDelProfesor = "Maria",
                NombreDeLaMateria = "Base de Datos",
                NombreDelInstituto = "ESBA",
                NumeroDelDistrito = 15,
            };
            Materia BaseDeDatos1d = new Materia
            {
                Nombre = "Jesica",
                Apellido = "Santillan",
                DNI = 31250435,
                AñoDeCursada = 2018,
                Genero = "Femenino",
                NombreDelProfesor = "Maria",
                NombreDeLaMateria = "Base de Datos",
                NombreDelInstituto = "ESBA",
                NumeroDelDistrito = 15,
            };









            Console.ReadKey();

        }
    }
}
