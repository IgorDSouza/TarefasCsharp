using System;

namespace lacosrepeticao
{
    class ex25
    {
        static void Main(string[] args)
        {
            double altura= 0, result;
            String sexo;
            Console.WriteLine("#### Insira a altura e o sexo para saber seu peso ideal ####");
            Console.WriteLine("Insira a altura");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o sexo (H/M)");
            sexo =Console.ReadLine();
            if (sexo.Equals("m") || sexo.Equals("M"))
            {
                result = (62.1 * altura) - 44.7;
                Console.WriteLine("O seu peso ideal é "+ string.Format("{0:0.00}", result));
            }
            if (sexo.Equals("h") || sexo.Equals("H"))
            {
                result = (72.7 * altura) - 58;
                Console.WriteLine("O seu peso ideal é " + string.Format("{0:0.00}", result));
            }
        
        }
    }
}
