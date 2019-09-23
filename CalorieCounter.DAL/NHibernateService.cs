using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.DAL
{
    using CalorieCounter.DAL.Mappings;
    using CalorieCounter.Model.Entities;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using global::NHibernate;
    using global::NHibernate.Cfg;
    using global::NHibernate.Tool.hbm2ddl;
    using System.IO;

    public class NHibernateService
    {
        private static ISessionFactory _sessionFactory;

        public static ISession OpenSession()
        {
            try
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = OpenSessionFactory();
                }
                ISession session = _sessionFactory.OpenSession();
                return session;
            }
            catch (Exception e)
            {
                throw e.InnerException ?? e;
            }
        }

        public static ISessionFactory OpenSessionFactory()
        {
            try
            {
                _sessionFactory = Fluently.Configure()
                   .Database(SQLiteConfiguration.Standard
                   .ConnectionString("DataSource=caloriecounter.db;Version=3")
                   //.UsingFile("C:/Users/Anita/Downloads/sqlite-tools-win32-x86-3260000/sqlite-tools-win32-x86-3260000/caloriecounter.db")
                   )
                   .Mappings(m => m.FluentMappings.Add<FoodMap>())
                   .Mappings(m => m.FluentMappings.Add<ProgressMap>())
                   .Mappings(m => m.FluentMappings.Add<UserMap>())
                   //.ExposeConfiguration(BuildSchema)
                   .BuildSessionFactory();

                //using (var session = _sessionFactory.OpenSession())
                //{
                //    using (var transaction = session.BeginTransaction())
                //    {

                //        var user = new User { CalorieLimit = 1200 };

                //        var dorinaMousseChocolate = new Food
                //        {
                //            Name = "Dorina Mousse cokolada",
                //            ServingSize = 100,
                //            ServingSizeUnit = "g",
                //            CaloriesInServing = 569,
                //            CarbsInServing = 55.1,
                //            FatsInServing = 36.2,
                //            ProteinsInServing = 6,
                //            User = user
                //        };

                //        var dubravicaSandwich = new Food
                //        {
                //            Name = "Dubravica sendvic sunka-sir",
                //            ServingSize = 250,
                //            ServingSizeUnit = "g",
                //            CaloriesInServing = 643,
                //            CarbsInServing = 80,
                //            FatsInServing = 28,
                //            ProteinsInServing = 25,
                //            User = user
                //        };

                //        var gregorianCalendar = new System.Globalization.GregorianCalendar();

                //        var progress1 = new Progress
                //        {
                //            Weight = 62,
                //            Date = new DateTime(2018, 11, 23, gregorianCalendar)
                //        };

                //        var progress2 = new Progress
                //        {
                //            Weight = 59,
                //            Date = new DateTime(2019, 1, 12, gregorianCalendar)
                //        };

                //        session.SaveOrUpdate(user);
                //        session.SaveOrUpdate(dorinaMousseChocolate);
                //        session.SaveOrUpdate(dubravicaSandwich);
                //        session.SaveOrUpdate(progress1);
                //        session.SaveOrUpdate(progress2);

                //        transaction.Commit();
                //    }
                //}
            }
            catch (Exception)
            {
                throw;
            }

            return _sessionFactory;
        }

        private static void BuildSchema(Configuration config)
        {
            // delete the existing db on each run
            if (File.Exists("C:/Users/Anita/Downloads/sqlite-tools-win32-x86-3260000/sqlite-tools-win32-x86-3260000/caloriecounter.db"))
                File.Delete("C:/Users/Anita/Downloads/sqlite-tools-win32-x86-3260000/sqlite-tools-win32-x86-3260000/caloriecounter.db");

            // this NHibernate tool takes a configuration (with mapping info in)
            // and exports a database schema from it
            new SchemaExport(config)
              .Create(false, true);
        }
    }
}
