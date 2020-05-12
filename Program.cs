using Finanzas.Domain;
using System;

namespace Finanzas
{
    class Program
    {
        static void Main(string[] args)
        {

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Elige una opción:");
            Console.WriteLine();
            Console.WriteLine("1) Calcular VAN");
            Console.WriteLine("2) Calcular VAN constante");
            Console.WriteLine("3) Salir");
            Console.Write("\r\nSelecciona opción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    VANcalculate();
                    return true;
                case "2":
                    ConstantVANcalculate();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static void VANcalculate()
        {
            VAN _van = new VAN();
            Console.WriteLine("VAN = -A + VA");
            Console.WriteLine();
            Console.WriteLine("Inserta A");
            _van.A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserta VA");
            _van.VA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Resultado -> " + _van.CalculateVAN());
            Console.ReadLine();
        }

        private static void ConstantVANcalculate()
        {
            VAN _van = new VAN();
            Console.WriteLine("Inserta A");
            _van.A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserta constante Qn");
            _van.Qconstante = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Resultado -> " + _van.CalculateVAN());
            Console.ReadLine();
        }
    }
}
