using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Model.Entities
{
    public class User
    {
        public virtual int Id { get; protected set; }
        public virtual double CalorieLimit { get; set; }
        public virtual IList<Food> ConsumedFood { get; set; }
        public virtual IList<Progress> Progress { get; set; }

        public User()
        {
            ConsumedFood = new List<Food>();
            Progress = new List<Progress>();
        }
    }
}
