using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCsharp.Ejemplos
{
    public class SwichCase
    {
        public SwichCase()
        {
            int opc = 0;
            Console.WriteLine("Hola elija una opcion: \n 1.Iniciar \n 2.Detener \n 3.Reiniciar \n 4.Estado \n (escirba una opcion):");

            //Forma para evitar que lea valores nulos en strig colocamos "0"
            try
            {
                //Aqui estamos evaluando que al devolver nulo, lo convierta en 0
                opc = int.Parse(Console.ReadLine() ?? "0");

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Iniciando proceso....");
                        break;

                    case 2:
                        Console.WriteLine("Deteniendo proceso");
                        break;

                    case 3:
                        Console.WriteLine("Reiniciando el proceso");
                        break;

                    case 4:
                        Console.WriteLine("Actualmente esta....");
                        break;

                    default:
                        Console.WriteLine("No exite la opcion");
                        break;
                }

            }
            //Capturamos el error, pero al mostrar el error a de tener cuidado por credenciales o cosas asi
            catch (Exception ex) { Console.WriteLine("Ha ocurrido un error:" + ex.Message); }

        }

        //Void porque no devuelve nada, este solo era de prueba para ver errores
        //public void SwichCaseSinTryCatch()
        //{
        //    int opc = 0;
        //    Console.WriteLine("Hola elija una opcion: \n 1.Iniciar \n 2.Detener \n 3.Reiniciar \n 4.Estado \n (escirba una opcion):");
        //    opc = int.Parse(Console.ReadLine() ?? "0");

        //    switch (opc)
        //    {
        //        case 1:
        //            Console.WriteLine("Iniciando proceso....");
        //            break;

        //        case 2:

        //            Console.WriteLine("Deteniendo proceso");
        //            break;

        //        case 3:
        //            Console.WriteLine("Reiniciando el proceso");
        //            break;

        //        case 4:
        //            Console.WriteLine("Actualmente esta....");
        //            break;

        //        default:
        //            Console.WriteLine("No exite la opcion");
        //            break;
        //    }
        //}
    }
}

