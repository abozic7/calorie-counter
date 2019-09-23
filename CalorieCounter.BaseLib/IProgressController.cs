using CalorieCounter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.BaseLib
{
    public interface IProgressController
    {
        void AddProgress(Progress progress);
        List<Progress> GetProgress();
    }
}
