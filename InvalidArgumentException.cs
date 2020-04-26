using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class InvalidArgumentException : ApplicationException
    {
       
        private string messageDetails = String.Empty;
        public InvalidArgumentException()
        {
            messageDetails = "Ошибка, вы ввели неправильное значение";
        }
        public override string Message => $"Invalid argument Error Message: {messageDetails}";
    }
}
