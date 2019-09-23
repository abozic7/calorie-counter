using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.BaseLib
{
    public interface ICalorieLimitCalculationView
    {
        void ShowModaless(ICalorieLimitCalculationController inCalorieLimitCalculationController);
    }
}
