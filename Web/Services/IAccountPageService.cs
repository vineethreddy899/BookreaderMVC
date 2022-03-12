using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public interface IAccountPageService
    {
        Task<IdentityResult> CreateUser(SignUpModel signUpViewModel);
        Task<SignInResult> LoginUser(LoginModel loginViewModel);
        Task SignOut();
    }
}