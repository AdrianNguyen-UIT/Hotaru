using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class RoomTypeData : IRoomTypeData
    {
        private readonly ISqlDataAccess db;

        public RoomTypeData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<RoomTypeModel>> GetRoomTypes()
        {
            string sql = "[dbo].[SelectAllRoomType]";
            return db.LoadData<RoomTypeModel, dynamic>(sql, new { });
        }

        public Task InsertRoomType(RoomTypeModel roomType)
        {
            string sql = "[dbo].[InsertRoomType] @RoomType_Name, @RoomType_BedType, @RoomType_NumberOfBed, @RoomType_Capacity, @RoomType_Price, @Hotel_ID";

            return db.SaveData(sql, roomType);
        }

        public Task UpdateRoomType(RoomTypeModel roomType)
        {
            string sql = "[dbo].[UpdateRoomType] @RoomType_ID, @RoomType_Name, @RoomType_BedType, @RoomType_NumberOfBed, @RoomType_Capacity, @RoomType_Price, @Hotel_ID";

            return db.SaveData(sql, roomType);
        }

        public Task DeleteRoomType(RoomTypeModel roomType)
        {
            string sql = "[dbo].[DeleteRoomType] @RoomType_ID";

            return db.SaveData(sql, roomType);
        }
    }
}
