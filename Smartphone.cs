using System.IO.MemoryMappedFiles;
using System;


namespace DesafioPOO.Models
{
    // TODO: Implementar as propriedades faltantes de acordo com o diagrama
    //implementação com base no diagrama disponibilizado
           public abstract class Smartphone
    {
           public string Modelo { get; set; }
           public int Memoria { get; set; }
           public string Imei { get; set; }
           private string Numero { get; set; }

           // Construtor da classe base
          protected Smartphone(string modelo, int memoria, string imei, string numero)
       {
            Modelo = modelo;
            Memoria = memoria;
            Imei = imei;
            Numero = numero;
       }

          // Método abstrato que será implementado nas classes filhas
            public abstract void InstalarAplicativo(string nomeApp, string modelo, int memoria, string imei, string numero);

             public void Ligar()
           {
            Console.WriteLine("Ligando...");
           }

             public void ReceberLigacao()
           {
            Console.WriteLine("Recebendo ligação...");
           }

    }
}

