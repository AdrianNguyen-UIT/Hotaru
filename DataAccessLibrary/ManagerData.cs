using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ManagerData : IManagerData
    {
        private readonly ISqlDataAccess db;

        public ManagerData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<ManagerModel>> GetManagers()
        {
            string sql = "[dbo].[SelectAllManager]";

            return db.LoadData<ManagerModel, dynamic>(sql, new { });
        }

        public Task InsertManager(ManagerModel manager)
        {
            string sql = "[dbo].[InsertManager] @User_FirstName, @User_LastName, @User_PhoneNumber, @User_EmailAddress, @User_Gender, @User_Birthday";

            return db.SaveData(sql, manager);
        }

        public Task UpdateManager(ManagerModel manager)
        {
            string sql = "[dbo].[UpdateManager] @User_ID, @User_FirstName, @User_LastName, @User_PhoneNumber, @User_EmailAddress, @User_Gender, @User_Birthday";

            return db.SaveData(sql, manager);
        }

        public Task DeleteManager(ManagerModel manager)
        {
            string sql = "[dbo].[DeleteManager] @User_ID";

            return db.SaveData(sql, manager);
        }
    }
}
