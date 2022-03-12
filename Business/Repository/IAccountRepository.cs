using Business.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Business.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUser(SignUp userSignUp);
        Task<SignInResult> LoginUser(Login user);
        Task SignOut();
    }
}