using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess db;

        public UserData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<UserModel>> GetUsers()
        {
            string sql = "[dbo].[SelectAllUser]";

            return db.LoadData<UserModel, dynamic>(sql, new { });
        }

        public Task InsertUser(UserModel user)
        {
            string sql = "[dbo].[InsertUser] @User_FirstName, @User_LastName, @User_PhoneNumber, @User_EmailAddress, @User_Gender, @User_Birthday";

            return db.SaveData(sql, user);
        }

        public Task UpdateUser(UserModel user)
        {
            string sql = "[dbo].[UpdateUser] @User_ID, @User_FirstName, @User_LastName, @User_PhoneNumber, @User_EmailAddress, @User_Gender, @User_Birthday";

            return db.SaveData(sql, user);
        }

        public Task DeleteUser(UserModel user)
        {
            string sql = "[dbo].[DeleteUser] @User_ID";

            return db.SaveData(sql, user);
        }
    }
}
