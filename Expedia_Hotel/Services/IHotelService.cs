using Expedia_Hotel.Models;

namespace Expedia_Hotel.Services
{
    public interface IHotelService
    {
        ResponseHotel GetHotelOffer(RequestHotel request);
    }
}
