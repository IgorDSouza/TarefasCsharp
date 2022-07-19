using System;

namespace Ex4
{
    class ex4
    {
        static void Main4(string[] args)
        {
            double num1, num2, num3, num4;
            Console.WriteLine("#### Somar e multiplicar em ordem ####");
            Console.WriteLine("Digite o primeiro numero (A)");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero (B)");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero (C)");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto numero (D)");
            num4 = double.Parse(Console.ReadLine());

            Console.WriteLine(" A+B = " + (num1 + num2) + " A+C = " + (num1 + num3) + " A+D = " + (num1 + num4) + " B+C = " + (num2 + num3) + " B+D = " + (num2 + num4) + " C+D = " + (num3 + num4));
            Console.WriteLine(" A*B = " + (num1 * num2) + " A*C = " + (num1 * num3) + " A*D = " + (num1 * num4) + " B*C = " + (num2 * num3) + " B*D = " + (num2 * num4) + " C*D = " + (num3 * num4));

        }
    }
}