using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ImageData : IImageData
    {
        private readonly ISqlDataAccess db;

        public ImageData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<ImageModel>> GetImages()
        {
            string sql = "[dbo].[SelectAllImage]";
            return db.LoadData<ImageModel, dynamic>(sql, new { });
        }

        public Task InsertImage(ImageModel image)
        {
            string sql = "[dbo].[InsertImage] @Hotel_ID, @HotelImage_Source";

            return db.SaveData(sql, image);
        }

        public Task UpdateImage(ImageModel image)
        {
            string sql = "[dbo].[UpdateImage] @HotelImage_ID, @HotelImage_Source";

            return db.SaveData(sql, image);
        }

        public Task DeleteImage(ImageModel image)
        {
            string sql = "[dbo].[DeleteImage] @HotelImage_ID";

            return db.SaveData(sql, image);
        }
    }
}
