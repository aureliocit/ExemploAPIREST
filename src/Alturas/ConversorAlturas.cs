using System;

namespace Alturas
{
    public class ConversorAlturas
    {
        private static double fatorConversao = 0.3048; 
        public double PesParaMetros(double altura) {
            return Math.Round(altura * fatorConversao, 4);
        }
    }
}
