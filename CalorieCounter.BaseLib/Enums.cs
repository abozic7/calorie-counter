using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.BaseLib
{
    public enum GenderEnum
    {
        Male = 1,
        Female = 2
    }

    public enum ActivityLevelEnum
    {
        Sedentary = 1,
        LightActivity = 2,
        ModerateActivity = 3,
        VeryActive = 4,
        ExtraActive = 5
    }

    public enum GoalsEnum
    {
        LoseWeight = 1,
        MaintainWeight = 2,
        GainWeight = 3
    }

    public enum GoalAmountEnum
    {
        Quarter = 1,
        Half = 2,
        ThreeQuarters = 3,
        One = 4
    }

    public enum CalorieVariationEnum
    {
        Quarter = 250,
        Half = 500,
        ThreeQuarters = 750,
        One = 1000
    }
}
