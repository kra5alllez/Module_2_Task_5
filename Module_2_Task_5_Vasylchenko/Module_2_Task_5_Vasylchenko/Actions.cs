using System;
using Module_2_Task_5_Vasylchenko.Exceptions;

namespace Module_2_Task_5_Vasylchenko
{
    public class Actions
    {
        private readonly Logger _logger = Logger.Instance();
        public bool InfoMethod()
        {
            _logger.LogInfo($"Start method: {nameof(InfoMethod)}");
            return true;
        }

        public bool WarningMethod()
        {
            throw new BusinessException("Skipped logic in method");
        }

        public bool ErrorMethod()
        {
            throw new Exception("I broke a logic");
        }
    }
}
