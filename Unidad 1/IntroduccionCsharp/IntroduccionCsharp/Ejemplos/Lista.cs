using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCsharp.Ejemplos
{
    public class Listas
    {
        public Listas()
        {
            List<string> perros = new();

            perros.Add("Ranger");
            perros.Add("Firulais");
            perros.Add("Lazy");

            //Aqui lo insertamos en la posicion que queremos, con dos parametros, la posicion y luego lo que queremos insertar
            perros.Insert(0, "Rambo");

            foreach (var perro in perros)
            {
                Console.WriteLine(perro);
            }
        }
    }
}
