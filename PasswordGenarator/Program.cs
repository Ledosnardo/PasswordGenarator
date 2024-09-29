using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenarator
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = 10;

            StringBuilder s = new NumbersRandom().Randons(qtd);

            Console.Write(s);
            Console.ReadKey();
        }
    }
}
