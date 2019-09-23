using CalorieCounter.Model.Entities;
using CalorieCounter.Model.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.DAL.Repositories
{
    public class ProgressRepository : IProgressRepository
    {
        ISession _currSession = null;

        public ProgressRepository(ISession inSession)
        {
            _currSession = inSession;
        }

        public List<Progress> GetProgress()
        {
            return _currSession.Query<Progress>().ToList();
        }

        public void AddProgress(Progress progress)
        {
            using (var transaction = _currSession.BeginTransaction())
            {
                _currSession.SaveOrUpdate(progress);
                transaction.Commit();
            }
        }        
    }
}
