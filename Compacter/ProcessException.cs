using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compacter
{
    class ProcessException : ApplicationException
    {
        public ProcessException(string message) : base(message)
        {
        }
    }
}
