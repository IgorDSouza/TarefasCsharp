using System;

namespace nivel4
{
    class ex31
    {
        static void Main31(string[] args)
        {
            int num = 0, resultPar =0 , resultImpar = 0;
            Console.WriteLine("#### Soma dos numeros pares e impares");
            Console.WriteLine("Digite um numero");
            num=Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {   
                if(num %2 == 0)
                {
                    resultPar += num;
                    Console.WriteLine("Numero par digitado!");
                }
                else
                {
                    resultImpar += num;
                    Console.WriteLine("Numero impar digitado!");

                }
                Console.WriteLine("Se deseja continuar somando digite novamente um numero, se não, digite um numero negativo");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("A soma dos numeros pares digitados é de "+ resultPar + "\nE a soma dos numeros impares é de "+ resultImpar);
        }
    }
}
