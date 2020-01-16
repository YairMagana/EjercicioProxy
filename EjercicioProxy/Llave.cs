namespace EjercicioProxy
{
    public class Llave
    {
        public readonly string codigo;

        public Llave(string v)
        {
            codigo = v;
        }

        public string ObtenerCodigo()
        {
            return codigo;
        }
    }
}
