namespace ActividadDiccionarios
{
    public static class InputHelper
    {
        public static int IngresarInt(string mensaje, int min = int.MinValue, int max = int.MaxValue)
        {
            System.Console.Write(mensaje);
            if (int.TryParse(System.Console.ReadLine(), out int valor) && valor >= min && valor <= max)
                return valor;
            else
                return -1;
        }

        public static string IngresarString(string mensaje, string respuestaDefault = "")
        {
            System.Console.Write(mensaje);
            return System.Console.ReadLine()?.Trim() ?? respuestaDefault;
        }

        public static double IngresarDouble(string mensaje, double min = double.MinValue, double max = double.MaxValue)
        {
            System.Console.Write(mensaje);
            if (double.TryParse(System.Console.ReadLine(), out double valor) && valor >= min && valor <= max)
                return valor;
            else
                return -1.0;
        }

        public static decimal IngresarDecimal(string mensaje, decimal min = decimal.MinValue, decimal max = decimal.MaxValue)
        {
            System.Console.Write(mensaje);
            if (decimal.TryParse(System.Console.ReadLine(), out decimal valor) && valor >= min && valor <= max)
                return valor;
            else
                return -1;
        }
    }
}