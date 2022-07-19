using System;

namespace EntradaProcessamentoSaida
{
    class exercicio3
    {
        static void Main3(string[] args)
        {
            int codPeca, qtdVendida;
            double precoPeca, valorComissao, valorTot;
            string identVendedor;
            Console.WriteLine("#### Calculo Comissão de funcionario ####");
            Console.WriteLine("Digite o nome do vendedor");
            identVendedor = Console.ReadLine();
            Console.WriteLine("Digite o codigo da peça vendida");
            codPeca = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da peça vendida");
            precoPeca = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças vendidas");
            qtdVendida = Convert.ToInt32(Console.ReadLine());
            valorTot = precoPeca * qtdVendida;
            valorComissao = (precoPeca * qtdVendida) * 0.05;

            Console.WriteLine("O vendedor " + identVendedor + " vendeu " + qtdVendida + " pecas de codigo " + codPeca + " somando um total de " +
                " R$" + valorTot + " e receberá R$ " + String.Format("{0:0.00}", valorComissao) + " de comissão");
        }
    }
}