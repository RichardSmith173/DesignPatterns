namespace PolicyAddOns.DataAccess
{
    internal interface IWriteRepository<T>
    {
        void Update(T entity);
    }
}