using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3_JaggedArray_1_MGrITIA3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet masīva garumu:");
            int garums = int.Parse(Console.ReadLine());

            // Uztaisa masīvu un izsauc funkciju
            string[] mas = InitArray(garums);

            // Izsauc funkciju kas printē ārā rezultātu
            PrintArray(mas);
        }

        static string[] InitArray(int garums)
        {
            //Jauns mas un rand vajadzīgs lai simbolu daudzums buutu randomizēts
            string[] newArray = new string[garums];
            Random rand = new Random();

            // Aizpilda mas
            for (int i = 0; i < garums; i++)
            {
                // Izsauc funkciju lai masīvu aizpildīt ar random virknēm
                newArray[i] = GetRandomString(rand.Next(2, 11), rand);
            }

            return newArray;
        }

        static string GetRandomString(int x, Random rand)
        {
            // Glabā simbolus
            char[] stringChars = new char[x];

            // Ģenerē simbolus
            for (int i = 0; i < x; i++)
            {
                int asciiValue = rand.Next(1, 127);
                char randomChar = (char)asciiValue;
                stringChars[i] = randomChar;
            }

            return new string(stringChars);
        }
        static void PrintArray(string[] mas)
        {
            // Izvada visu kas ir masīvā
            foreach (string simboli in mas)
            {
                Console.WriteLine(simboli);
            }
        }
    }
}