using Noter.Domain.Models.Common;
using Noter.Domain.Models.DTO.Common;
using Noter.Domain.Models.Interfaces;

namespace Noter.Services.Interfaces
{
    public interface IAsyncLoginService<H, T> 
        where H : AccountHolder
        where T : DTOAccountHolder
    {
        public Task<IBaseResponse<H>> Register(T model);
        public Task<IBaseResponse<H>> Login(T model);
    }
}
