using System;

namespace Ex7
{
    class ex7
    {
        static void Main7(string[] args)
        {
            double f, c;
            Console.WriteLine("#### Converter fahrenheit em Celcius ####");
            Console.WriteLine("Digite a temperatura em graus fahrenheit");
            f = double.Parse(Console.ReadLine());

            c = (f - 32) * 5 / 9;
            Console.WriteLine("A temperatura em graus celcius é " + string.Format("{0:0.00}", c) + "ºC");
        }
    }
}