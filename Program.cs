using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Smartphone nokia = new Nokia(numero: "99999-0000", modelo: "Nokia Tijolão", imei: "123456789", memoria: 32);
        Console.WriteLine("\n--- Testando Nokia ---");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Smartphone iphone = new Iphone(numero: "98888-1234", modelo: "iPhone 13", imei: "987654321", memoria: 128);
        Console.WriteLine("\n--- Testando iPhone ---");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}