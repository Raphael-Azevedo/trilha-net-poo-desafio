using DesafioPOO.Models;

var nokia = new Nokia("11999999999", "Nokia 3310", "123456789", "32GB");
var iphone = new Iphone("11988888888", "iPhone 13", "987654321", "128GB");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");