using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _37_PlanillaDeNotasYAsistencia
{
    class Materia:Asistencias
    {
        public string NombreDelProfesor { get; set; }
        public string NombreDeLaMateria { get; set; }
        public string Turno { get; set; }
        public string NombreDelInstituto { get; set; }
        public int NumeroDelDistrito { get; set; }
    }
}
