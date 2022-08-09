using System;

namespace ejerciciou6a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con, contprimo = 0;
            for(int y = 0; y < 10; y++)
            {
                Console.WriteLine("INGRESE UN NUMERO");
                n = int.Parse(Console.ReadLine());
                con=0;
                for(int x = 1;x <= n; x++)
              {
                if(n % x == 0)
                {
                    con++;
                }
              }
              if(con == 2)
              {
                contprimo++;
              }
            }
            Console.WriteLine("Hay " + contprimo + "primos");
           
        }
    }
}
