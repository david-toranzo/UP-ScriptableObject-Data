using ScriptableObjects.Event;

namespace ScriptableObjects.Data
{
    public class TypeDataEventScriptableObject<TypeData> : TypeEventScriptableObject<TypeData>, IDataType<TypeData>
    {
        private TypeData _typeData;

        public TypeData Data { get => _typeData; }

        public void SetTypeData(TypeData newData)
        {
            _typeData = newData;
            InvokeEventType(_typeData);
        }
    }
}