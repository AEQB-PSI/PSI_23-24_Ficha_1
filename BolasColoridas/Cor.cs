using System;

namespace BolasColoridas
{
    public class Cor
    {
        // Variáveis que representam estado  de uma instância de Cor
        private byte red, green, blue, alpha;

        // Construtor que aceita todos os parâmetros necessários para
        // inicializar o estado de uma Cor
        public Cor(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        // Construtor que aceita parâmetros RGB e define alpha com
        // o valor máximo
        public Cor(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = byte.MaxValue;
        }

        // Getter para o valor de vermelho
        public byte GetRed()
        {
            return red;
        }

        // Setter para o valor de vermelho
        public void SetRed(byte valor)
        {
            red = valor;
        }

        // Getter para o valor de verde
        public byte GetGreen()
        {
            return green;
        }

        // Setter para o valor de verde
        public void SetGreen(byte valor)
        {
            green = valor;
        }

        // Getter para o valor de azul
        public byte GetBlue()
        {
            return blue;
        }

        // Setter para o valor de azul
        public void SetBlue(byte valor)
        {
            blue = valor;
        }

        // Getter para o valor de alpha
        public byte GetAlpha()
        {
            return alpha;
        }

        // Setter para o valor de alpha
        public void SetAlpha(byte valor)
        {
            alpha = valor;
        }

        // Getter que retorna o grau de cinzento da cor
        public int GetCinzento()
        {
            return (red + green + blue) / 3;
        }
    }
}