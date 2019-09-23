using CalorieCounter.Model.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.DAL.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);
            Map(x => x.CalorieLimit);
            HasMany(x => x.ConsumedFood)
                .Inverse()
                .Cascade.All();
            HasMany(x => x.Progress)
                .Inverse()
                .Cascade.All();
        }
    }
}
