using System;

namespace lenumero
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero, antecessor, sucessor;
            numero meunumero = new numero();
            string texto;

            Console.WriteLine("digite um numero: ");
            meunumero.defineNumero(Int32.Parse(Console.ReadLine()));

            //sucessor = numero + 1;
            //antecessor = numero - 1;

            texto = "numero: {0}, sucessor: {1}, antecessor: {2}";
            Console.WriteLine(texto, meunumero.pegaValorDefinido(), meunumero.sucessorDoNumero(), meunumero.antecessorDoNumero());
        }
    }
}