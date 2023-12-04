using System;

namespace BolasColoridas
{
    public class Cor
    {
        private byte red, green, blue, alpha;

        public Cor(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Cor(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = byte.MaxValue;
        }

        public byte GetRed()
        {
            return red;
        }

        public void SetRed(byte valor)
        {
            red = valor;
        }

        public byte GetGreen()
        {
            return green;
        }

        public void SetGreen(byte valor)
        {
            green = valor;
        }

        public byte GetBlue()
        {
            return blue;
        }

        public void SetBlue(byte valor)
        {
            blue = valor;
        }

        public byte GetAlpha()
        {
            return alpha;
        }

        public void SetAlpha(byte valor)
        {
            alpha = valor;
        }

        public int GetCinzento()
        {
            return (red + green + blue) / 3;
        }
    }
}