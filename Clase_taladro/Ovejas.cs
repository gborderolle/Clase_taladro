using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_taladro
{
    
    public class Ovejas
    {
        private string nombre;
        private string color;
        private Alimentos alimento;

        public Ovejas (string nombre, string color, Alimentos alimento)
        {
            this.nombre = nombre;
            this.color = color;
            this.alimento = alimento;
        }

        public string get_nombre()
        {
            return this.nombre;
        }

    }
}
