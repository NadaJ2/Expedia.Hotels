namespace Expedia_Hotel.Models
{
    public class Hotel
    {
        public OfferDateRange OfferDateRange { get; set; }
        public Destination Destination { get; set; }
        public HotelInformation HotelInfo { get; set; }
        public HotelPricingInformation HotelPricingInfo { get; set; }
        public HotelUrls HotelUrls { get; set; }
    }
}
