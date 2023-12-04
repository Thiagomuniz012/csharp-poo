
namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public string Modelo { get; set; }
        public int AnoLancamento { get; set; }

        public Nokia(string numero, string modelo, int anoLancamento) : base(numero)
        {
            Modelo = modelo;
            AnoLancamento = anoLancamento;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia {Modelo}...");
        }
    }
}