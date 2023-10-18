using desafio_dotnet_poo.models;


Nokia n1 = new Nokia();
n1.Numero = "516655959595";
n1.ligar();
n1.receberLigacao();
n1.instalarAplicativo("facebook");

Console.WriteLine("-----------------------------");

Iphone ip = new Iphone();
ip.Numero = "51888744121";
ip.ligar();
ip.receberLigacao();
ip.instalarAplicativo("instagram");
