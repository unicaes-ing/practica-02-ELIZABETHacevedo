using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA2
{
    class Class5
    {
        public void eje1()
        {


            TimeSpan horaInicio, horaFin;
            double valorMinuto;
            double min;

            Console.WriteLine("ingrese la hora de inicio de la llamada: ");
            horaInicio = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("ingresev la hora de fin de la llamada: ");
            horaFin = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor por minuto de la llamada:");
            do
            {
                if (double.TryParse(Console.ReadLine(),out valorMinuto) && valorMinuto>0 )
                {
                    break;
                }
            } while (true);
            min = ((horaFin - horaInicio).TotalMinutes);

            Console.WriteLine("el valor a pagar es {0}",(min*valorMinuto).ToString("C2"));


        }


    }
}
