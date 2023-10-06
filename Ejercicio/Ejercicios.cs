using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Ejercicios
    {
        public void Persona()

        {
            string nombre;
            int edad;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad");

            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Su nombre es {nombre} y su edad es {edad}");


        }
        public void Calculadora()
        {
            float numero1, numero2, opcion;
            
            Console.WriteLine("Ingrese dos numeros");
            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese 1 para +, 2 para -, 3 para * y 4 para /");
            opcion = Convert.ToInt32(Console.ReadLine());


            switch (opcion) 
            {
            case 1:

                    float suma = numero1 + numero2;
                    Console.WriteLine("El resulado de la suma es " + suma);

                    break;
            case 2:
                    float resta= numero1 - numero2;
                    Console.WriteLine("El resultado de la resta es " + resta);
                    break;

                case 3:
                
                    Console.WriteLine("El resultado de la Multiplicacion es " + numero2*numero1);
                    break;

                case 4:
                    if (numero2 != 0)
                        Console.WriteLine("El resultado de la division es " + numero1 / numero2);
                    else Console.WriteLine("No se puede dividir entre 0");
                    break;



            }

          



        }
    }


    public class Vehiculo
    {
        public string marca="es una marca";
       
      public void Padre()
        { Console.WriteLine(marca); }
    }

    public class Auto: Vehiculo
    {
        string modelo="es un modelo";
        
        public void Hijo() 
        { Console.WriteLine(modelo); }
    }
}
