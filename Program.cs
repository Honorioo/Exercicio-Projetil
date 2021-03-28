using System;

namespace Exercicio_Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.80665;
            double rad, velo, angulo, resultadoAltura, resultadoAlcance;

            Console.Write("De a velocidade, em m/s...: ");
            velo = Convert.ToDouble(Console.ReadLine());

            Console.Write("De o angulo, em graus...: ");
            angulo = Convert.ToDouble(Console.ReadLine());

                rad = angulo * (Math.PI/180);

                resultadoAlcance = Math.Pow(velo, 2) * Math.Sin (2*rad) / g;
                resultadoAltura = Math.Pow(velo*Math.Sin(rad), 2) / (2*g);

            Console.WriteLine();
            Console.WriteLine($"Alcance...: {resultadoAlcance:N2}");
            Console.WriteLine($"Altura...: {resultadoAltura:N2}");


        }
    }
}
