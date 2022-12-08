using System.Linq;
using Eight.Core.Repository;
using Eight.Core.Service;
using Model;
using UnityEngine;

namespace Service
{
    public class ApplicationStartUpService : IService
    {
        private UseRepository<LogModel> _logModelRepository;
        public ApplicationStartUpService()
        {
            Debug.Log("Startup...");
            _logModelRepository = new UseRepository<LogModel>();
            _logModelRepository.Model.Comment = "test";
#if UNITY_EDITOR
            Debug.Log($"{(ModelsFactory.Factory.First().Value as LogModel)?.Comment}");
#endif
        }

        public void Dispose()
        {
            Debug.Log("Startup Ended!");
        }
    }
}
