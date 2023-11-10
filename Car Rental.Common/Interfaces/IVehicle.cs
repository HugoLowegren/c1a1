using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces
{
    public interface IVehicle
    {
        string RegNo { get; set; }
        string Make { get; set; }
        int Odometer { get; set; }
        double CostKm { get; set; }
        int CostPerDay { get; set; }
        VehicleTypes VehicleType { get; set; }
        VehicleStatuses Status { get; set; }
    }
}
