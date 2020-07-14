using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IReservationData
    {
        Task DeleteReservation(ReservationModel reservation);
        Task<List<ReservationModel>> GetReservations();
        Task InsertReservation(ReservationModel reservation);
        Task UpdateReservation(ReservationModel reservation);
    }
}