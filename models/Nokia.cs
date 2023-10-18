using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_dotnet_poo.models
{
    public class Nokia : Smartphone
    {
        public override void instalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando app {nomeApp}");
        }
    }
}