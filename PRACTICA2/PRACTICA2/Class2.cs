using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA2
{
    class Class2
    {
        public void eje1()
        {
            string nombre;
            int cantidad;
            
            double precio,iva,total;

            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("cantidad:");
            cantidad = System.Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("precio");
            precio = System.Convert.ToDouble(Console.ReadLine());
            total=precio*cantidad;
            Console.WriteLine("subtotal:"+total.ToString("C2"));
            iva=(total)*0.03;
            Console.WriteLine("iva: "+ iva.ToString("C2"));
            Console.WriteLine("total a pagar: "+ ((total+iva).ToString("C2")));
            Console.ReadKey();
        }

    }
}
