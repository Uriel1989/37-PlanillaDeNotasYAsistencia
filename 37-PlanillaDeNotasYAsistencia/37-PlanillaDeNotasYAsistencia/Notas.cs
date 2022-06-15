using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _37_PlanillaDeNotasYAsistencia
{
    class Notas: Materia
    {
        public decimal Nota { get; set; }
        public int CantidadDeNotas { get; set; }
        public decimal Promedio ( decimal Nota , int CantidadDeNotas)
        {
            return Nota * CantidadDeNotas;
        }
    }
}
