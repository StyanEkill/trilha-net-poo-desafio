using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarphone Nokia");
Smartphone nokia = new Nokia("123456","Modelo 1","1111111111",64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smarphone Iphone");
Smartphone iphone = new Iphone("789101","Modelo 2","22222222222",128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");