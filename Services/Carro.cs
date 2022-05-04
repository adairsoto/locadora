using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6_WFEx2.Services
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double ValorDiaria { get; set; }
        public bool Disponivel { get; set; }

        public Carro(string marca, string modelo, double valorDiaria)
        {
            Marca = marca;
            Modelo = modelo;
            ValorDiaria = valorDiaria;
            Disponivel = true;  
        }
        public override string ToString()
        {
            return $"{Marca} {Modelo} - Valor Diária: R$ {ValorDiaria}";
        }
        
    }
    public class CarroRepository
    {
        public static List<Carro> InicializarCarros()
        {
            List<Carro> carros = new List<Carro>();
            carros.Add(new Carro("Hyundai", "HB20" , 200));
            carros.Add(new Carro("Honda", "Fit" , 200));
            carros.Add(new Carro("Honda", "Civic", 300));
            carros.Add(new Carro("Toyota", "Corolla", 250));
            carros.Add(new Carro("Chevrolet", "Onix", 200));
            carros.Add(new Carro("Wolkswagen", "Golf", 350));

            return carros;
        }
    }
}
