using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA2
{
    class Class1
    {
        public void eje1()
        {
            string nombre;
            Console.WriteLine("escriba su nombre: ");
            nombre = Console.ReadLine();
            nombre = nombre.ToLower();

            nombre = nombre.Replace("a", "#");
            nombre = nombre.Replace("e", "%");
            nombre = nombre.Replace("i", "$");
            nombre = nombre.Replace("o", "?");
            nombre = nombre.Replace("u", "*");
            Console.WriteLine(nombre);

            
            Console.ReadKey();
        }


    }
}
