using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenarator
{
    public class NumbersRandom
    { 

        private Random rand = new Random();
        private readonly string letters = "abcdefghijklmnopqrstuvwxyz";
        private readonly string capitalLetters = "abcdefghijklmnopqrstuvwxyz".ToUpper();
        private readonly string numbers = "1234567890";
        private readonly string caracters = "!@#$%&";
        public StringBuilder Randons(int qtd)
        {
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < qtd; i++)
            {
                StringBuilder pass = new StringBuilder();

                pass.Append(letters[rand.Next(0, letters.Length)]);
                pass.Append(numbers[ rand.Next(0, numbers.Length)]);
                pass.Append(capitalLetters[ rand.Next(0, capitalLetters.Length)]);
                pass.Append(caracters[ rand.Next(0, caracters.Length)]);

                password.Append(MessUpString(pass));
            }

            return password;
        }
        private StringBuilder MessUpString(StringBuilder pass)
        {
            StringBuilder passwordPart = new StringBuilder();
            int lengthFor = pass.Length;

            for (int i = 0;i < lengthFor; i++)
            {
                int randomNum = rand.Next(0, pass.Length);
                char caracter = pass[randomNum];
                passwordPart.Append(caracter);
                pass.Remove(randomNum, 1);
            }

            return passwordPart;
        }
    }
}
