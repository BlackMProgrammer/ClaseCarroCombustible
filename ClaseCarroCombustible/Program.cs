using System;

namespace ClaseCarroCombustible
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la marca del vehiculo que posee: ");
            string marca = Console.ReadLine();

            Console.WriteLine("Digite la cantidad de galones que posee:");
            string galonesval = Console.ReadLine();
            int galones = Convert.ToInt32(galonesval);

            Carro carro = new Carro(galones);
            Console.WriteLine("El modelo del vehiculo es {0}", marca);
            do
            {
                carro.encender();
                galones--;
            } while (galones > -1);
            
        }
    }
}
