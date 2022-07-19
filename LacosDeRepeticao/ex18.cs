using System;

namespace LacosDeRepeticao
{
    class ex18
    {
        static void Main18(string[] args)
        {
            int codigo;
            Console.WriteLine("#### Validando um codigo ####");
            Console.WriteLine("Digite o codigo");
            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;

                case 2:
                    Console.WriteLine("Dois");
                    break;

                case 3:
                    Console.WriteLine("Três");
                    break;

                default: Console.WriteLine("Codigo inválido");
                    break;

            }


        }
    }
}
