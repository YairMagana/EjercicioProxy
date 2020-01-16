using System;

namespace EjercicioProxy
{
    public class ProxyAutomovil : IAutomovil
    {
        private Automovil automovilReal;
        private Llave llave;

        public ProxyAutomovil(Automovil automovil)
        {
            automovilReal = automovil;
        }

        public void ColocarLlave(Llave _llave)
        {
            Console.WriteLine($"Colocando llave \"{_llave.codigo}\"");
            llave = _llave;
        }

        public void EncenderAutomovil()
        {
            if (UsarLlave(llave))
                automovilReal.EncenderAutomovil();
            else
                Console.WriteLine("Llave Incorrecta.");
        }

        private bool UsarLlave(Llave llave)
        {
            if (llave.codigo == automovilReal.codigoArranque)
                return true;
            else
                return false;
        }
    }
}
