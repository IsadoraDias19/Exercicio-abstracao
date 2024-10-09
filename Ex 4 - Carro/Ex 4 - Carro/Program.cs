using Ex_4___Carro;

Carro carro1 = new Carro("Toyota", "Toyota Camry",255, 3.5, 2.7);
Carro carro2 = new Carro("Mercedes-Benz", "Mercedes-Benz Classe C", 223, 8.9, 7.6);
Carro carro3 = new Carro("Volkswagen", "Volkswagen Fox", 183, 10.6, 8.9);


Console.WriteLine("A marca " + carro1.Marca + " ,modelo: " + carro1.Modelo + ",tem velocidade" + carro1.Velocidade+"Km/h");
Console.WriteLine("A marca " + carro2.Marca + " ,modelo: " + carro2.Modelo + ",tem velocidade" + carro2.Velocidade+"Km/h");
Console.WriteLine("A marca " + carro3.Marca + " ,modelo: " + carro3.Modelo + ",tem velocidade" + carro3.Velocidade + "Km/h");


carro1.acelerar();
carro2.acelerar();
carro3.acelerar();

carro1.desacelerar();
carro2.desacelerar();
carro3.desacelerar();


Console.ReadKey();
