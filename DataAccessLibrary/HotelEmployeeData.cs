using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class HotelEmployeeData : IHotelEmployeeData
    {
        private readonly ISqlDataAccess db;

        public HotelEmployeeData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<HotelEmployeeModel>> GetHotelEmployees()
        {
            string sql = "[dbo].[SelectAllEmployee]";
            return db.LoadData<HotelEmployeeModel, dynamic>(sql, new { });
        }

        public Task InsertEmployee(HotelEmployeeModel employee)
        {
            string sql = "[dbo].[InsertEmployee] @Hotel_ID, @User_ID";

            return db.SaveData(sql, employee);
        }

        public Task UpdateEmployee(HotelEmployeeModel employee)
        {
            string sql = "[dbo].[UpdateEmployee] @Hotel_ID, @User_ID";

            return db.SaveData(sql, employee);
        }

        public Task DeleteEmployee(HotelEmployeeModel employee)
        {
            string sql = "[dbo].[DeleteEmployee] @Hotel_ID, @User_ID";

            return db.SaveData(sql, employee);
        }
    }
}
