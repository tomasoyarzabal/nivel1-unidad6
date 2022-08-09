using System;

namespace ejerciciou6b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contadornumeros,contadorimpares,grupoimparesmaximo = 0,min,conordenados = 0;
            double porcentajeimpares, porcentajemaximo = -1;
            bool banderaordenados;
            
            for(int x = 0; x < 5; x++)
            {
                contadornumeros = 0;
                contadorimpares = 0;
                banderaordenados = true;
                n = int.Parse(Console.ReadLine());
                min = n;
                while (n != 0)
                {
                 contadornumeros++;
                 if(n % 2 != 0)
                 {
                    contadorimpares++;
                 }
                 if(n <= min)
                 {
                    min = n;
                 }
                 else
                 {
                    banderaordenados = false;
                 }
                  n = int.Parse(Console.ReadLine());

                }
                porcentajeimpares = contadorimpares *100 / contadornumeros;
                if(porcentajeimpares > porcentajemaximo)
                {
                    porcentajemaximo = porcentajeimpares;
                    grupoimparesmaximo = x + 1;
                }
                if(banderaordenados)
                conordenados++;
            }
            Console.WriteLine("grupo con mayor porcentaje de impares es " + grupoimparesmaximo);
            Console.WriteLine("La cantidad de grupos con numeros ordenados es " + conordenados);
           
        }
            
        
    }
}
