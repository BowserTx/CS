
using System;

class URI
{

    static void Main(string[] args)
    {
        int i = 0, contador = 1;

        contador = Convert.ToInt32(Console.ReadLine());

        do
        {

            for (i = 1; i < contador; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(i);

            contador = Convert.ToInt32(Console.ReadLine());

        } while (contador != 0);

    }
}