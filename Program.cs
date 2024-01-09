using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Exemplo de uso com as classes Nokia e iPhone
        Smartphone nokia = new Nokia("Lumia", 64, "123456789012345", "91234-3216");
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp", "Lumia", 64, "123456789012345", "91234-3216");
        nokia.ReceberLigacao();

        Console.WriteLine("\n");


        Smartphone iphone = new Iphone("X", 128, "987654321098765", "97879-5678");
        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram", "X", 128, "987654321098765", "97879-5678");
        iphone.ReceberLigacao();

       
       
     