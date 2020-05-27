using System;
using System.Threading.Tasks;

namespace DispositivosAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var hp = new Impresora(3000);
            var kodak = new Impresora(5000);
            var canon = new Impresora(4000);

            var texto = "Hola mundo asincronico";

            await Task.WhenAll(Imprimir(texto, "hp", hp),
                               Imprimir(texto, "kodak", kodak),
                               Imprimir(texto, "canon", canon));
            Console.ReadKey();
        }

        static async Task Imprimir(string texto, string nombreImpresora, Impresora impresora)
        {
            var impresion = await impresora.imprimirAsync(texto);
            Console.WriteLine($"{nombreImpresora}: {impresion}");
        }
    }
}