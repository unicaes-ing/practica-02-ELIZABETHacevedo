using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA2
{
    class Class4
    {
        public void eje1()
        {
            string f1, f2;
            DateTime inicio,fin;
           // double precio;
            double totalDia,precio;

            Console.WriteLine("valor diario por alquiler:");
            precio = System.Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("fecha de entrega:");
            Console.WriteLine("ingrese el dia");
            f1 = Console.ReadLine();
            f1 = string.Concat(f1,"/");
            Console.WriteLine("ingrese el mes");
            f1 = string.Concat(f1,Console.ReadLine(),"/");
            Console.WriteLine("ingrese el annio");
            f1 = string.Concat(f1, Console.ReadLine());
            inicio = DateTime.Parse(f1);

            Console.WriteLine(inicio);

            Console.WriteLine("fecha de devolucion");
            Console.WriteLine("ingrese el dia");
            f2 = Console.ReadLine();
            f2 = string.Concat(f2, "/");
            Console.WriteLine("ingrese el mes");
            f2 = string.Concat(f2, Console.ReadLine(), "/");
            Console.WriteLine("ingrese el annio");
            f2 = string.Concat(f2, Console.ReadLine());

            fin = DateTime.Parse(f2);
            Console.WriteLine(fin);
            
            
            totalDia = ((fin - inicio).TotalDays);
            totalDia += 1;
            Console.WriteLine("dias de uso : "+totalDia);
            precio = (precio * totalDia);
            //Console.WriteLine(precio);
            Console.WriteLine("el total a pagar es: "+precio.ToString("C2"));
            Console.ReadKey();






        }
    }
}
