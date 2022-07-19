using System;

namespace nivel4
{
    class ex27
    {
        static void Main27(string[] args)
        {
            int numFat, qtdNum, cont = 0, result = 0, result2=1; ;
            Console.WriteLine(" #### Fatorial dos numeros escolhidos ####");

            Console.WriteLine("Digite a quantidade de numeros que será calculado o fatorial");
            qtdNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qtdNum ; i++)
            {
                Console.WriteLine("Digite o numero a ser calculado o fatorial");
                numFat = Convert.ToInt32(Console.ReadLine());
                if(numFat > 0)
                {
                    cont = numFat;
                    Console.Write( numFat+"! = ");
                    while (cont > 1)
                    {
                        cont--;
                        result = result2 * cont;
                        
                        Console.Write(numFat + " x ");
                        numFat--;
                        result2 += result;
                    }
                    Console.WriteLine("1 = "+result2);
                }
            }
        }
    }
}
