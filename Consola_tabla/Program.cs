using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libreria_tabla;
namespace Consola_tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿De que numero quieres tu tablita:");
            int n = Convert.ToInt32(Console.ReadLine());
            Tabla algo = new Tabla();
            algo.p_numero = n;
            Console.WriteLine(algo.multiplicar());
            Console.ReadKey();
        }
    }
}
