using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Rectangulo
    {

        public float ancho;
        public float alto;


        public void ImprimirR()
        {
            Console.WriteLine("Ingrese el ancho del rectangulo");
            ancho=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el alto del rectangulo");
            alto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Perimetro);
            Perimetro();
            Area();
        }
        public void Perimetro()
        {
            float perimetro;
            perimetro = 2*(ancho+alto);
            Console.WriteLine("El perimetro es " +perimetro);
        }
        public void Area()
        {
            float area;
            area = ancho * alto;
            Console.WriteLine("El area es " + area);


        }
    }
}
