using System;

namespace Ex5
{
    class ex5
    {
        static void Main5(string[] args)
        {
            double tempo, velocidade, distancia, litros;
            Console.WriteLine(" #### Calcular distancia, e litros gastos em uma viagem ####");
            Console.WriteLine("Digite o tempo gasto na viagem");
            tempo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade media");
            velocidade = double.Parse(Console.ReadLine());

            distancia = tempo * velocidade;
            litros = distancia / 12;

            Console.WriteLine(" A viagem foi de " + string.Format("{0:0.00}", distancia) + " KM. \n Com um consulmo de " + string.Format("{0:0.00}", litros) + " litros. \n Durando " + string.Format("{0:0.00}", tempo) + " horas ");
        }
    }
}