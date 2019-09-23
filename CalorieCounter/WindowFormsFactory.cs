using CalorieCounter.BaseLib;
using CalorieCounter.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter
{
    public class WindowFormsFactory : IWindowFormsFactory
    {
        public ICalorieLimitCalculationView CreateCalorieLimitCalculationView(IInitialRunController inInitialRunController, IUserController inUserController, IRepositoryFactory inRepositoryFactory)
        {
            var newFrm = new frmStartCalorieLimitWindow(inInitialRunController, inUserController, inRepositoryFactory);
            return newFrm;
        }
    }
}
