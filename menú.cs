namespace Menú_asesoría
{
    public static class Program
    {
        static void Main()
        {
            char L;
            Console.WriteLine("Programa para escribir un nombre");
            //Entrada
            Console.WriteLine("Ingresa una letra");
            L = char.Parse(Console.ReadLine());
            //Proceso
            if (L == 'A' || L == 'a')
                Console.WriteLine("Alejandra");
            else
                if (L == 'L' || L == 'l')
                Console.WriteLine("López");
            else
                if (L == 'H' || L == 'h')
                Console.WriteLine("Hernández");
            else
                Console.WriteLine("Error");
            //salida
            Console.ReadKey();
        }
    }
}
