using System;

namespace lacosrepeticao
{
    class ex24
    {
        static void Main24(string[] args)
        {
            double num1=0, num2=0, result=0, escolha;
            Console.WriteLine("#### Insira dois valores e escolha a operação a ser aplicada ####");
            Console.WriteLine("Insira o valor 1");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor 2");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escolha a operação e digite o numero relacionado a ela \n 1-Verificar se os numeros são multiplos um do outro \n" +
                "2-Verificar se os numeros são pares \n 3-Verificar se a media dos numeros é maior ou igual a 7 \n 4-Sair ");
            escolha = Convert.ToDouble(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    for (int i = 0; i <= num1; i++) {
                        if (num2 *i == num1)
                        {
                            Console.WriteLine("O Numero 1 é multiplo do Numero 2 " );
                            result++;
                        }                      
                    }

                    for (int i = 0; i <= num2; i++)
                    {
                        if (num1 * i == num2)
                        {
                            Console.WriteLine("O Numero 2 é multiplo do Numero 1 ");
                            result++;
                        }
                    }
                    if (result ==0)
                    {
                        Console.WriteLine("Os numeros não são multiplos");
                    }
                    break;
                case 2:
                    if (num1 % 2 == 0 && num2%2==0)
                    {
                        Console.WriteLine("Ambos os numeros são pares");
                    }
                    else
                    {
                        Console.WriteLine("Um ou nenhum dos numeros são pares");
                    }
                    break;
                case 3:
                    if ((num1 + num2) / 2 >= 7)
                    {
                        Console.WriteLine("A media dos dois numeros é igual ou maior que 7");
                    }
                    else
                    {
                        Console.WriteLine("A media dos dois numeros não é maior ou igual a 7");
                    }
                    break;
                default:
                    Console.WriteLine("Encerrando");
                    break;
            }
        }
    }
}
