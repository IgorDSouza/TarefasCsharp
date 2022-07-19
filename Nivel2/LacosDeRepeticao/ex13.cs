using System;

namespace LacosDeRepeticao
{
    class ex13
    {
        static void Main13(string[] args)
        {
            int num1,num2,num3;
            Console.WriteLine("#### Impressão de valores em ordem decrescente ####");
            Console.WriteLine("Digite o primeiro valor");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2 && num2 > num3)
            {
                Console.WriteLine(num1 + " " + num2 + " " + num3);
            }
            if (num1 > num3 && num3 > num2)
            {
                Console.WriteLine(num1 + " " + num3 + " " + num2);
            }
            if (num2 > num1 && num1 > num3)
            {
                Console.WriteLine(num2 + " " + num1 + " " + num3);
            }
            if (num2 > num3 && num3 > num1)
            {
                Console.WriteLine(num2 + " " + num3 + " " + num1);
            }
            if (num3 > num1 && num1 > num2)
            {
                Console.WriteLine(num3 + " " + num1 + " " + num2);
            }
            if (num3 > num2 && num2 > num1)
            {
                Console.WriteLine(num3 + " " + num2 + " " + num1);
            }
        }
    }
}
