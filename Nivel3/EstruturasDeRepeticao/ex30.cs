using System;

namespace nivel4
{
    class ex30
    {
        static void Main30(string[] args)
        {
            int num;
            double result=0;
            Console.WriteLine(" #### Tabuada do numero escolhido ####");
            Console.WriteLine("Digite o numero para calcular a tabuada");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                result = num * i
;                Console.WriteLine(num + "x" + i + " = "+ result);

            }
        }
    }
}
