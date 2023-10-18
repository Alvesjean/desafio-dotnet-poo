using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_dotnet_poo.models
{
    public class Iphone : Smartphone
    {
        public override void instalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando app do {nomeApp}");
        }
    }
}
