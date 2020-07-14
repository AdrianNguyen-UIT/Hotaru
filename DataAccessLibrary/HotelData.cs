using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class HotelData : IHotelData
    {
        private readonly ISqlDataAccess db;

        public HotelData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<HotelModel>> GetHotels()
        {
            string sql = "[dbo].[SelectAllHotel]";

            return db.LoadData<HotelModel, dynamic>(sql, new { });
        }

        public Task InsertHotel(HotelModel hotel)
        {
            string sql = "[dbo].[InsertHotel] @Hotel_Name, @Hotel_Location, @Hotel_PhoneNumber, @Hotel_EmailAddress, @Hotel_Description";

            return db.SaveData(sql, hotel);
        }

        public Task UpdateHotel(HotelModel hotel)
        {
            string sql = "[dbo].[UpdateHotel] @Hotel_ID, @Hotel_Name, @Hotel_Location, @Hotel_PhoneNumber, @Hotel_EmailAddress, @Hotel_Description";

            return db.SaveData(sql, hotel);
        }

        public Task DeleteHotel(HotelModel hotel)
        {
            string sql = "[dbo].[DeleteHotel] @Hotel_ID";

            return db.SaveData(sql, hotel);
        }
    }
}
