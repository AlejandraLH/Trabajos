namespace Actividad3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int CP = 95; //PRECIO DEL PLATILLO
            int NUMP;
            double P;

            Console.WriteLine("Uso del if");
            Console.WriteLine("Programa para obtener un presupuesto ");
            //Entrada
            Console.WriteLine("Ingresa el número de personas: ");
            NUMP = int.Parse(Console.ReadLine());
            //Proceso y salida

            if (NUMP > 200 && NUMP <= 300)
            {
                CP = 85;
            }
            else
            {
                if (NUMP > 300)
                {
                    CP = 75;
                }
            }
            P = CP * NUMP;

            Console.WriteLine("El presupuesto será de: " + P);
            Console.ReadKey();
            

        }
    }
}
