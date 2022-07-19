using System;

namespace LacosDeRepeticao
{
    class ex17
    {
        static void Main17(string[] args)
        {
            int num;
            Console.WriteLine("#### Validando um numero de 0 a 9 ####");
            Console.WriteLine("Digite o valor");
            num = Convert.ToInt32(Console.ReadLine());

            if(num>0 && num < 9)
            {
                Console.WriteLine("Valor Valido");
            }
            else {
                Console.WriteLine("Valor Invalido"); 
            }
            

        }
    }
}
