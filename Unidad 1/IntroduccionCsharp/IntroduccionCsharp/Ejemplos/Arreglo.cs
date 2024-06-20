namespace IntroduccionCsharp.Ejemplos
{
    public class Arreglo
    {
        // El metodo condstructor
        public int ver { get; set; }

        // El contructor no devulve nada, siempre se llama igual que la clase
        public Arreglo(int ver) 
        {
            this.ver = ver;
        }
        public void PrintArray()
        {
            String[] nombres = { "Juan", "Maria", "Ruperto", "Petrolina", "Ramon" };

            foreach (var nombre in nombres)
            {
                Console.WriteLine("Hola " + nombre);
            }
        }

        public void PrintArrayLimit()
        {
            String[] nombres = { "Juan", "Maria", "Ruperto", "Petrolina", "Ramon" };

            for (int i = 0; i < ver; i++)
            {
                Console.WriteLine("Hola " + nombres[i]);
            }

            //int x = 0;

            //foreach (var nombre in nombres)
            //{
            //    if (x < ver)
            //    {
            //        Console.WriteLine("Hola " + nombre);
            //    }
            //    x++;
            //}
        }
    }
    
}
