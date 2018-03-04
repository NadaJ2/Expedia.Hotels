namespace Expedia_Hotel.Models
{
    public class RequestHotel
    {
        public string DestinationName { get; set; }
        public string DestinationCity { get; set; }
        public string MinTripStartDate { get; set; } //2017-05-03
        public string MaxTripStartDate { get; set; }
        public string LengthOfStay { get; set; }
        public string MaxStarRating { get; set; }
        public string MinStarRating { get; set; }
        public string MaxTotalRate { get; set; }
        public string MinTotalRate { get; set; }
        public string MaxGuestRating { get; set; }
        public string MinGuestRating { get; set; }
    }
}
