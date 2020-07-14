using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IHotelEmployeeData
    {
        Task DeleteEmployee(HotelEmployeeModel employee);
        Task<List<HotelEmployeeModel>> GetHotelEmployees();
        Task InsertEmployee(HotelEmployeeModel employee);
        Task UpdateEmployee(HotelEmployeeModel employee);
    }
}