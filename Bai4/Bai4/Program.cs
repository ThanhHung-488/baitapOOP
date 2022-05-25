using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Town town = new Town();
            Town.Input();
            Town.Display();
            Console.ReadKey();
        }
    }
}