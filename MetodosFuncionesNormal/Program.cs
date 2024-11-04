namespace MetodosFuncionesNormal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miMensaje = "Hola";
            MostrarMensaje("Mensaje Desde el Metodo...1");
            MostrarMensaje("Mesaje Desde el Metodo...2");
            MostrarMensaje(miMensaje);

            int primerSuma = Sumar(2, 5);
            MostrarMensaje($"El resultado de la primera suma es {primerSuma} ");
           // MostrarMensaje($"el resultado de la suma de {primerNumero} y {segundoNumero} es {total}");
            Sumar(3, 9);

        }
        //el Program siempre va a llevar su Main
        static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Función
        static int Sumar(int primerNumero, int segundoNumero)
        {
            int total = primerNumero + segundoNumero;
            return total;
        }
    }
}
