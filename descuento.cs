namespace descuento13102022
{
    class Program
    {
        static void Main(string[] args)
        {

            double precio, desc, preciocd;


            Console.WriteLine("Escribe el precio del artículo: ");
            precio = double.Parse(Console.ReadLine());
            desc = 0;
            preciocd = 0;

           
            if (precio >= 200)
            {
                desc = precio * 0.15;
                preciocd = precio - desc;
                Console.WriteLine("Descuento realizado " + desc);
                Console.WriteLine("El precio con descuento es: " + preciocd);
            }
            else if (precio > 100 && precio < 200)
            {
                desc = precio * 0.12;
                preciocd = precio - desc;
                Console.WriteLine("Descuento realizado " + desc);
                Console.WriteLine("El precio con descuento es: " + preciocd);
            }
            else if (precio <= 100 && precio >= 1)
            {
                desc = precio * 0.10;
                preciocd = precio - desc;
                Console.WriteLine("Descuento realizado " + desc);
                Console.WriteLine("El precio con descuento es: " + preciocd);
            }
            else
            {
                Console.WriteLine("Verificar precio");
            }
            Console.ReadKey();
        }


    }
}
