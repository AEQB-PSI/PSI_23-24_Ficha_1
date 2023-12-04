using System;

namespace BolasColoridas
{
    public class Bola
    {
        // Cor da instância de Bola
        private Cor cor;

        // Raio da instância de Bola
        private float raio;

        // Nº de vezes que instância de Bola é atirada
        private int vezesAtirada;

        // BOOL para determinar se instância de Bola rebentou
        private bool rebentou;

        // Construtor que inicializa uma nova bola com
        // cor e raio dados
        public Bola(Cor cor, float raio)
        {
            this.cor = cor;
            this.raio = raio;
        }

        // Rebentar a bola, metendo o seu raio a 0
        public void Pop()
        {
            raio = 0;
            rebentou = true;
        }

        // Atirar a bola uma vez, se não estiver rebentada
        public void Atirar()
        {
            if (!rebentou)
                vezesAtirada++;
        }

        // Retorna nº de vezes que bola foi atirada
        public int GetVezesAtirada()
        {
            return vezesAtirada;
        }

        // Retorna cor da bola
        public Cor GetCor()
        {
            return cor;
        }
    }
}