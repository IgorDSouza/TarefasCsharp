using System;

namespace nivel4
{
    class ex32
    {
        static void Main32(string[] args)
        {
            int num = 0, cont=0;
            double result=0;
            bool valid = true;
            Console.WriteLine("#### Soma dos quadrados primeiros 20 numeros impares ####");
            Console.WriteLine("Digite um numero de 1 a 10");
            num=Convert.ToInt32(Console.ReadLine());

            if(num>0 && num < 10)
            { 
                while (valid==true)
                {
                    
                    if(num % 2 != 0)
                    {
                        Console.WriteLine(num);
                        result += num * num;
                        cont++;

                    }

                    if (cont == 20)
                    {
                        valid = false;
                    }
                   num++;
                }
                Console.WriteLine("A soma dos quadrados dos primeiros 20 numeros impares é de " + result);
            }
         
        }
    }
}
