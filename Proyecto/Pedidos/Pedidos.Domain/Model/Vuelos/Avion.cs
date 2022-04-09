using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pedidos.Domain.Model.Vuelos
{
    public class Avion : Entity<Guid>
    {
        public Guid IdAvion { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int NroAsientos { get; private set; }
        public string Matricula { get; private set; }
        public decimal CapacidadCombustible { get; private set; }
        public bool Estado { get; private set; }


        internal Avion(Guid idAvion, string marca, string modelo,
                    int nroAsientos, string matricula, decimal capacidadCombustible,
                    bool estado)
        {
            Id = Guid.NewGuid();
            IdAvion = idAvion;
            Marca = marca;
            Modelo = modelo;
            NroAsientos = nroAsientos;
            Matricula = matricula;
            CapacidadCombustible = capacidadCombustible;
            Estado = estado;

        }


        public void RegistrarAvion()
        {

        }
    }
}
