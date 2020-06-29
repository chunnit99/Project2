using System;
using System.Text;
using System.Collections.Generic;
namespace Ultilities
{
    public class ExceptionId : Exception
    {
        public ExceptionId()
        {
        }
        public ExceptionId (string message) : base(message)
        {
        }
        public ExceptionId(string message, Exception inner) : base(message,inner)
        {

        }
    }
}
