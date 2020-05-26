using System;

namespace DispositivosAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            var hp = new Impresora(3000);
            var kodak = new Impresora(5000);
            var canon = new Impresora(4000);

            var texto = "Hola mundo asincronico";

            Console.WriteLine($"hp: {hp.imprimir(texto)}");
            Console.WriteLine($"kodak: {kodak.imprimir(texto)}");
            Console.WriteLine($"canon: {canon.imprimir(texto)}");
            Console.ReadKey();
        }
    }
}