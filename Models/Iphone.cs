namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // IMPLEMENTADO
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO
         public Iphone (String numero, String modelo, String imei, int memoria) : base (numero, modelo,imei,memoria)
        {

        }
        public override void  InstalarAplicativo(string Whatsapp)
        {
            Console.WriteLine($"Instalar Aplicativo {Whatsapp} no Iphone" );
        }
    }
}