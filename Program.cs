using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Program
    {
        static bool Espar(int n)
        //recibo la variable n y pregunto si es par
        {
            return n % 2 == 0; //comprobacion si es par
        }
        public static Boolean Primos(int n)
        {
            return n % 2 != 0;
        }
      
        static void Main(string[] args)
        {

            // Generar una lista con 50 números aleatorios
            //. Con esta lista resolver los siguientes problemas:
            Random Aleatorio = new Random();
            List<int> Num = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                Num.Add(Aleatorio.Next(40, 55));
            }


            Console.WriteLine("LISTA DE NUMEROS ALEATORIOS:");
            Num.ForEach(a => Console.WriteLine(a));


            Console.WriteLine("+++++++++++++++");
         


            //Generar una Nueva List con los numeros primos
            List<int> NPrimos = new List<int>();
            var Pri = from a in Num where Primos(a) select a;

            foreach (var item in Pri)
            {
                //Generar una Nueva List con los numeros primos
                NPrimos.Add(item);
            }
            Console.WriteLine("LOS NUMEROS PRIMOS SON:");
            NPrimos.ForEach(a => Console.WriteLine(a));

            Console.WriteLine("+++++++++++++++");

            //•	Mostrar en consola la suma de todos los elementos.
            Console.WriteLine("****LA SUMA DE TODOS LOS NUMEROS ES****");
            var Suma = Num.Sum();
            Console.WriteLine(Suma);

            Console.WriteLine("+++++++++++++++");



            //•	Generar una nueva lista con el cuadrado de los números.


            Console.WriteLine("LA LISTA DE LOS NUMEROS AL CUADRADO ES ");

            List<int> Num2 = new List<int>();



            Num.ForEach(a => Num2.Add(a * a));
            Num2.ForEach(a => Console.WriteLine(a));

            Console.WriteLine("+++++++++++++++");


            //•	Optener el promedio de todos los números mayores a 50.

            var Mayores = from i in Num where i > 50 select i;

            var Promedio = Mayores.Average();
            Console.WriteLine("PROMEDIO DE LOS NUMEROS MAYORES A 50:   {0}", Promedio);

            //•	Contar la cantidad de números pares e impares. Este problema
            //debe resolverse en una única sentencia o en un solo querie.

            int p = 0, I = 0;
            Num.ForEach(a =>

            {
                if (Espar(a))
                {
                    p++;
                }
                else
                {
                    I++;
                }

            });
            Console.WriteLine("Cantidad de Numeros pares es: \n{0}\n" +
                "Cantidad de Numeros Impares es:\n {1}", p, I);

            Console.WriteLine("+++++++++++++++");
            //•	Mostrar en consola, el número y
            //la cantidad de veces que este se encuentra en la lista.

            var Cant = from i in Num select i;

            //var Cant1 = from i in Num  select i;

            foreach (var Ncan in Cant.Select(
                (B) => new { Numero = B }) 
               .GroupBy(B => B.Numero) 
               .Select(C => new
               {
                   Numero = C.Key, 
                   Cantidad = C.Count(),
               }))
            {
                Console.WriteLine(string.Format   
                 ("Número a mostrar: '{0}'\n" +
                  "Cantidad De Veces que se repite: {1}"
                    , Ncan.Numero, Ncan.Cantidad));
            }


            Console.WriteLine("+++++++++++++++");

            //•	Mostrar en consola los elementos de forma descendente.
            Console.WriteLine("LOS NUMEROS ORDENADOS DE FORMA DESCENDENTE SON:");
            (from a in Num orderby a descending select a)
                .ToList().
                ForEach(a => Console.WriteLine(a));

            Console.WriteLine("cambiooo");



            //•	Mostrar en consola los número unicos.

            int suma = 0;
            Console.WriteLine("Numeros Unicos son: ");
            var Cant1 = from i in Num select i;
            foreach (var Ncan in Cant.Select(
               (B) => new { Numero = B })
              .GroupBy(B => B.Numero)
              .Select(C => new
              {
                  
                  Numero = C.Key,
                  Cantidad = C.Count(),
                  
              }))
            {
                if (Ncan.Cantidad == 1)
                {
                    
                    Console.WriteLine(Ncan.Numero);
                    suma = suma + Ncan.Numero;
                }

            }

            //SUMAR TODOS LOS NUMEROS UNICOS DE LA LISTA 

            Console.WriteLine("LA SUMA DE LOS NUMEROS UNICOS ES:  {0}",suma);

            Console.ReadKey();

           
           

        }    }
}
