namespace ScriptableObjects.Data
{
    public interface IDataType<TypeData>
    {
        TypeData Data { get; }

        void SetTypeData(TypeData newData);
    }
}