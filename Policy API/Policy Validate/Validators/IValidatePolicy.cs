namespace PolicyValidate.Validators
{
    public interface IValidate<T>
    {
        ValidationResult Validate(T entity);
    }
}