using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseCarroCombustible
{
    class Carro
    {
        private int _cantidadCombustible;

        public Carro(int _cantidadCombustible) {
            this._cantidadCombustible = _cantidadCombustible;
        }
        public void encender() {
            if (_cantidadCombustible > 0)
            {
                Console.WriteLine("El Carro fue encendido");
                _cantidadCombustible--;
                Console.WriteLine("Gasolina restante {0}", _cantidadCombustible);
            }
            else {
                Console.WriteLine("El carro no pudo avanzar");
            }
            
        }
    }
}
