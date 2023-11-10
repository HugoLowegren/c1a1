using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes
{
    public class Booking : IBooking
    {
        public string RegNo { get; set; } = string.Empty;
        public string Customer { get; set; } = string.Empty;
        public int KmAtRent { get ; set ; }
        public int KmAtReturn { get ; set ; }
        public DateTime RentedAt { get ; set ; }
        public DateTime? ReturnedAt { get ; set ; }

        public int DaysRented
        {
            get
            {
                TimeSpan rentDuration = (ReturnedAt ?? DateTime.Now) - RentedAt;
                return rentDuration.Days;
            }
        }
    }
}
