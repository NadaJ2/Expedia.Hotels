namespace Expedia_Hotel.Models
{
    public class ResponseHotel
    {
        public OfferInformation OfferInfo { get; set; }
        public UserInformation UserInfo { get; set; }
        public Offers Offers { get; set; }
    }
}
