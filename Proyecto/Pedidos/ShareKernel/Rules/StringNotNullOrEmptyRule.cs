using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.Rules
{
    public class StringNotNullOrEmptyRule : IBusinessRule
    {
        private string _value;

        public StringNotNullOrEmptyRule(string value)
        {
            _value = value;
        }

        public string Message => "La cadena no puede ser nul1!"; //throw new NotImplementedException();


        public bool IsValid()
        {
            return !string.IsNullOrEmpty(_value);
        }
    }
}
