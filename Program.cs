using System;

namespace ACT1_
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arreglodias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            const int dias = 7;

            for (int i = dias-1; i>0 ; i--)
            {
                Console.WriteLine(arreglodias[i]);
            }
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}

