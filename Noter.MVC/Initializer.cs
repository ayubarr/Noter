using EPAMapp.DAL.Repositories.Implementations;
using Noter.DAL.Repositories.Interfaces;
using Noter.Domain.Models.Common;
using Noter.Domain.Models.DTO.Common;
using Noter.Domain.Models.Entities;
using Noter.Services.Implementations;
using Noter.Services.Interfaces;

namespace EPAMapp.API
{
    public static class Initializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAsyncRepository<User>, AsyncRepository<User, AccountHolder>>();
            services.AddScoped<IAsyncRepository<Note>, AsyncRepository<Note, AccountHolder>>();
            services.AddScoped<IAsyncRepository<Admin>, AsyncRepository<Admin, AccountHolder>>();
            services.AddScoped<IAsyncLoginRepository<User>, AsyncRepository<BaseEntity, User>>();
            services.AddScoped<IAsyncLoginRepository<Admin>, AsyncRepository<BaseEntity, Admin>>();
        }
        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<IAsyncBaseService<BaseDTO, User>, AsyncBaseService<BaseDTO, User>>();
            services.AddScoped<IAsyncBaseService<BaseDTO, Note>, AsyncBaseService<BaseDTO, Note>>();
            services.AddScoped<IAsyncBaseService<BaseDTO, Admin>, AsyncBaseService<BaseDTO, Admin>>();
            services.AddScoped<IAsyncLoginService<User, DTOAccountHolder>, AsyncLoginService<User, User, DTOAccountHolder>>();
            services.AddScoped<IAsyncLoginService<Admin, DTOAccountHolder>, AsyncLoginService<Admin, Admin, DTOAccountHolder>>();
        }
    }
}
