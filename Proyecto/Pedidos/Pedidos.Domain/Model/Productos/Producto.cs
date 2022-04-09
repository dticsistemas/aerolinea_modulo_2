using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Productos
{
    public class Producto : AggregateRoot<Guid>
    {
        public Producto()
        {
            Id = Guid.NewGuid();
        }
    }
}
