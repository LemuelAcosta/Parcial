using System;

namespace parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            double prec;
            string pag;
            Console.WriteLine("Cual es el precio del producto?");
            prec = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cual es la forma de pagar efectivo o tarjeta?");
            pag = Console.ReadLine();
            if (pag == "tarjeta")
            {
                string tarj;
                Console.WriteLine("Digite el numero de su tarjeta.");
                tarj = Console.ReadLine();

                int size = tarj.Length;
                bool a = true;
                
                if (size == 12)
                { Console.WriteLine("Gracias por su compra!"); }
                else
                {
                    if (size != 12)
                    {
                        Console.WriteLine("ERROR!! Numero incorrecto");
                        
                    }
                }
                
            }
            else 
            {
                Console.WriteLine("Gracias por su compra!");
            }


        }
    }
}
