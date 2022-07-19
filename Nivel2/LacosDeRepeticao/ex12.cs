using System;

namespace LacosDeRepeticao
{
    class ex12
    {
        static void Main12(string[] args)
        {
            int num, calculo;
            Console.WriteLine("#### Modulo de um numero ####");
            Console.WriteLine("Digite o valor para  ser calculado o modulo");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("O modulo de" + num + " é " +num);
            }else
            {
                calculo = num * (-1);

                Console.WriteLine("O modulo de " + num + " é " + calculo );
            }
        }
    }
}
