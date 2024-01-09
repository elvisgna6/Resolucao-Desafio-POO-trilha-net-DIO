namespace DesafioPOO.Models
{
        // TODO: Herdar da classe "Smartphone"
          public class Nokia : Smartphone
    {
         // Construtor que chama o construtor da classe base
           public Nokia(string modelo, int memoria, string imei, string numero)
        :  base(modelo, memoria, imei, numero)
        {
             
        }

          // Sobrescreve o método abstrato InstalarAplicativo
           public override void InstalarAplicativo(string nomeApp, string modelo, int memoria, string imei, string numero)
        {
           Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
           Console.WriteLine($"Informações gerais: modelo: {modelo} | memória: {memoria} | imei: {imei} | número: {numero}.");
        }

        
   }
} 