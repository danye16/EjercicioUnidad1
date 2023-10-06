using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    

        public class Libros
        {
        public string autor {  get; set; }
        public string titulo { get; set; }

        public Libros(string autor, string titulo) 
        {
            this.autor = autor;
            this.titulo = titulo;
        }

            public void Biblioteca()
            {
            Console.WriteLine("Ingresa el Autor");
            autor = Console.ReadLine();
            Console.WriteLine("Ingresa el Titulo");
            titulo = Console.ReadLine();
            Console.WriteLine(this.autor + this.titulo);
            }
            
        }
   
}
