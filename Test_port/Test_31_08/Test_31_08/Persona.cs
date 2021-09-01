using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_31_08
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Double Estatura { get; set; }

        public Persona()
        {
            this init();
        }

        private void init()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            FechaNacimiento = DateTime.Today;
            Estatura = 0;
        }
    }
}
