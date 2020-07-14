using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class LoginData : ILoginData
    {
        private readonly ISqlDataAccess db;

        public LoginData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<LoginModel>> GetLogins()
        {
            string sql = "[dbo].[SelectAllLogin]";

            return db.LoadData<LoginModel, dynamic>(sql, new { });
        }

        public Task InsertLogin(LoginModel login)
        {
            string sql = "[dbo].[InsertLogin] @Login_UserName, @Login_Password, @User_ID";

            return db.SaveData(sql, login);
        }

        public Task UpdateLogin(LoginModel login)
        {
            string sql = "[dbo].[UpdateLogin] @Login_UserName, @Login_Password";

            return db.SaveData(sql, login);
        }

        public Task DeleteLogin(LoginModel login)
        {
            string sql = "[dbo].[DeleteLogin] @Login_UserName, @User_ID";

            return db.SaveData(sql, login);
        }
    }
}
