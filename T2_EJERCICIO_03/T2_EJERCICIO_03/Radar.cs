using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_EJERCICIO_03
{
    public class Radar
    {
        public int[] velocidadMillas;
        public double[] frecuencia;
        public double[] velocidadKilometros;
        public Radar(int[] millas)
        {
            velocidadMillas = millas;
            frecuencia = new double[millas.Length];
            velocidadKilometros = new double[millas.Length];
            CalcularFrecuenciaYVelocidadKm();
        }

        public void CalcularFrecuenciaYVelocidadKm()
        {
            double frecuenciaOriginal = 2500; 

            for (int i = 0; i < velocidadMillas.Length; i++)
            {
                velocidadKilometros[i] = velocidadMillas[i] * 1.60934;
                frecuencia[i] = frecuenciaOriginal * velocidadMillas[i] / 334.8;
            }
        }

        public double CalcularVelocidadMinima()
        {
            double velocidadMinima = velocidadKilometros[0];
            foreach (double velocidad in velocidadKilometros)
            {
                if (velocidad < velocidadMinima)
                {
                    velocidadMinima = velocidad;
                }
            }
            return velocidadMinima;
        }

        public double CalcularVelocidadMaxima()
        {
            double velocidadMaxima = velocidadKilometros[0];
            foreach (double velocidad in velocidadKilometros)
            {
                if (velocidad > velocidadMaxima)
                {
                    velocidadMaxima = velocidad;
                }
            }
            return velocidadMaxima;
        }

        public int ContarVelocidadesSuperiores100()
        {
            int velocidadesSuperiores100 = 0;
            foreach (double velocidad in velocidadKilometros)
            {
                if (velocidad > 100)
                {
                    velocidadesSuperiores100++;
                }
            }
            return velocidadesSuperiores100;
        }

        public void MostrarResultados()
        {
            Console.Write("\t\tVELOCIDAD DE CARROS \r\n" +
                "---------------------------------------------------\r\n" +
                "FRECUENCIA RADAR\t2500 Megaciclos/seg\r\n" +
                "---------------------------------------------------\r\n" +
                "VELOCIDAD(mi)\t FRECUENCIA\t      VELOCIDAD(km)\r\n");

            for (int i = 0; i < velocidadMillas.Length; i++)
            {
                Console.WriteLine($"   {velocidadMillas[i],-15}{frecuencia[i],-23:N2}{velocidadKilometros[i],-16:N2}");
            }
        }


    }
}
