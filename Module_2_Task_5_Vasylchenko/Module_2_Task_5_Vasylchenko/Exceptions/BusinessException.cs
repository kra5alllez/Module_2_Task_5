using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_Task_5_Vasylchenko.Exceptions
{
    public class BusinessException : Exception
    {
        public BusinessException(string message)
            : base(message)
        {
        }
    }
}
