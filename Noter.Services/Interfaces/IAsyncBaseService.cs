using Noter.Domain.Models.Common;
using Noter.Domain.Models.DTO.Common;
using Noter.Domain.Models.Interfaces;

namespace Noter.Services.Interfaces
{
    public interface IAsyncBaseService<T, Tmodel>
        where T : BaseDTO
        where Tmodel : BaseEntity
    {
        public Task<IBaseResponse<Tmodel>> Create(T model);       //C - Create
        public IBaseResponse<List<Tmodel>> GetAll();              //R - Read all
        public Task<IBaseResponse<List<Tmodel>>> GetAllAsync();   //R - Read all async
        public IBaseResponse<Tmodel> GetModelById(int id);        //R - Read one
        public Task<IBaseResponse<List<Tmodel>>> GetNotesModelsByUserIdAsync(int id); // R - Read notes by user id
        public Task<IBaseResponse<Tmodel>> Update(T model);       //U - Update
        public Task<IBaseResponse<Tmodel>> Delete(T model);       //D - Delete one
        public Task<IBaseResponse<bool>> Delete(int id);          //D - Delete one by id

    }
}
