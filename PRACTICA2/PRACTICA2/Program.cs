using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("seleccione una opcion[1-6]");
            n = System.Convert.ToInt32(Console.ReadLine());
            switch (n)
            {case 1:
                    Class1 C1 = new Class1();
                    
                    C1.eje1();
                    break;
                case 2:
                    Class2 C2 = new Class2();
                    C2.eje1();
                    break;
                case 3:
                    Class3 C3 = new Class3();
                    C3.eje1();
                    break;
                    case 4:
                    Class4 C4 = new Class4();
                    C4.eje1();
                    break;
                case 5:
                    Class5 C5 = new Class5();
                    C5.eje1();
                    break;
                case 6:
                    Class6 C6 = new Class6();
                    C6.eje1();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
