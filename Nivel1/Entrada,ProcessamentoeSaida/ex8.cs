using System;

namespace Ex8
{
    class ex8
    {
        static void Main8(string[] args)
        {
            double r, v, a;
            Console.WriteLine("Digite a altura da lata de óleo");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o raio da lata de óleo");
            r = double.Parse(Console.ReadLine());

            v = 3.14159 * r * r * a;

            Console.WriteLine("O volume da lata de óleo é de " + string.Format("{0:0.00}", v) + "L");
        }
    }
}