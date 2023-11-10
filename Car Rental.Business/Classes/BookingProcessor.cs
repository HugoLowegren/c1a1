using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;
using Car_Rental.Common.Enums;

namespace Car_Rental.Business.Classes
{
    public class BookingProcessor
    {
        private readonly IData _db;

        public BookingProcessor(IData db) => _db = db;

        public IEnumerable<IPerson> GetCustomers() => _db.GetCustomers();

        public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) => _db.GetVehicles(status);

        public IEnumerable<IBooking> GetBookings() => _db.GetBookings();
        
        public static double GetTotalCost(IBooking booking,IVehicle vehicle)
        {
            int DaysRented = (booking.DaysRented > 0) ? booking.DaysRented : 1;
            int km = booking.KmAtReturn - booking.KmAtRent;
            var cost = (DaysRented * vehicle.CostPerDay) + (km * vehicle.CostKm);

            return cost;
        }
    }
}
