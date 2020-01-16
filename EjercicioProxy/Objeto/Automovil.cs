using System;

namespace EjercicioProxy
{
    public class Automovil : IAutomovil
    {
        public string codigoArranque { get; set; }

        public Automovil(string _codigoArranque)
        {
            codigoArranque = _codigoArranque;
        }

        public void EncenderAutomovil()
        {
            Console.WriteLine("¡Se ENCIENDE el Automovil!");
        }
    }
}
