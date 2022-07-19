using System;

namespace Ex10
{
    class ex10
    {
        static void Main(string[] args)
        {
            double n1, n2;
            bool maior, menor, igual, diferente, maiorigual, menorigual;
            Console.WriteLine(" #### Comparação de dois numeros ####");
            Console.WriteLine("Digite o primeiro numero");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            n2 = double.Parse(Console.ReadLine());
            maior = (n1 > n2);
            menor = (n1 < n2);
            igual = (n1 == n2);
            diferente = (n1 != n2);
            maiorigual = (n1 >= n2);
            menorigual = (n1 <= n2);

            Console.WriteLine("Maior(>) = " + maior + "\nMenor(<) = " + menor + "\nIgual(==) = " + igual
                + "\nDiferente(!=) = " + diferente + "\nMaior ou Igual(>=) = " + maiorigual + "\nMenor ou Igual(<=) = " + menorigual);
        }
    }
}