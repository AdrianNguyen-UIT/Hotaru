using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IManagerData
    {
        Task DeleteManager(ManagerModel manager);
        Task<List<ManagerModel>> GetManagers();
        Task InsertManager(ManagerModel manager);
        Task UpdateManager(ManagerModel manager);
    }
}