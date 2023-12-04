namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public string Modelo { get; set; }
        public string VersaoIOS { get; set; }

        public Iphone(string numero, string modelo, string versaoIOS) : base(numero)
        {
            Modelo = modelo;
            VersaoIOS = versaoIOS;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone {Modelo}...");
        }
    }
}