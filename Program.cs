using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste Nokia:");
Nokia nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "123456", memoria: 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Teste Iphone:");
Iphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 13", imei: "987654", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
