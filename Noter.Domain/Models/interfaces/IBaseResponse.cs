namespace Noter.Domain.Models.Interfaces
{
    public interface IBaseResponse<T>
    {
        string Description { get; }
        T Data { get; }
    }
}
