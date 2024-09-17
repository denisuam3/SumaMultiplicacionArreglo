using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzamientoDadosEj1.models
{
    internal class Dados
    {
        private static Random rand = new Random();
        /*
    Se utiliza una única instancia de Random como static para q se reinicie  frecuentemente.
  
    */

        public int Lanzar()
        {
            return rand.Next(1, 7); // Devuelve un numero aleatorio entre 1 y 6
        }
    }


}
