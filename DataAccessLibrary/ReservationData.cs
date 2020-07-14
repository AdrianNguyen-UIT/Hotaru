using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ReservationData : IReservationData
    {
        private readonly ISqlDataAccess db;

        public ReservationData(ISqlDataAccess db)
        {
            this.db = db;
        }
        public Task<List<ReservationModel>> GetReservations()
        {
            string sql = "[dbo].[SelectAllReservation]";
            return db.LoadData<ReservationModel, dynamic>(sql, new { });
        }

        public Task InsertReservation(ReservationModel reservation)
        {
            string sql = "[dbo].[InsertReservation] @Reservation_ReserveDate, @Reservation_StartDate, @Reservation_EndDate, @Room_ID, @User_ID, @Reservation_Description";

            return db.SaveData(sql, reservation);
        }

        public Task UpdateReservation(ReservationModel reservation)
        {
            string sql = "[dbo].[UpdateReservation] @Reservation_ID, @Reservation_ReserveDate, @Reservation_StartDate, @Reservation_EndDate, @Room_ID, @User_ID, @Reservation_Description";

            return db.SaveData(sql, reservation);
        }

        public Task DeleteReservation(ReservationModel reservation)
        {
            string sql = "[dbo].[DeleteReservation] @Reservation_ID";

            return db.SaveData(sql, reservation);
        }
    }
}
