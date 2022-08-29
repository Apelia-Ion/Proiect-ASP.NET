using RecipesApp.Entities;
using System.Threading.Tasks;

namespace RecipesApp.Managers
{
    public interface ITokenManager
    {
        Task<string> CreateToken(User user);
    }
}
