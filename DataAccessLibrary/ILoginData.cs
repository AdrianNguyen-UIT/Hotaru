using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ILoginData
    {
        Task DeleteLogin(LoginModel login);
        Task<List<LoginModel>> GetLogins();
        Task InsertLogin(LoginModel login);
        Task UpdateLogin(LoginModel login);
    }
}