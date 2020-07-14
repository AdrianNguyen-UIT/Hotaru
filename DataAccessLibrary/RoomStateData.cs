using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class RoomStateData : IRoomStateData
    {
        private readonly ISqlDataAccess db;

        public RoomStateData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<RoomStateModel>> GetRoomStates()
        {
            string sql = "[dbo].[SelectAllRoomState]";
            return db.LoadData<RoomStateModel, dynamic>(sql, new { });
        }

        public Task InsertRoomState(RoomStateModel roomState)
        {
            string sql = "[dbo].[InsertRoomState] @RoomState_Name, @RoomState_Description, @RoomState_Marked, @Hotel_ID";

            return db.SaveData(sql, roomState);
        }

        public Task UpdateRoomState(RoomStateModel roomState)
        {
            string sql = "[dbo].[UpdateRoomState] @RoomState_ID, @RoomState_Name, @RoomState_Description, @RoomState_Marked, @Hotel_ID";

            return db.SaveData(sql, roomState);
        }

        public Task DeleteRoomState(RoomStateModel roomState)
        {
            string sql = "[dbo].[DeleteRoomState] @RoomState_ID";

            return db.SaveData(sql, roomState);
        }
    }
}
