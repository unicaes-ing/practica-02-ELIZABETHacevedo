using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA2
{
    class Class6
    {
        public void eje1()
        {
            DateTime HOY = DateTime.Now;
            Console.WriteLine("hoy es "+HOY.ToString("dddd")+HOY.ToString(" dd")+HOY.ToString(" MMMM ")+ "del "+HOY.ToString("yyyy")+" y son las "+HOY.ToString("hh:mm"));



        }
    }
}
