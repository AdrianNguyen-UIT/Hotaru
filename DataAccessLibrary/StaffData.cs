using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class StaffData : IStaffData
    {
        private readonly ISqlDataAccess db;

        public StaffData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<StaffModel>> GetStaffs()
        {
            string sql = "[dbo].[SelectAllStaff]";

            return db.LoadData<StaffModel, dynamic>(sql, new { });
        }

        public Task InsertStaff(StaffModel staff)
        {
            string sql = "[dbo].[InsertStaff] @User_FirstName, @User_LastName, @User_PhoneNumber, @User_EmailAddress, @User_Gender, @User_Birthday";

            return db.SaveData(sql, staff);
        }

        public Task UpdateStaff(StaffModel staff)
        {
            string sql = "[dbo].[UpdateStaff] @User_ID, @User_FirstName, @User_LastName, @User_PhoneNumber, @User_EmailAddress, @User_Gender, @User_Birthday";

            return db.SaveData(sql, staff);
        }

        public Task DeleteStaff(StaffModel staff)
        {
            string sql = "[dbo].[DeleteStaff] @User_ID";

            return db.SaveData(sql, staff);
        }
    }
}
