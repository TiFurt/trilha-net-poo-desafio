using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "41234234", modelo: "Xperia",imei: "41342j3gh423", memoria: 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "02938745-", modelo: "Iphone 14 Pro Max",imei: "jd129073rfd092", memoria: 12);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");