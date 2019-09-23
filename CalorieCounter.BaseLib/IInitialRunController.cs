using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.BaseLib
{
    public interface IInitialRunController
    {
        double ShowCalorieLimit(double height, double weight, int age, int gender, int activityLvl, int goal, int goalAmount);
    }
}
