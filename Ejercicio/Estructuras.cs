using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    struct Coordenadas
    {
        public string x;
        public string y;
    }

    struct Fecha
    {
        public string dia;
        public string mes;
        public string año;

        public string Fechas() 
        {  
            return "La fecha es Dia "+dia +" Mes "+mes+" Año "+año; 
        }
           
    }

    struct Temperatura
    {
        public float temperaturaCelsius;

        public void ConversionTemp()
        {
            float fahrenheit;
            Console.WriteLine("Ingrese la temperatura en Celsius");
            temperaturaCelsius=Convert.ToInt32(Console.ReadLine());
            fahrenheit = (temperaturaCelsius*9/5)+32;

            Console.WriteLine("La temperatura en Fahrenheit es "+ fahrenheit);
        }

    }
}
