using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_dotnet_poo.models
{
    public abstract class Smartphone
    {
         public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei {get; set;}
        private int Memoria { get; set; }


        public void ligar()
        {
            Console.WriteLine("efetuando ligação.");
        }

        public void receberLigacao()
        {
            Console.WriteLine("recebendo ligação.");
        }

        public abstract void instalarAplicativo(string nomeApp);

    }
}