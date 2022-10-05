using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2022
{
    public class CaptarPersonas
    {
        private DatosDeAcceso _datosdeacceso;

        public CaptarPersonas()
        {
            _datosdeacceso = new DatosDeAcceso();
        }

        public Personas SavePersona(Personas persona) 
        {
            if (persona.Id == 0)
              //  _personasver.InsertPersona
            else
                //_personasver.UpdatePersona
        }
    }
}
