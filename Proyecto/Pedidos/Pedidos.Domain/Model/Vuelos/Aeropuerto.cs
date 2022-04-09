using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Vuelos
{
    public class Aeropuerto : Entity<Guid>
    {
        public Guid IdAeropuerto { get; private set; }
        public string NombreAeropuerto { get; private set; }
        public string CiudadAeropuerto { get; private set; }
        public string CodigoAeropuerto { get; private set; }
        public string Departamento { get; private set; }


        public Aeropuerto()
        {
            Id = Guid.NewGuid();
        }


        internal Aeropuerto(Guid idAeropuerto, string nombreAeropuerto, string ciudadAeropuerto,
            string codigoAeropuerto, string departamento)
        {
            Id = Guid.NewGuid();
            IdAeropuerto = idAeropuerto;
            NombreAeropuerto = nombreAeropuerto;
            CiudadAeropuerto = ciudadAeropuerto;
            CodigoAeropuerto = codigoAeropuerto;
            Departamento = departamento;           
        }


        private void RegistrarAeropuerto()
        {

        }

    }
}
