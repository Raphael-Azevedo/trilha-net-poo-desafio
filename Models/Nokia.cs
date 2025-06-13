namespace DesafioPOO.Models
{
    public class Nokia(string numero, string modelo, string imei, string memoria) : Smartphone(numero, modelo, imei, memoria)
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}