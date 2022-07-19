using System;

namespace ConsoleApp1
{
    class ex20
    {
        static void Main20(string[] args)
        { int a, b, c;
            double mult, divi;
            Console.WriteLine("#### Exibir menor valor*maior valor e menor valor/menor ####");

            Console.WriteLine("Digite o primeiro numero maior que zero");
            a = Convert.ToInt32(Console.ReadLine());

            while (a <= 0)
            {
                Console.WriteLine("Valor um invalido!");
                Console.WriteLine("Digite o primeiro numero");
                a = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Digite o segundo numero maior que zero");
            b = Convert.ToInt32(Console.ReadLine());
            
            while (b <= 0)
            {
                Console.WriteLine("Valor dois invalido!");
                Console.WriteLine("Digite o segundo numero");
                b = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Digite o terceiro numero maior que zero");
            c = Convert.ToInt32(Console.ReadLine());
            
            while (c <= 0) { 
                Console.WriteLine("Valor tres invalido!");
                Console.WriteLine("Digite o terceiro numero");
                c = Convert.ToInt32(Console.ReadLine());
            }
           

            if (a > 0 && b > 0 && c > 0)
            {
                if (a > b && b > c)
                {
                    mult = c * a;
                    divi = a / c;
                    Console.WriteLine("A multiplicação do menor pelo maior é " + mult + " E a divisão do maior pelo menor é de " + divi);
                }
                else if (a > c && c > b)
                {
                    mult = b * a;
                    divi = a / b;
                    Console.WriteLine("A multiplicação do menor pelo maior é " + mult + " E a divisão do maior pelo menor é de " + divi);
                }
                else if (b > c && c > a)
                {
                    mult = a * b;
                    divi = b / a;
                    Console.WriteLine("A multiplicação do menor pelo maior é " + mult + " E a divisão do maior pelo menor é de " + divi);
                }
                else if (b > a && a > c)
                {
                    mult = c * b;
                    divi = b / c;
                    Console.WriteLine("A multiplicação do menor pelo maior é " + mult + " E a divisão do maior pelo menor é de " + divi);
                }
                else if (c > a && a > b)
                {
                    mult = b * c;
                    divi = b / a;
                    Console.WriteLine("A multiplicação do menor pelo maior é " + mult + " E a divisão do maior pelo menor é de " + divi);
                }
                else if (c > b && b > a)
                {
                    mult = a * c;
                    divi = c / a;
                    Console.WriteLine("A multiplicação do menor pelo maior é " + mult + " E a divisão do maior pelo menor é de " + divi);
                }

            }
        }   
    }
}
