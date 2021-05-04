using System;

namespace Clase_taladro
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo_taladro();
        }

        private static void Metodo_taladro()
        {
            Console.WriteLine("Hola ingrese nombre oveja: ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Color oveja: ");
            string input2 = Console.ReadLine();

            Console.WriteLine("Alimento oveja: ");
            string input3 = Console.ReadLine();

            Ovejas oveja = Formulario.agregar_oveja(input1, input2, null);
            Console.WriteLine("LA oveja es: " + oveja.get_nombre());
            Console.ReadLine();
        }
    }
}
