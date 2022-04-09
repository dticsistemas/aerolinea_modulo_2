using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShareKernel.Rules
{
    public class NotNullRule : IBusinessRule
    {
        private object _value;

        public NotNullRule(object value)
        {
            _value = value;
        }

        public string Message => "El Objeto no puede ser nulo!"; //throw new NotImplementedException();


        public bool IsValid()
        {
            return _value != null;
        }
    }
}
