namespace tarea11_10_2022
{
    class Program
    {
        static void Main(string[] args)
        {

            int NC, PC = 0, TT = 0;

            Console.WriteLine("Cuál es el número de tu cita?: ");
            NC = int.Parse(Console.ReadLine());

            if (NC >=1 && NC <= 3)
            {
                PC = 200;
                TT = 200 * NC;
            }
            if (NC >=4 && NC <= 5)
            {
                PC = 150;
                TT = (NC - 3) * 150 + 600;
            }
            if (NC >= 6 &&  NC <= 9)
            {
                PC = 100;
                TT = (NC - 5) * 100 + 900;
            }
            if (NC >= 10) 
            {
                PC = 50;
                TT = (NC - 8) * 50 + 1200;
            }
           

            Console.WriteLine("El costo de tu cita es: " + PC);
            Console.WriteLine("El total de tu tratamiento es de: " + TT);
            Console.ReadKey();
        }

        
    }
}
