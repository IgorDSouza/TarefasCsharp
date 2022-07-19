using System;

namespace Ex6
{
    class ex6
    {
        static void Main6(string[] args)
        {
            double f, c;
            Console.WriteLine("#### Conversor de celcius para fahrenheit ####");
            Console.WriteLine("Digite a temperatura em graus celcius");
            c = double.Parse(Console.ReadLine());

            f = (9 * c + 160) / 5;
            Console.WriteLine(f);
        }
    }
}