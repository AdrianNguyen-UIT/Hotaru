using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IUserData
    {
        Task DeleteUser(UserModel user);
        Task<List<UserModel>> GetUsers();
        Task InsertUser(UserModel user);
        Task UpdateUser(UserModel user);
    }
}