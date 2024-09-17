using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzamientoDadosEj1.models
{
    internal class SimulDados
    {
        public int[] frecuencia; // Arreglo para almacenar la frecuencia de las sumas de los dados
        public Dados dado1;
        public Dados dado2;

        
        public SimulDados()
        {
            frecuencia = new int[13]; // Frecuencia q sale la suma de dos y doce - El uno quedara en cero
            dado1 = new Dados(); 
            dado2 = new Dados(); 
        }
        public void ReiniciarFrecuencias()
        {
            frecuencia = new int[13];  // reinicia el arreglo para la suma en 2-12
        }
        public void SimularTiradas(int lanzamientos)
        {
            ReiniciarFrecuencias();
            for (int i = 0; i < lanzamientos; i++)
            {
                int suma = dado1.Lanzar() + dado2.Lanzar();
                frecuencia[suma]++;
            }
        }

        public int[] GetFrecuencias()
        {
            return frecuencia;
        }
    }
}
