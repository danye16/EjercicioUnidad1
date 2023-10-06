namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Ejercicios ejercicios = new Ejercicios();


            //Programas

            //   ejercicios.Persona();
            /*Ejercicio 2
                        Vehiculo auto = new Vehiculo();
                        auto.Padre();


                        Auto vehiculo = new Auto();
                        vehiculo.Padre();
                        vehiculo.Hijo();
            */

            //  Ejercicio 3

            // ejercicios.Calculadora();

            Rectangulo rectangulo = new Rectangulo();

           // rectangulo.ImprimirR();

            Libros libro = new Libros("Titulo","Autor");


            // libro.Biblioteca();

            Coordenadas coordenadas;
            
            coordenadas.x = "34314214";
            coordenadas.y = "134134134";
            Console.WriteLine($"x esta en {coordenadas.x} e y esta en {coordenadas.y}");

            Fecha fecha = new Fecha();
            fecha.año = "2005";
            fecha.mes = "Julio";
            fecha.dia = "16";

            Console.WriteLine(fecha.Fechas());

            Temperatura temperatura = new Temperatura();
            temperatura.ConversionTemp();
        
        }


    }
}