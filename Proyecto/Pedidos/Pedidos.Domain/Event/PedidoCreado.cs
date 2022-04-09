using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Event
{
    public class PedidoCreado : DomainEvent
    {
        public Guid PedidoId { get; set; } // Como es inmutable no va tener "set"
        public string NroPedido { get; }



        public PedidoCreado(Guid pedidoId, string nroPedido) : base(DateTime.Now)
        {
            PedidoId = pedidoId;
            NroPedido = nroPedido;
            //OccuredOn = occuredOn;
        }
    }
}
