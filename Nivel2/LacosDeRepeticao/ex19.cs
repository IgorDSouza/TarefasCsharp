using System;

namespace LacosDeRepeticao
{
    class ex19
    {
        static void Main19(string[] args)
        {
            double lado1, lado2, lado3, sLado12, sLado23, sLado31;
            Console.WriteLine("#### Tipo de Triangulo ####");
            Console.WriteLine("Digite o primeiro lado");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado");
            lado3 = Convert.ToInt32(Console.ReadLine());

            sLado12 = lado1 + lado2;
            sLado23 = lado2 + lado3;
            sLado31 = lado3 + lado1;

            if (sLado12 > lado3 && sLado23 > lado1 && sLado31 > lado2)
                {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine(" Equilátero");
                }else if (lado1 == lado2 || lado1 == lado3 ||
                   lado3 == lado2)
                {
                    Console.WriteLine(" Isoceles");
                } else if (lado1 != lado2 && lado2 != lado3 &&
                  lado1 != lado3)
                {
                    Console.WriteLine(" Escaleno");
                }     
            }
            else
            {
                Console.WriteLine("Não é um triangulo");
            }

        }


        }
    }

