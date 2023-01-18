using UnityEngine;

namespace ScriptableObjects.Data
{
    public abstract class TypeDataScriptableObject<TypeData> : ScriptableObject, IDataType<TypeData>
    {
        private TypeData _typeData;

        public TypeData Data { get => _typeData; }

        public void SetTypeData(TypeData newData)
        {
            _typeData = newData;
        }
    }
}
