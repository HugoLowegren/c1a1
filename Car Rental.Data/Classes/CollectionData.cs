using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Data.Classes
{
    public class CollectionData : IData
    {

        private readonly List<IPerson> _customers = new();
        private readonly List<IBooking> _bookings = new();
        private readonly List<IVehicle> _vehicles = new();

        public CollectionData() => SeedData();

        public IEnumerable<IPerson> GetCustomers() => _customers;
        public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) => _vehicles;
        public IEnumerable<IBooking> GetBookings() => _bookings;

        private void SeedData()
        {
            _customers.AddRange(new List<IPerson>
            {
                new Customer { SSN="12345",FirstName="John",LastName="Doe"},
                new Customer { SSN="98765",FirstName="Jane",LastName="Doe"}
            });

            _bookings.AddRange(new List<IBooking>
            {
                new Booking {RegNo="GHI789",Customer="Doe John (12345)",KmAtRent=1000,RentedAt= new DateTime(2023,9,20,12,0,0,0),},
                new Booking {RegNo="JKL012",Customer="Doe Jane (98765)",KmAtRent=5000,KmAtReturn=5000,RentedAt= new DateTime(2023,9,20,12,0,0,0),ReturnedAt=new DateTime(2023,9,20,13,0,0,0)},
            });

            _vehicles.AddRange(new List<IVehicle>
            {
                new Car {RegNo="ABC123",Make="Volvo",Odometer=10000,CostKm=1.0,CostPerDay=200,VehicleType=VehicleTypes.Combi},
                new Car {RegNo="DEF456",Make="Saab",Odometer=20000,CostKm=1.0,CostPerDay=100,VehicleType=VehicleTypes.Sedan},
                new Car {RegNo="GHI789",Make="Tesla",Odometer=1000,CostKm=3.0,CostPerDay=100,VehicleType=VehicleTypes.Van,Status=VehicleStatuses.Booked},
                new Car {RegNo="JKL012",Make="Jeep",Odometer=5000,CostKm=1.5,CostPerDay=300,VehicleType=VehicleTypes.Van},
                new Motorcycle {RegNo="MNO234",Make="Yamaha",Odometer=30000,CostKm=0.5,CostPerDay=50}
            });
        }


    }
}
