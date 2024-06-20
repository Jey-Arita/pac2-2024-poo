using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCsharp.Ejemplos.Herencia
{
    public class EmpleadoTiempoCompleto : Empleado
    {
        public decimal Bono { get; set; }

        public EmpleadoTiempoCompleto(string nombre, int id, decimal salarioBase, decimal bono) : base(nombre,id,salarioBase)
        {
            this.Bono = bono;

        }

        //Aqui sobreescribimos el metodo
        public override decimal CalcularSalario()
        {
            return SalarioBase + Bono;
        }
    }
}
