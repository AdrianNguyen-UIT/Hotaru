using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IRoomStateData
    {
        Task DeleteRoomState(RoomStateModel roomState);
        Task<List<RoomStateModel>> GetRoomStates();
        Task InsertRoomState(RoomStateModel roomState);
        Task UpdateRoomState(RoomStateModel roomState);
    }
}