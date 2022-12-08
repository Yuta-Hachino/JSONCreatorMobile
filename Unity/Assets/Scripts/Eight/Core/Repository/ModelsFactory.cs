using System;
using System.Collections.Generic;
using Eight.Core.Model;

namespace Eight.Core.Repository
{
    internal class ModelsFactory : IDisposable
    {
#if UNITY_EDITOR
        public static Dictionary<Guid, IModel> Factory => _factory;
#endif
        private static readonly Dictionary<Guid, IModel> _factory = new Dictionary<Guid, IModel>();
        internal Guid ModelKey { get; } = Guid.Empty;

        private ModelsFactory(){}
        internal ModelsFactory(Guid key, IModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException();
            }

            ModelKey = key == Guid.Empty 
                ? Guid.NewGuid() 
                : key;
            
            if (!_factory.ContainsKey(ModelKey))
            {
                if (key != Guid.Empty)
                {
                    throw new KeyNotFoundException();
                }
                
                _factory.Add(ModelKey, model);
            }
        }

        internal IModel GetModel() 
            => _factory.ContainsKey(ModelKey) 
                ? _factory[ModelKey] 
                : null;

        public void Dispose()
            => _factory.Remove(ModelKey);
    }
}
