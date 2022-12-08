using System;

namespace Eight.Core.Model
{
    public interface IModel : IDisposable, ICloneable, IEquatable<IModel>
    {
        public string ToString();
        public string ToJson();
        public IModel FromJson(string json);
        public bool Validate();
        public new object Clone();
        public new void Dispose();
        public new bool Equals(IModel other);
    }
}
