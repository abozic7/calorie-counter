using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Model.Entities
{
    public class Food
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual double ServingSize { get; set; }
        public virtual string ServingSizeUnit { get; set; }
        public virtual double NumberOfServings { get; set; }
        public virtual double CaloriesInServing { get; set; }
        public virtual double ProteinsInServing { get; set; }
        public virtual double CarbsInServing { get; set; }
        public virtual double FatsInServing { get; set; }
        public virtual bool IsConsumed { get; set; }
        public virtual User User { get; set; }
    }
}
