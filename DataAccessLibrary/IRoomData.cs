using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IRoomData
    {
        Task DeleteRoom(RoomModel room);
        Task<List<RoomModel>> GetRooms();
        Task InsertRoom(RoomModel room);
        Task UpdateRoom(RoomModel room);
    }
}