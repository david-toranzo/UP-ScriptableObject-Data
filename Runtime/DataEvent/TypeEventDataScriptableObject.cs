using ScriptableObjects.Event;
using System;

namespace ScriptableObjects.Data
{
    public abstract class TypeEventDataScriptableObject<Type> : TypeDataScriptableObject<Type>, IEventType<Type>
    {
        public Action<Type> OnTypeEvent { get; set; }

        public void InvokeEventType(Type data)
        {
            OnTypeEvent?.Invoke(data);
        }
    }
}