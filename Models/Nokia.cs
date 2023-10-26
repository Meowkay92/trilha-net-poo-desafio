namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // IMPLEMENTADO
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO
        public Nokia (String numero, String modelo, String imei, int memoria) : base (numero, modelo,imei,memoria)
        {

        }
        public override void  InstalarAplicativo(string Whatsapp)
        {
            Console.WriteLine($"Instalar Aplicativo {Whatsapp} no Nokia" );
        }
    }
}