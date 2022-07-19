using System;

namespace LacosDeRepeticao
{
    class ex15
    {
        static void Main15(string[] args)
        {
            double nota1, nota2, nota3, nota4 ,media, notaRec ;
            Console.WriteLine("#### Calculo de média para aprovar ou reprovar aluno ####");
            Console.WriteLine("Digite a primeira nota");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            nota3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota");
            nota4 = Convert.ToInt32(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("Aluno Aprovado \n Média : " + string.Format("{0:0.00}",media));
            }
            else if (media < 7)
            {
                Console.WriteLine("Aluno em recuperação!");
                Console.WriteLine("Digite a nota de recuperação");
                notaRec = Convert.ToInt32(Console.ReadLine());
                media = (notaRec + media) / 2;

                if(media >= 7)
                {
                    Console.WriteLine("Aluno Aprovado na recuperação \n Média : " + string.Format("{0:0.00}",media));
                }
                else
                {
                    Console.WriteLine("Aluno reprovado! \n Média : " + string.Format("{0:0.00}",media));
                }

            }
        }
    }
}
