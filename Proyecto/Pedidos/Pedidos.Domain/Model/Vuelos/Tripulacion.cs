//using Pedidos.Domain.Model.Administracion;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pedidos.Domain.Model.Vuelos
{
    public class Tripulacion : Empleados
    {
        public decimal Millas { get; private set; }
        public decimal Horas { get; private set; }

        internal Tripulacion(Guid idEmpleado, string nombres, string apellidos,
                    char sexo, DateTime fechaNacimiento, string cargo,
                    decimal salario, bool estado)
        {
            IdEmpleado = idEmpleado;
            Nombres = nombres;
            Apellidos = apellidos;
        }
    }
}
