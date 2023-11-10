using Car_Rental.Common.Interfaces;
using Car_Rental.Common.Enums;

namespace Car_Rental.Data.Interfaces
{
    public interface IData
    {
        IEnumerable<IPerson> GetCustomers();
        IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default);
        IEnumerable<IBooking> GetBookings();
    }
}
