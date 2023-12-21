using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("SmartPhone Nokia:");
Smartphone nokia = new Nokia(numero: "2024", modelo: "Modelo 1", imei: "111111", memoria: 124);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp"); 

Console.WriteLine("\n");

Console.WriteLine("SmartPhone iphone:");
Smartphone iphone = new Iphone(numero:"4987", modelo: "Modelo 2", imei: "222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");