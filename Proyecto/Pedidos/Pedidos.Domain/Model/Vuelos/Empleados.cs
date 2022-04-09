using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Vuelos
{
    public class Empleados : Entity<Guid>
    {
        public Guid IdEmpleado { get;  set; }
        public string Nombres { get;  private set; }
        public string Apellidos { get; private set; }
        public char Sexo { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
        public string Cargo { get; private set; }
        public decimal Salario { get; private set; }
        public bool Estado { get; private set; }


        internal Empleados(Guid idEmpleado, string nombres, string apellidos,
                    char sexo, DateTime fechaNacimiento, string cargo,
                    decimal salario, bool estado)
        {
            Id = Guid.NewGuid();
            IdEmpleado = idEmpleado;
            Nombres = nombres;
            Apellidos = apellidos;
            Sexo = sexo;
            FechaNacimiento = fechaNacimiento;
            Cargo = cargo;
            Salario = salario;
            Estado = estado;
        }
    }
}
