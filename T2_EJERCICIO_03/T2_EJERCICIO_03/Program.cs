using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_EJERCICIO_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] velocidadesEnMillas = { 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 };
            Radar radar = new Radar(velocidadesEnMillas);

            radar.MostrarResultados();

            double velocidadMinima = radar.CalcularVelocidadMinima();
            double velocidadMaxima = radar.CalcularVelocidadMaxima();
            int velocidadesSuperiores100 = radar.ContarVelocidadesSuperiores100();

            Console.WriteLine("\nVelocidad mínima en kilómetros: " + velocidadMinima.ToString("N2"));
            Console.WriteLine("Velocidad máxima en kilómetros: " + velocidadMaxima.ToString("N2"));
            Console.WriteLine("Cantidad de velocidades que superan los 100 km/h: " + velocidadesSuperiores100);

            Console.ReadKey();
        }
    }
}
