using System;
using System.Threading.Tasks;

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

            var hpTask = Task.Run(() => Console.WriteLine($"hp: {hp.imprimir(texto)}"));
            var kodakTask = Task.Run(() => Console.WriteLine($"kodak: {kodak.imprimir(texto)}"));
            var canonTask = Task.Run(() => Console.WriteLine($"canon: {canon.imprimir(texto)}"));

            Task.WaitAll(hpTask, kodakTask, canonTask);
            Console.ReadKey();
        }
    }
}