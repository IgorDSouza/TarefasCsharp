using System;

namespace LacosDeRepeticao
{
    class ex16
    {
        static void Main16(string[] args)
        {
            int num1, num2;
            Console.WriteLine("#### Mostrando valor maior e menor ####");
            Console.WriteLine("Digite o primeiro valor");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O maior numero digitado é " + num1 + " E o menor número é " + num2);
            }
            if (num2 == num1)
            {
                Console.WriteLine("Os dois valores são iguais");
            }
            else if(num2>num1)
            {
                Console.WriteLine("O maior numero digitado é "+ num2 + " E o menor número é "+ num1);
            }
        }
    }
}
