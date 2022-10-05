using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab3
{
    internal class Profesor : Personas
    {
        public Profesor(string name, int legajo)
        {
            base.Name = name;
            base.Legajo = legajo;
        }
    }
}
