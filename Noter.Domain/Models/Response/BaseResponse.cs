using Noter.Domain.Models.Interfaces;

namespace Noter.Domain.Models.Response
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public string Description { get; set; }

        public T Data { get; set; }
    }
}
