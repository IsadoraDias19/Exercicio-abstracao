using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4___Carro
{
    public class Carro
    {

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public double Velocidade { get; set; }

        public double Acelera { get; set; }

        public double Desacelera { get; set; }
       
        public Carro(string marca, string modelo, double velocidade, double acelera, double desacelera)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = velocidade;
            Acelera = acelera;
            Desacelera = desacelera;
        }

        /* Método */
        public void acelerar()
        {
            Console.WriteLine($"\nO carro {Marca} acelera {Acelera} de 0 a 100 Km/h");
        }

        public void desacelerar()
        {
            Console.WriteLine($"\nO carro {Marca} desacelera {Desacelera} de 0 a 100 Km/h");

        }
    }
}
