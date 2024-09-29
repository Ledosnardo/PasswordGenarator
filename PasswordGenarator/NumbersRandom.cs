using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenarator
{
    public class NumbersRandom { 
        public StringBuilder Randons(int qtd)
        {
            string carateres = "abcdefghijklmnopqrstuvwxyz" + 
                "abcdefghijklmnopqrstuvwxyz".ToUpper() + "1234567890" +
                "!@#$%&";

            StringBuilder password = new StringBuilder();
            Random rand = new Random();

            for (int i = 0; i < qtd; i++)
            {
                password.Append(carateres[ rand.Next(0, carateres.Length) ]);
            }

            return password;
        }
    }
}
