using System;
using System.Collections.Generic;
using System.Text;
using Module_2_Task_5_Vasylchenko.Exceptions;

namespace Module_2_Task_5_Vasylchenko
{
    public class Starter
    {
        private readonly Random _random;
        private readonly Logger _logger;
        private readonly Actions _action;
        public Starter()
        {
            _random = new Random();
            _logger = Logger.Instance();
            _action = new Actions();
        }

        public void Run()
        {
            const int minRandom = 1;
            const int maxRandom = 4;
            for (var i = 0; i < 100; i++)
            {
                try
                {
                    var random = _random.Next(minRandom, maxRandom);
                    switch (random)
                    {
                        case 1:
                            _action.InfoMethod();
                            break;
                        case 2:
                            _action.WarningMethod();
                            break;
                        case 3:
                            _action.ErrorMethod();
                            break;
                    }
                }
                catch (BusinessException ex)
                {
                    _logger.LogBsnsExceptions($"Action got this custom Exception: {ex.Message}");
                }
                catch (Exception ex)
                {
                    _logger.LogExceptions($"Action failed by reason: {ex.Message}");
                }
            }
        }
    }
}
