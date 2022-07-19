using System;

namespace LacosDeRepeticao
{
    class ex11
    {
        static void Main11(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("#### Trocando valores ####");
            Console.WriteLine("Digite o valor A");
            a= Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Digite o valor B");
            b = Convert.ToInt32(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;
 
            Console.WriteLine("O valor de A virou " + a + " O valor de B ficou " + b);

        }
    }
}
