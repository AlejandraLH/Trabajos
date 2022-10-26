namespace CalculadorabasicaCASE
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //Declarar variables
            char opción, operador= ' ';
            //Declarando e inicializando variables
            //Se asigna el valor 0 a las variiables
            double num1 = 0, num2 = 0, resultado = 0;
            Console.WriteLine("Calculadora Básica");
            Console.WriteLine("Selecciona una opción");
            Console.WriteLine("S - suma");
            Console.WriteLine("R - resta");
            Console.WriteLine("D - división");
            Console.WriteLine("M - multiplicacion");
            Console.WriteLine("Selecciona una opción: ");
            opción = char.Parse(Console.ReadLine());
            if (opción == 'S' || opción == 'R' || opción == 'D' || opción == 'M')
            {
                Console.WriteLine("Ingresa el primer numero: ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                switch (opción)
                {
                    case 'S':
                        resultado = num1 + num2;
                        operador = '+';
                        break;
                    case 'R':
                        resultado = num1 - num2;
                        operador = '-';
                        break;
                    case 'M':
                        resultado = num1 * num2;
                        operador = '*';
                        break;
                    case 'D':
                        resultado = num1 / num2;
                        operador = '/';
                        break;
                }
                //salida
                Console.WriteLine(num1 + " " + operador + "" + num2 + "" + "=" + resultado);
            }
            else
            {
                Console.WriteLine("Verificar opción ");
               
            }
                Console.ReadKey();
        }
    }
}
