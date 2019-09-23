using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.BaseLib
{
    public interface ICalorieLimitCalculationController
    {
        double CalculateCalorieLimit(double height, double weight, int age, int gender, int activityLevel, int goal, int goalAmount);
    }
}
