using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Model.Entities
{
    public class Progress
    {
        public virtual int Id { get; set; }
        public virtual double Weight { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual bool IsUsersProgress { get; set; }
        public virtual User User { get; set; }
    }
}
