﻿using EPAMapp.Domain.Helpers;
using Noter.DAL.DataBaseExists;
using Noter.DAL.Repositories.Interfaces;
using Noter.Domain.Models.Common;
using Noter.Domain.Models.DTO.Common;
using Noter.Domain.Models.Entities;
using Noter.Domain.Models.Interfaces;
using Noter.Domain.Models.Response;
using Noter.Services.Interfaces;

namespace Noter.Services.Implementations
{
    public class AsyncLoginService<H, Tmodel, T> : IAsyncLoginService<H, T>
        where H : AccountHolder
        where Tmodel : BaseEntity
        where T : DTOAccountHolder
    {
        private readonly IAsyncLoginRepository<H> _repositoryLogin;
        private readonly IAsyncRepository<Tmodel> _repository;


        public AsyncLoginService(IAsyncLoginRepository<H> repositoryLogin, IAsyncRepository<Tmodel> repository)
        {
            _repositoryLogin = repositoryLogin;
            _repository = repository;
        }

        public async Task<IBaseResponse<H>> Register(T model)
        {
            try
            {
                var existingUser = await _repositoryLogin.GetByEmailAsync(model.Email);
                if (!Exist<BaseEntity, BaseDTO, H>.EntityIsNotExist(existingUser)) return new BaseResponse<H>()
                {
                    Description = "Пользователь с таким email уже зарегистрирован."

                };

                model.Password = HashPasswordHelper.HashPassword(model.Password);

                User user = new()
                {
                    Email = model.Email,
                    Password = model.Password,
                    Name = "",
                    LastName = ""
                };


                //CreateMapper<Tmodel, DTOCreateBase> mapper = new();
                //Tmodel user = mapper.Map(model as DTOCreateUser);


                await _repository.Create(user as Tmodel);
                return new BaseResponse<H>()
                {
                    Data = user as H
                };
            }
            catch (Exception e)
            {

                return new BaseResponse<H>() { Description = e.Message };
            }


        }

        public async Task<IBaseResponse<H>> Login(T model)
        {
            try
            {
                // Получаем пользователя из базы данных по email
                var user = await _repositoryLogin.GetByEmailAsync(model.Email);
                if (Exist<BaseEntity, BaseDTO, H>.EntityIsNotExist(user)) return new BaseResponse<H>()
                {
                    Description = "Пользователь с таким email not зарегистрирован."
                };

                // Проверяем, что пароль пользователя совпадает с введенным паролем
                if (HashPasswordHelper.HashPassword(user.Password) != HashPasswordHelper.HashPassword(model.Password)) return new BaseResponse<H>()
                {
                    Description = "Неправильный пароль."
                };

                return new BaseResponse<H>()
                {
                    Data = user
                };
            }
            catch (Exception e)
            {
                return new BaseResponse<H>() { Description = e.Message };
            }

        }
    }
}
