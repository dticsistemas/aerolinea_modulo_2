using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.Core
{
    public interface IBusinessRule
    {
        bool IsValid();

        string Message { get; }
    }
}
