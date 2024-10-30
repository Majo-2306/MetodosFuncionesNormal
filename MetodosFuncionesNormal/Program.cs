namespace MetodosFuncionesNormal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje("Mensaje Desde el Metodo...1");
            MostrarMensaje("Mesaje Desde el Metodo...2");

            Sumar(2, 5);
            Sumar(3, 9);
        }
        //el Program siempre va a llevar su Main
        static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        static void Sumar(int primerNumero, int segundoNumero)
        {
            int total = primerNumero + segundoNumero;
            MostrarMensaje($"el resultado de la suma de {primerNumero} y {segundoNumero} es {total}");
        }
    }
}
