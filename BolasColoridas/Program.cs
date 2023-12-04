using System;

namespace BolasColoridas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cor c1 = new Cor(200, 0, 255);
            Cor c2 = new Cor(147, 55, 0);
            Cor c3 = new Cor(0, 120, 150);

            Bola b1 = new Bola(c1, 10.5f);
            Bola b2 = new Bola(c2, 5.7f);
            Bola b3 = new Bola(c3, 19.1f);

            Cor b1Cor = b1.GetCor();
            Cor b2Cor = b2.GetCor();
            Cor b3Cor = b3.GetCor();

            b1.Atirar();
            b2.Atirar();
            b3.Atirar();
            b2.Atirar();
            b1.Atirar();
            b1.Atirar();

            b2.Pop();
            b1.Pop();

            b1.Atirar();
            b2.Atirar();
            b3.Atirar();

            Console.WriteLine("Bola 1");
            Console.WriteLine("- Cor");
            Console.WriteLine($"-- R: {b1Cor.GetRed()}");
            Console.WriteLine($"-- G: {b1Cor.GetGreen()}");
            Console.WriteLine($"-- B: {b1Cor.GetBlue()}");
            Console.WriteLine($"- Vezes atirada: {b1.GetVezesAtirada()}");

            Console.WriteLine();

            Console.WriteLine("Bola 2");
            Console.WriteLine("- Cor");
            Console.WriteLine($"-- R: {b2Cor.GetRed()}");
            Console.WriteLine($"-- G: {b2Cor.GetGreen()}");
            Console.WriteLine($"-- B: {b2Cor.GetBlue()}");
            Console.WriteLine($"- Vezes atirada: {b2.GetVezesAtirada()}");

            Console.WriteLine();

            Console.WriteLine("Bola 3");
            Console.WriteLine("- Cor");
            Console.WriteLine($"-- R: {b3Cor.GetRed()}");
            Console.WriteLine($"-- G: {b3Cor.GetGreen()}");
            Console.WriteLine($"-- B: {b3Cor.GetBlue()}");
            Console.WriteLine($"- Vezes atirada: {b3.GetVezesAtirada()}");
        }
    }
}
