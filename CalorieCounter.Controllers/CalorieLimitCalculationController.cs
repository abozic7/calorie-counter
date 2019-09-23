using CalorieCounter.BaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Controllers
{
    public class CalorieLimitCalculationController : ICalorieLimitCalculationController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private const double MaleWeightConst = 13.397;
        private const double FemaleWeightConst = 9.247;
        private const double MaleHeightConst = 4.799;
        private const double FemaleHeightConst = 3.098;
        private const double MaleAgeConst = 5.677;
        private const double FemaleAgeConst = 4.33;
        private const double MaleCalorieConst = 88.362;
        private const double FemaleCalorieConst = 447.593;
        private const double SedentaryMultiplier = 1.2;
        private const double LightActivityMultiplier = 1.375;
        private const double ModerateActivityMultiplier = 1.55;
        private const double VeryActiveMultiplier = 1.725;
        private const double ExtraActiveMultiplier = 1.9;

        public CalorieLimitCalculationController(IWindowFormsFactory inFormsFactory)
        {
            _formsFactory = inFormsFactory;
        }

        public double CalculateCalorieLimit(double height, double weight, int age, int gender, int activityLevel, int goal, int goalAmount)
        {
            double hbCalorieLimit = RevisedHarrisBenedictEquation(height, weight, age, gender);
            double calorieLimitMaintain = MultiplyCalorieLimitByActivityLevel(activityLevel, hbCalorieLimit);
            double result = GetCalorieLimitByGoal(calorieLimitMaintain, goal, goalAmount);
            return result;
        }

        public double RevisedHarrisBenedictEquation(double height, double weight, int age, int gender)
        {
            if (gender == (int) GenderEnum.Male)
            {
                return MaleWeightConst * weight + MaleHeightConst * height - MaleAgeConst * age + MaleCalorieConst;
            }
            else
            {
                return FemaleWeightConst * weight + FemaleHeightConst * height - FemaleAgeConst * age + FemaleCalorieConst;
            }
        }

        public double MultiplyCalorieLimitByActivityLevel(int activityLevel, double calorieLimit)
        {
            double result = 0;
            switch (activityLevel)
            {
                case (int)ActivityLevelEnum.Sedentary:
                    result = calorieLimit * SedentaryMultiplier;
                    break;
                case (int)ActivityLevelEnum.LightActivity:
                    result = calorieLimit * LightActivityMultiplier;
                    break;
                case (int)ActivityLevelEnum.ModerateActivity:
                    result = calorieLimit * ModerateActivityMultiplier;
                    break;
                case (int)ActivityLevelEnum.VeryActive:
                    result = calorieLimit * VeryActiveMultiplier;
                    break;
                case (int)ActivityLevelEnum.ExtraActive:
                    result = calorieLimit * ExtraActiveMultiplier;
                    break;
                default:
                    break;
            }

            return result;
        }

        public double GetCalorieLimitByGoal(double calorieLimitMaintain, int goal, int goalAmount)
        {
            double result = 0;
            double calorieVariation = 0;
            switch (goalAmount)
            {
                case 0:
                    calorieVariation = 0;
                    break;
                case (int)GoalAmountEnum.Quarter:
                    calorieVariation = (int)CalorieVariationEnum.Quarter;
                    break;
                case (int)GoalAmountEnum.Half:
                    calorieVariation = (int)CalorieVariationEnum.Half;
                    break;
                case (int)GoalAmountEnum.ThreeQuarters:
                    calorieVariation = (int)CalorieVariationEnum.ThreeQuarters;
                    break;
                case (int)GoalAmountEnum.One:
                    calorieVariation = (int)CalorieVariationEnum.One;
                    break;
                default:
                    break;
            }

            switch (goal)
            {
                case (int)GoalsEnum.MaintainWeight:
                    result = calorieLimitMaintain;
                    break;
                case (int)GoalsEnum.LoseWeight:
                    result = calorieLimitMaintain - calorieVariation;
                    break;
                case (int)GoalsEnum.GainWeight:
                    result = calorieLimitMaintain + calorieVariation;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
