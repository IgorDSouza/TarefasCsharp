using System;

namespace ConsoleApp1
{
    class ex21
    {
        static void Main21(string[] args)
        {
            int num;
            string selec = "s";

            
            while (selec.Equals("s"))
            {
                Console.WriteLine("#### Exibir valor positivo e negativo ####");
                Console.WriteLine("Digite o numero");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                {
                    Console.WriteLine("Numero positivo! \n Deseja continuar? s ou n");
                    selec = Console.ReadLine();                       
                }
                if (num < 0)
                {
                    Console.WriteLine("Numero negativo! \n Deseja continuar? s ou n");
                    selec = Console.ReadLine();
                }

            }
        }
    } 
}
