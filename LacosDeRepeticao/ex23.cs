using System;

namespace lacosrepeticao
{
    class ex23
    {
        static void Main23(string[] args)
        {
            double num1, num2, result, escolha;
            Console.WriteLine("#### Insira dois valores e escolha a operação a ser aplicada ####");
            Console.WriteLine("Insira o valor 1");
            num1= Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Insira o valor 2");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escolha a operação e digite o numero relacionado a ela 1-Adição / 2-Subtração / 3-Multiplicação /4-Divisão ");
            escolha = Convert.ToDouble(Console.ReadLine());
            switch (escolha)
            { 
                case 1:
                    result = num1 + num2;
                    Console.WriteLine(num1 + "+" + num2 +" = "+ result);
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine(num1+"-"+num2+" = "+result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine(num1 + "x" + num2 + " = "+ result);
                    break;
                case 4:
                    result = num1 / num2;
                    Console.WriteLine(num1 + "/" + num2 +" = "+ result);
                    break;

                default:
                    Console.WriteLine("Operação Invalida");
                    break;
            }
        }
    }
}
