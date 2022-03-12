using AutoMapper;
using Business.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Business.Repository;

namespace Web.Services
{
    public class AccountPageService : IAccountPageService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;

        public AccountPageService(IAccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }
        public async Task<IdentityResult> CreateUser(SignUpModel signUpModel)
        {

            // mapping from viewmodel to application model
            var mapped = _mapper.Map<SignUp>(signUpModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");

            ///calling application layer using mapped
            //outputting result in the same return type

            var entityDto = await _accountRepository.CreateUser(mapped);
            return entityDto;


        }

        public async Task<SignInResult> LoginUser(LoginModel loginModel)
        {
            // mapping from viewmodel to application model
            var mapped = _mapper.Map<Login>(loginModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");

            ///calling application layer using mapped
            //outputting result in the same return type
            var entityDto = await _accountRepository.LoginUser(mapped);
            return entityDto;

        }

        public async Task SignOut()
        {
            await _accountRepository.SignOut();
        }
    }
}
