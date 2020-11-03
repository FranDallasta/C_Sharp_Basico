using System;

namespace Ejercicios
{
    public class Test 
    {
        static int Main (string [] args)
        {
            
            Console.Write("Mostrar los numeros del 1 al 100 ");
            Console.ReadKey();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            return 0; 
        }
    }
}
