using CalorieCounter.Model.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.DAL.Mappings
{
    public class FoodMap : ClassMap<Food>
    {
        public FoodMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.ServingSize);
            Map(x => x.ServingSizeUnit);
            Map(x => x.NumberOfServings).Default("1");
            Map(x => x.CaloriesInServing);
            Map(x => x.ProteinsInServing);
            Map(x => x.CarbsInServing);
            Map(x => x.FatsInServing);
            Map(x => x.IsConsumed);
            References(x => x.User);
        }
    }
}
