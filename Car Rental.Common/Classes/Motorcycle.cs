using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes
{
    public class Motorcycle : IVehicle
    {
        public string RegNo { get; set; } = string.Empty;
        public string Make { get; set; } = string.Empty;
        public int Odometer { get; set; }
        public double CostKm { get; set; }
        public int CostPerDay { get; set; }
        public VehicleTypes VehicleType { get; set;  } = VehicleTypes.Motorcycle;
        public VehicleStatuses Status { get; set; } = VehicleStatuses.Available;
    }
}
