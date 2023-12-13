using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "+5514998765432", modelo: "Nokia Star", imei: "987654321", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


System.Console.WriteLine();

System.Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone(numero: "+5514991234567", modelo: "Iphone 14", imei: "123456789", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");