using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBanco.Metodos
{
    class Cores
    {
        public void ColorBlue()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public void ColorRed()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
