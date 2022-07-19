using System;

namespace Ex9
{
    class ex9
    {
        static void Main9(string[] args)
        {
            int d, m, a;
            Console.WriteLine("Idade em dias");
            Console.WriteLine("Digite a sua idade completa em anos, meses e dias");
            Console.WriteLine("Digite os anos");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os meses");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os dias");
            d = int.Parse(Console.ReadLine());

            d += a * 365;
            d += m * 30;

            Console.WriteLine("dias de vida " + d);
        }
    }
}