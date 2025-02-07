using DesafioPOO.Models;

Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
Console.WriteLine("Telefone Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("facebook");

Iphone iphone = new Iphone("987654321", "Iphone 12", "987654321", 128); 
Console.WriteLine("Telefone Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");