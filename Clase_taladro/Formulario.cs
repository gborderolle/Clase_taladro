using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_taladro
{
    public class Formulario
    {
        public static Ovejas agregar_oveja(string nombre, string color, Alimentos alimento)
        {
            return new Ovejas(nombre, color, alimento);
        }
    }
}
