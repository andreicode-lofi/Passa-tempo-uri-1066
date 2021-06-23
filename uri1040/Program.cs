using System;
using System.Globalization;

namespace uri1040
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int par = 0;
            int impar = 0;
            int positivo = 0;
            int negativo = 0;

            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                negativo++;
            }
            else if(num > 0)
            {
                positivo++;
            }
            if(num %2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }

            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                negativo++;
            }
            else if (num > 0)
            {
                positivo++;
            }
            if (num % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }

            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                negativo++;
            }
            else if (num > 0)
            {
                positivo++;
            }
            if (num % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }

            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                negativo++;
            }
            else if (num > 0)
            {
                positivo++;
            }
            if (num % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }

            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                negativo++;
            }
            else if (num > 0)
            {
                positivo++;
            }
             if (num % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }

            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(a)");
            Console.WriteLine(negativo + " valor(es) negativo(a)");

        } 
    }
}