using System;

namespace EntradaProcessamentoSaida
{
    class exercicio1
    {
        static void Main1(string[] args)
        {
            int estoqueMedio, qtdMin, qtdMax;
            Console.WriteLine("#### Calculo de estoque médio ####");

            Console.WriteLine("Digite o estoque minimo do produto");
            qtdMin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o estoque maximo do produto");
            qtdMax = Convert.ToInt32(Console.ReadLine());

            estoqueMedio = (qtdMin + qtdMax) / 2;

            Console.WriteLine("O valor do estoque médio é de " + estoqueMedio);
        }
    }
}