using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea una nueva coleccion desde una clase generica para tasas.
            ClaseBase<Tasa> ColeccionTasas = new ClaseBase<Tasa>();

            //Creamos nuevos objetos de tasas para agregarlos a la coleccion.
            Tasa Tasa1 = new Tasa() { codigo = 1, porcentaje = 5.0, recargo = 2.5 };
            Tasa Tasa2 = new Tasa() { codigo = 2, porcentaje = 4.0, recargo = 1.0 };
            Tasa Tasa3 = new Tasa() { codigo = 3, porcentaje = 2.0, recargo = 4.0 };

            //Agregamos a Coleccion de Tasas
            ColeccionTasas.Agregar(Tasa1);
            ColeccionTasas.Agregar(Tasa2);
            ColeccionTasas.Agregar(Tasa3);
                       
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------");
            Console.WriteLine("Listar Tasas:");

            //Listar Colleccion de Tasas con For
            for (int x = 0; x < ColeccionTasas.Contar; x++)
            {
                var Elemento = ColeccionTasas[x];
                Console.WriteLine("Tasa " + Elemento.codigo.ToString() + ": " + Elemento.porcentaje.ToString());
            }

            //Eliminar Un elemento de la coleccion
            ColeccionTasas.Eliminar(1);

            Console.WriteLine("---------------------");
            Console.WriteLine("Listar Tasas Restantes:");

            //Listar Collecion de tasas con ForEach
            foreach (var Elemento in ColeccionTasas)
            {
                Console.WriteLine("Tasa " + Elemento.codigo.ToString() + ": " + Elemento.porcentaje.ToString());
            }

            //Mostrar la Cantidad de Elemntos
            Console.WriteLine("---------------------");
            Console.WriteLine("Tasas Restantes: " + ColeccionTasas.Contar.ToString ());
            Console.ReadLine();

        }
    }
}
