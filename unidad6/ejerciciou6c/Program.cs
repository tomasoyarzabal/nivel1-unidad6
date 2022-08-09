using System;

namespace ejerciciou6c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1,con, numerogrupos = 0;
            do
            {
                numerogrupos++;
            con = 0;
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                con++;
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("la cantidad del grupo " + numerogrupos + " es " + con);
            } while (n >= 0);
            
            
            
        }
    }
}
