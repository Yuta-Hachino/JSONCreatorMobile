using System;
using Eight.Core.Model;
using UnityEngine;

namespace Model
{
    [Serializable]
    public class LogModel : IModel
    {
        [SerializeField]
        public string Comment { get; set; } = "";
        
        public void Dispose()
        {
            
        }

        public object Clone()
        {
            return new LogModel
            {
                Comment = this.Comment
            };
        }

        public bool Equals(IModel other)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public string ToJson()
        {
            throw new System.NotImplementedException();
        }

        public IModel FromJson(string json)
        {
            throw new System.NotImplementedException();
        }

        public bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}