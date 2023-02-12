using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4
{
    public class Guitarra
    {
        private static string Afinacao = "SOL";

        static Guitarra()
        {
            Afinacao = "SOL";
        }

        private void TomAfinado()
        {
            Console.WriteLine("A guitarra está com afinação em " + Afinacao);
        }

        public void tocar()
        {
            TomAfinado();
        }

        public void tocar(string AfinacaoAtual)
        {
            Afinacao = AfinacaoAtual;
            TomAfinado();
        }
    }
}