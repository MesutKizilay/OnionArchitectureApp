using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Exceptions
{
	public class ValidationException:Exception
	{
        public ValidationException():this("Validaiton error occured")
        {
            
        }

        public ValidationException(string Message):base(Message)
        {
            
        }

        public ValidationException(Exception e):this(e.Message)
        {
            
        }
    }
}
