using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Deber
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Cliente> Listaclientes = new List<Cliente>()
            {
                new Cliente(){Id=1, Nombre="Alexis"},
                new Cliente(){Id=2, Nombre="Ricardo"},
                new Cliente(){Id=3, Nombre="Karen"},
                new Cliente(){Id=4, Nombre="Estefania"},
                new Cliente(){Id=5, Nombre="Gabriela"},
                new Cliente(){Id=6, Nombre="Lucia"},
                new Cliente(){Id=7, Nombre="Andrea"},
                new Cliente(){Id=8, Nombre="Lady"},
                new Cliente(){Id=9, Nombre="Genesis"},
                new Cliente(){Id=10, Nombre="Nicole"}
            };

            List<Factura> Listafacturas = new List<Factura>()
            {
                new Factura()
                {Observacion ="Prop",Fecha= new DateTime(2018,06,15,13,14,15),IdCliente=1,TotalVentas=12},
                new Factura()
                {Observacion ="Retenido",Fecha= new  DateTime(2019,07,18,20,25,19),IdCliente=2,TotalVentas=20},
                new Factura()
                {Observacion ="Prop",Fecha= new  DateTime(2001,05,20,14,10,20),IdCliente = 3,TotalVentas=18},
                new Factura()
                {Observacion ="En Espera", Fecha= new  DateTime(2014,11,10,14,15,20),IdCliente=4,TotalVentas=5},
                new Factura()
                {Observacion ="Excelente", Fecha= new DateTime(2015,04,18,20,14,18),IdCliente=5,TotalVentas=23},
                new Factura()
                {Observacion ="Muy Bien",Fecha= new DateTime(2017,06,19,19,23,10),IdCliente=6,TotalVentas=5},
                new Factura()
                {Observacion ="Merecido",Fecha=new DateTime(2018,05,20,15,20,19,15),IdCliente=7,TotalVentas=4},
                new Factura()
                {Observacion ="Retenido",Fecha= new DateTime(2017,02,05,19,20,23),IdCliente = 8, TotalVentas=14},
                new Factura()
                {Observacion ="Retenido",Fecha=new DateTime(2015,02,15,10,15,13),IdCliente = 9,TotalVentas=11},
                new Factura()
                {Observacion ="Prop",Fecha=new DateTime(2015,06,18,20,19,10),IdCliente = 10,TotalVentas=17}
            };


            var Union =
                from F in Listafacturas
                join C in Listaclientes on F.IdCliente equals C.Id
                orderby C.Nombre 
                select new
                {
                    identificadorCliente = C.Id,
                    identificadorFactura = F.IdCliente,
                    NombreCliente = C.Nombre,
                    FechaFactura = F.Fecha,
                    ObservacionFactura=F.Observacion,
                    TotalVentasFactura=F.TotalVentas,
                };

            //CLIENTES ORDENADOS POR NOMBRES

            Console.WriteLine("***************");


            Console.WriteLine("CLIENTES ORDENADOS POR NOMBRES:");
            foreach (var item in Union)
            {
                Console.WriteLine(item.NombreCliente);
            }

            //VENTAS ORDENADAS POR FECHAS

            Console.WriteLine("VENTAS ORDENADAS POR FECHA:");
            var Union1 =
                from F in Listafacturas orderby F.Fecha select F;

            foreach (var item in Union1)
            {
                Console.WriteLine(item.Fecha);
            };

            Console.WriteLine("***************");


           //LOS TRES CLIENTES CON MAS MONTOS EN VENTAS


            Console.WriteLine("LOS TRES CLIENTES CON MAS MONTO EN VENTAS:");
            int m1 = 0;
            int m2 = 0;
            int m3 = 0;

            string primero = "";
            string segundo = "";
            string tercero = "";
            foreach (var item in Union)
            {
                if (item.TotalVentasFactura > m1)
                {
                    m1 = item.TotalVentasFactura;
                    primero = item.NombreCliente;
                }
                if (item.TotalVentasFactura > m2 && item.TotalVentasFactura != m1)
                {
                    m2 = item.TotalVentasFactura;
                    segundo = item.NombreCliente;
                }
                if (item.TotalVentasFactura > m3 && item.TotalVentasFactura != m1 && item.TotalVentasFactura != m2)
                {
                    m3 = item.TotalVentasFactura;
                    tercero = item.NombreCliente;
                }
            }
            Console.WriteLine("Cliente 1:  {0}, ventas {1}", primero, m1);
            Console.WriteLine("Cliente 2:  {0}, ventas {1}", segundo, m2);
            Console.WriteLine("Cliente 3:  {0}, ventas {1}", tercero, m3);




            Console.WriteLine("***************");

            Console.WriteLine("LOS TRES CLIENTES CON MENOS MONTO EN VENTAS:");


            int mayor = 0;
            int x = 0, y = 0, z = 0;

            int menor1 = 0;
            int menor2 = 0;
            int menor3 = 0;

            string priMenor = "";
            string seguMenor = "";
            string terMenor = "";

            foreach (var item in Union)
            {
                if (item.TotalVentasFactura > mayor)
                {
                    mayor = item.TotalVentasFactura;
                    x = item.TotalVentasFactura;
                    y = item.TotalVentasFactura;
                    z = item.TotalVentasFactura;

                }
                if (item.TotalVentasFactura < x)
                {
                    x = item.TotalVentasFactura;
                    menor1 = item.TotalVentasFactura;
                    priMenor = item.NombreCliente;
                }
                if (item.TotalVentasFactura < y && item.TotalVentasFactura != menor1)
                {
                    y = item.TotalVentasFactura;
                    menor2 = item.TotalVentasFactura;
                    seguMenor = item.NombreCliente;
                }
                if (item.TotalVentasFactura < z && item.TotalVentasFactura != menor1 && item.TotalVentasFactura != menor2)
                {
                    z = item.TotalVentasFactura;
                    menor3 = item.TotalVentasFactura;
                    terMenor = item.NombreCliente;
                }
            }
            Console.WriteLine("Cliente 1:  {0}, ventas {1}", priMenor, menor1);
            Console.WriteLine("Cliente 2:  {0}, ventas {1}", seguMenor, menor2);
            Console.WriteLine("Cliente 3:  {0}, ventas {1}", terMenor, menor3);






            Console.WriteLine("***************");


            Console.WriteLine("***************");

            Console.WriteLine("Nombres de los clientes y ventas realizadas:");
            foreach (var itema in Union)
            {
                Console.WriteLine("{0}:\n Realizo: {1} Ventas",
                itema.NombreCliente, itema.TotalVentasFactura);
            }

           
            

            Console.WriteLine("***************");

            Console.WriteLine("EL CLIENTE CON MAS VENTAS REALIZADAS");
           
          
            var fac = Union.Max(i => i.identificadorCliente);
            Console.WriteLine(fac);
            

            Console.WriteLine("***************");

            // LAS VENTAS REALIZADAS HACE MENOS DE UN AÑO
            Console.WriteLine("ventas realizadas hace menos de un año");
            foreach (var item in Union)
            {
                if (item.FechaFactura>=fac)
                {
                    Console.WriteLine(item.FechaFactura);
                }
            }


            Console.WriteLine("LA ULTIMA VENTA REALIZADA FUE EL: ");

            var Ultimo = Union.Max(a => a.FechaFactura);
            Console.WriteLine(Ultimo);


            Console.WriteLine("***************");

            Console.WriteLine("LA VENTA MAS ANTIGUA FUE EL:");
            var antigua = Union.Min(a => a.FechaFactura);
            Console.WriteLine(antigua);

            Console.WriteLine("***************");
            //•	Los clientes que tengan una venta cuya observación comience con "Prob".
            Console.WriteLine("LOS CLIENTES CUYA OBSERVACION COMIENZAN CON PROP SON:");
            foreach (var item in Union)
            {
                if (item.ObservacionFactura == "Prop")
                {
                    Console.WriteLine(item.NombreCliente);
                }
                
            }
            


            Console.ReadKey();
       }
    }
    class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    class Factura
    {
        public string Observacion { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int TotalVentas { get; set; }
    }
}
