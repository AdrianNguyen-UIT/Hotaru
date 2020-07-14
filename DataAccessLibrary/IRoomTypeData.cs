using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IRoomTypeData
    {
        Task DeleteRoomType(RoomTypeModel roomType);
        Task<List<RoomTypeModel>> GetRoomTypes();
        Task InsertRoomType(RoomTypeModel roomType);
        Task UpdateRoomType(RoomTypeModel roomType);
    }
}