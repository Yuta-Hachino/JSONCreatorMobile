using System;
using Eight.Core.Model;

namespace Eight.Core.Repository
{
    public class UseRepository<TModel> : IDisposable where TModel : IModel, new()
    {
        public Guid ModelId { get; }
        private readonly ModelsStore<TModel> _store;
        public TModel Model => this._store.Instance;

        public UseRepository(Guid modelKey = default)
        {
            _store = new ModelsStore<TModel>(modelKey, new TModel());
            ModelId = _store.ModelId;
        }

        public void Dispose()
        {
            _store?.Dispose();
        }
    }
}
