namespace PolicyAddOns
{
    internal interface IValidate<T>
    {
        bool Validate(T entity);
    }
}