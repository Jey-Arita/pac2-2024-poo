namespace IntroduccionCsharp.Ejemplos.Herencia
{
    public class Empleado
    {   
        //Con pro creamos la propiedad de un solo
        public string? Nombre { get; set; }

        public int Id { get; set; }

        public decimal SalarioBase { get; set; }

        public Empleado() 
        { 
            
        }

        public Empleado(string nombre, int id, decimal salarioBase)
        {
            this.Nombre = nombre;
            this.Id = id;
            this.SalarioBase = salarioBase;
        }

        //Con virtual podemos sobreescribir con otra clase que herede
        public virtual decimal CalcularSalario()
        {
            return this.SalarioBase;
        }

    }
}
