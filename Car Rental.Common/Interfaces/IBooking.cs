
namespace Car_Rental.Common.Interfaces
{
    public interface IBooking
    {
        string RegNo { get; set; }
        string Customer { get; set; }
        int KmAtRent {  get; set; }
        int KmAtReturn {  get; set; }
        DateTime RentedAt {  get; set; }
        DateTime? ReturnedAt {  get; set; }
        int DaysRented { get; }
    }
}
