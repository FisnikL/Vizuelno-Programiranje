using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    enum PasswordStrength : byte
    {
        easy = 1,  // do 6 znaci (samo mali bukvi)
        normal,    // od 6 do 10 znaci (golemi bukvi i brojki)
        hard       // > 10 znaci (mali, golemi bukvi, specijalni znaci) 
    }
    class Program
    {
        static string generatePassword(PasswordStrength passwordStrength)
        {
            if (passwordStrength == PasswordStrength.easy)
                return generateEasyPassword();
            else if (passwordStrength == PasswordStrength.normal)
                return generateNormalPassword();
            else
                return generateHardPassword();
        }

        static void Main(string[] args)
        {
            string password = "";
            while (true)
            {
                Console.WriteLine("Choose the level of password: easy, normal or hard?");
                string choice = Console.ReadLine();

                if(!(choice == "easy" || choice == "normal" || choice == "hard")){
                    Console.WriteLine("Wrong choice.\nTry Again!");
                    continue;
                }

                PasswordStrength ps = (PasswordStrength)Enum.Parse(typeof(PasswordStrength), choice);

                password = generatePassword(ps);

                break;
            }
            Console.WriteLine("PASSWORD GENERATED. \nEnter your GUESSINGS separated with space.");
            string passLine = Console.ReadLine();
            char[] delimiter = { ' ' };
            string[] parts = passLine.Split(delimiter);

            bool flag = false;
            foreach(string part in parts)
            {
                if(part == password)
                {
                    flag = true;
                    break;
                }
                Console.WriteLine("{0} \t\tis wrong!", part);
            }
            if (flag)
            {
                Console.WriteLine("You FOUND THE EXACTLY REQUIRED PASSWORD: {0}", password);
            }
            else
            {
                Console.WriteLine("Sorry. No correct password entered.\nThe generated password is: {0}", password);
            }
            Console.ReadKey();
        }

        private static string generateEasyPassword()
        {
            Random r = new Random();
            int characters = r.Next(1, 6);
            char[] pass = new char[characters];

            // 97 - 123
            for(int i = 0; i < pass.Length; ++i)
            {
                pass[i] = (char) r.Next(97, 123);
            }

            return new string(pass);
        }

        private static string generateNormalPassword()
        {
            Random r = new Random();
            int characters = r.Next(6, 11);
            char[] pass = new char[characters];

            // 48 - 91
            int i = 0;
            while(i < pass.Length)
            {
                int n = r.Next(48, 91);
                if(n >= 58 && n <= 64)
                {
                    continue;
                }
                pass[i++] = (char) n;
            }

            return new string(pass);
        }

        private static string generateHardPassword()
        {
            Random r = new Random();
            int characters = r.Next(11, 20);
            char[] pass = new char[characters];

            // 32 - 126
            int i = 0;
            while (i < pass.Length)
            {
                int n = r.Next(32, 126);
                if (n >= 48 && n <= 57)
                {
                    continue;
                }
                pass[i++] = (char)n;
            }
            return new string(pass);
        }
    }
}
