using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IStaffData
    {
        Task DeleteStaff(StaffModel staff);
        Task<List<StaffModel>> GetStaffs();
        Task InsertStaff(StaffModel staff);
        Task UpdateStaff(StaffModel staff);
    }
}