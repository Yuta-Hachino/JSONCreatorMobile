using System;
using Eight.Core.Model;

namespace Eight.Core.Repository
{
    public class ModelsStore<TModel> : IDisposable where TModel : IModel
    {
        internal TModel Instance = default;
        internal Guid ModelId => _factory.ModelKey;
        private ModelsFactory _factory = null;

        //引数無コンストラクタ無効
        private ModelsStore(){}
        internal ModelsStore(Guid modelKey, TModel model)
        {
            _factory = new ModelsFactory(modelKey, model.Clone() as IModel);
            Instance = (TModel)_factory.GetModel();
        }

        public void Dispose()
        {
            Instance.Dispose();
            _factory.Dispose();
        }
    }
}
