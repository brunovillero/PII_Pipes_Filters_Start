using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class FilterRandomConvolution : FilterConvolution
    {
        private Random random = new Random();
        /// <summary>
        /// Filtro complejo random.
        /// </summary>
        /// <param name="name">Nombre del objeto</param>
        public FilterRandomConvolution()
        {
            this.matrizParametros = new int[3, 3];
            this.complemento = random.Next(1,7);     
            this.divisor = random.Next(1,33); 
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    matrizParametros[x, y] = random.Next(1,5); 
                }
            }
        }
    }
}