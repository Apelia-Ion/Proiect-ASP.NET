using RecipesApp.Models;
using System.Threading.Tasks;

namespace RecipesApp.Managers
{
    public interface IAuthenticationManager
    {
        Task Signup(SignupUserModel signupUserModel);
        Task<TokenModel> Login(LoginUserModel loginUserModel);
    }
}
