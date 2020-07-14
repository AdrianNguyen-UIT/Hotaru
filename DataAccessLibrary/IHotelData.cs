using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IHotelData
    {
        Task DeleteHotel(HotelModel hotel);
        Task<List<HotelModel>> GetHotels();
        Task InsertHotel(HotelModel hotel);
        Task UpdateHotel(HotelModel hotel);
    }
}