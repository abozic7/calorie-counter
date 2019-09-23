using CalorieCounter.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.BaseLib
{
    public interface IWindowFormsFactory
    {
        ICalorieLimitCalculationView CreateCalorieLimitCalculationView(IInitialRunController inInitialRunController, IUserController inUserController, IRepositoryFactory inRepositoryFactory);
    }
}
