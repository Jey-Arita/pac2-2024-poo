namespace IntroduccionCsharp.Ejemplos.Encapsulamiento
{
    internal class CuentaBancaria
    {
        private decimal Saldo { get; set; }

        public CuentaBancaria(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad; // Saldo = saldo + cantidad
            }
            else
            {
                Console.WriteLine("La cantidad a depositar debe ser positiva");
            }
        }

        public void Retirar(decimal cantidad) 
        {
            if (cantidad > 0 && cantidad <= Saldo) 
            {
                Saldo -= cantidad;
            }
            else
            {
                Console.WriteLine("Cantidad invalida para retirar.");
            }
        }

        public decimal ObtenerSaldo() 
        { 
            return Saldo;
        }
    }
}
