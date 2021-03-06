﻿namespace DispositivosAsync
{
    public class Impresora
    {
        public int Demora { get; set; }
        public Impresora(int demora)
            => Demora = demora;
        public string imprimir(string texto)
        {            
            //Magia oscura que detiene el proceso cierta cantidad de milisegundos
            System.Threading.Thread.Sleep(Demora);
            return texto;
        }
    }
}