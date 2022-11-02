using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Service.Exceptions
{
    public class NoFoundException:Exception
    {
        public NoFoundException(string message):base(message)
        {


        }
    }
}
