using CalorieCounter.Model.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.DAL.Mappings
{
    public class ProgressMap : ClassMap<Progress>
    {
        public ProgressMap()
        {
            Id(x => x.Id);
            Map(x => x.Weight);
            Map(x => x.Date);
            Map(x => x.IsUsersProgress);
            References(x => x.User);
        }
    }
}
