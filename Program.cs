using DesafioPOO.Models;

//Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1111-1111", modelo:"Modelo 123", imei:"55555",memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Itau");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "2222-3333", modelo: "Modelo 456", imei: "8888", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("PlutoTV");




