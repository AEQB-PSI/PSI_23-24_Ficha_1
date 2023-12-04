using System;

namespace BolasColoridas
{
    public class Bola
    {
        private Cor cor;

        private float raio;

        private int vezesAtirada;

        private bool rebentou;

        public Bola(Cor cor, float raio)
        {
            this.cor = cor;
            this.raio = raio;
        }

        public void Pop()
        {
            raio = 0;
            rebentou = true;
        }

        public void Atirar()
        {
            if (!rebentou)
                vezesAtirada++;
        }

        public int GetVezesAtirada()
        {
            return vezesAtirada;
        }

        public Cor GetCor()
        {
            return cor;
        }
    }
}