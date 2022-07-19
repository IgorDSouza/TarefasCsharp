using System;

namespace nivel4
{
    class ex28
    {
        static void Main28(string[] args)
        {
            int param1, param2;
            Console.WriteLine(" #### Validando numeros ímpares entre 100 e 200 ####");

            Console.WriteLine("Digite um numero entre 100 e 200 para ser o ponto de inicio da validação");
            param1 = Convert.ToInt32(Console.ReadLine());
            while (param1 < 100 || param1 > 200)
            { 
                Console.WriteLine("Numero digitado invalido");
                Console.WriteLine("Digite um numero entre 100 e 200 para ser o ponto de inicio da validação");
                param1 = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine("Digite um numero entre 100 e 200 para finalizar a validação");
            param2 = Convert.ToInt32(Console.ReadLine());
            while (param2 < 100 || param2 > 200)
            {
                Console.WriteLine("Numero digitado invalido");
                Console.WriteLine("Digite um numero entre 100 e 200 para ser o ponto de inicio da validação");
                param2 = Convert.ToInt32(Console.ReadLine());

            }
            for (int i=param1; i < param2 ; i++)
             {
               if (i % 2 != 0)
                 {
                     Console.WriteLine(i);
                 }
             }
        }  
    }
}
