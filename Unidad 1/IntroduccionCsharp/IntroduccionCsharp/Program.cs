//using IntroduccionCsharp.Ejemplos;
using IntroduccionCsharp.Ejemplos.Encapsulamiento;
using IntroduccionCsharp.Ejemplos.Herencia;
//Arreglo arreglo  = new(2);

////arreglo.PrintArray();

//arreglo.PrintArrayLimit();

//SwichCase swichCase = new();

//swichCase.SwichCaseSinTryCatch();

//Listas listas = new Listas();

//Empleado empleadoTemporal = new();

//empleadoTemporal.Id = 1;
//empleadoTemporal.Nombre = "Juan Perez";
//empleadoTemporal.SalarioBase = 14000;

//Console.WriteLine($@"El salario del empleado temporal es de {empleadoTemporal.CalcularSalario()}");

//EmpleadoTiempoCompleto empleadoTiempoCompleto = new("Maria Mejia", 2, 14000, 1500);

//Console.WriteLine($@"El salario del empleado tiempo completo es de {empleadoTiempoCompleto.CalcularSalario()}");

//Console.WriteLine("Enpleado por hora");
//EmpleadoPorHora empleadoPorHora = new("Marios Cruz", 3, 0, 56, 30);

//Console.WriteLine($"Salario del empleado por hora es:{ empleadoPorHora.CalcularSalario()}");

CuentaBancaria cuentaBancariaJuanPErez = new(1000);
Console.WriteLine("Saldo Inicial" + cuentaBancariaJuanPErez.ObtenerSaldo());
cuentaBancariaJuanPErez.Depositar(100);

Console.WriteLine("Saldo Inicial" + cuentaBancariaJuanPErez.ObtenerSaldo());
cuentaBancariaJuanPErez.Depositar(100);
