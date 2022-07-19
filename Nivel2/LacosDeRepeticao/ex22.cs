using System;

namespace ConsoleApp1
{
    class ex22
    {
        static void Main22(string[] args)
        {
            double num,A,B;

                Console.WriteLine("#### Exibir valor positivo e negativo ####");
                Console.WriteLine("Digite o numero");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                {

                     A = num;    
                     Console.WriteLine("Numero positivo!");
                
                }
                if (num < 0)
                {
                    B = num;
                    Console.WriteLine("Numero negativo!");
                    
                }

            }
        }
    }
