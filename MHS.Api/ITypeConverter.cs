namespace WebApplication1
{
    public interface ITypeConverter<TInput, TOutput>
    {
        TOutput Convert(TInput value);
    }
}