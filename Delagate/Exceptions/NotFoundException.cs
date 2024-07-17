using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagate.Exceptions
{
    public class NotFoundException:Exception
    {
        public NotFoundException(string message = "Element is not found") :base(message)
        {
            
        }
    }
}
