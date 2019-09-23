using CalorieCounter.BaseLib;
using CalorieCounter.DAL;
using CalorieCounter.Model.Entities;
using CalorieCounter.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Controllers
{
    public class ProgressController : IProgressController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private IRepositoryFactory _repositoryFactory;
        private readonly IProgressRepository _progressRepository;

        public ProgressController(IWindowFormsFactory inWindowFormsFactory, IRepositoryFactory inRepositoryFactory)
        {
            _formsFactory = inWindowFormsFactory;
            _repositoryFactory = inRepositoryFactory;
            _progressRepository = _repositoryFactory.GetProgressRepository();
        }

        public void AddProgress(Progress progress)
        {
            _progressRepository.AddProgress(progress);
        }

        public List<Progress> GetProgress()
        {
            return _progressRepository.GetProgress();
        }
    }
}
