using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class RoomData : IRoomData
    {
        private readonly ISqlDataAccess db;

        public RoomData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<RoomModel>> GetRooms()
        {
            string sql = "[dbo].[SelectAllRoom]";
            return db.LoadData<RoomModel, dynamic>(sql, new { });
        }

        public Task InsertRoom(RoomModel room)
        {
            string sql = "[dbo].[InsertRoom] @Room_Number, @RoomType_ID, @RoomState_ID";

            return db.SaveData(sql, room);
        }

        public Task UpdateRoom(RoomModel room)
        {
            string sql = "[dbo].[UpdateRoom] @Room_ID, @Room_Number, @RoomType_ID, @RoomState_ID";

            return db.SaveData(sql, room);
        }

        public Task DeleteRoom(RoomModel room)
        {
            string sql = "[dbo].[DeleteRoom] @Room_ID";

            return db.SaveData(sql, room);
        }
    }
}
