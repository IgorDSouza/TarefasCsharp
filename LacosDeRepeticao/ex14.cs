using System;

namespace LacosDeRepeticao
{
    class ex14
    {
        static void Main14(string[] args)
        {
            int num1, num2, dif;
            Console.WriteLine("#### Diferença do valor maior para o valor menor ####");
            Console.WriteLine("Digite o primeiro valor");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                dif = num1 - num2;
                Console.WriteLine("A diferença entre o maior valor e o menor valor é " + dif);
            }else if (num2 > num1)
            {
                dif = num2 - num1;
                Console.WriteLine("A diferença entre o maior valor e o menor valor é " + dif);
            }
        }
    }
}
