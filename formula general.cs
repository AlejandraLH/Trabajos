namespace FormulaGeneral
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //Declarar variables
            double a, b, c, x1 = 0, x2 = 0, Raiz = 0;
            //Entrada
            Console.WriteLine("Escribe el valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el valor de b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el valor de c: ");
            c = double.Parse(Console.ReadLine());
            //Proceso 
            Raiz = Math.Sqrt((Math.Pow(b, 2) - 4 * a * c));
            //Salida
            if (Raiz >=0)
            {
                x1 = (b + Raiz) / (2 * a);
                x2 = (b - Raiz) / (2 * a);
                Console.WriteLine("El valor de x1 es : " + x1);
                Console.WriteLine("El valor de x2 es : " + x2);
            }
            else
            {
                Console.WriteLine("Los datos son incorrectos!!");
            }
            Console.ReadKey();
        }
    }
}
