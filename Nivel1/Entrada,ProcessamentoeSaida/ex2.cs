using System;

namespace EntradaProcessamentoSaida
{
    class Exercicio2
    {
        static void Main2(string[] args)
        {
            double cotacaoDol, valorDolar, resultConver;
            Console.WriteLine("#### Conversor de Unidades ####");

            Console.WriteLine("Insira a cotação atual do dolar");
            cotacaoDol = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor em dolares para ser convertido");
            valorDolar = Convert.ToDouble(Console.ReadLine());

            resultConver = cotacaoDol * valorDolar;

            Console.WriteLine("Atualmente " + valorDolar + " é igual a $" + String.Format("{0:0,00}", resultConver) + " Reais ");
        }
    }
}