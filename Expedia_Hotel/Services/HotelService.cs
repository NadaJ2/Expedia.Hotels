using System;
using System.Net.Http;
using System.Text;
using Expedia_Hotel.Models;
using Newtonsoft.Json;

namespace Expedia_Hotel.Services {
    public class HotelService : IHotelService {
        private readonly string baseUrl = "https://offersvc.expedia.com/offers/v2/getOffers?scenario=deal-finder&page=foo&uid=foo&productType=Hotel";

        public ResponseHotel GetHotelOffer(RequestHotel request) {
            using (var httpClient = new HttpClient()) {

                var response = httpClient.GetStringAsync(new Uri(baseUrl)).Result;
                var responseHotel = JsonConvert.DeserializeObject<ResponseHotel>(response);
                return responseHotel;
            }
        }

        private string BuildRestRequestParam(RequestHotel request) {

            var requestUrl = new StringBuilder(baseUrl);

            if (!String.IsNullOrWhiteSpace(request.DestinationName)) {
                requestUrl.Append("&destinationName=" + request.DestinationName);
            }
            if (!String.IsNullOrWhiteSpace(request.DestinationCity)) {
                requestUrl.Append("&destinationCity=" + request.DestinationCity);
            }
            if (!String.IsNullOrWhiteSpace(request.MinTripStartDate)) {
                requestUrl.Append("&minTripStartDate=" + request.MinTripStartDate);
            }
            if (!String.IsNullOrWhiteSpace(request.MaxTripStartDate)) {
                requestUrl.Append("&maxTripStartDate=" + request.MaxTripStartDate);
            }
            if (!String.IsNullOrWhiteSpace(request.LengthOfStay)) {
                requestUrl.Append("&lengthOfStay=" + request.LengthOfStay);
            }
            if (!String.IsNullOrWhiteSpace(request.MaxStarRating)) {
                requestUrl.Append("&maxStarRating=" + request.MaxStarRating);
            }
            if (!String.IsNullOrWhiteSpace(request.MinStarRating)) {
                requestUrl.Append("&minStarRating=" + request.MinStarRating);
            }
            if (!String.IsNullOrWhiteSpace(request.MaxTotalRate)) {
                requestUrl.Append("&maxTotalRate=" + request.MaxTotalRate);
            }
            if (!String.IsNullOrWhiteSpace(request.MinTotalRate)) {
                requestUrl.Append("&minTotalRate=" + request.MinTotalRate);
            }
            if (!String.IsNullOrWhiteSpace(request.MaxGuestRating)) {
                requestUrl.Append("&maxGuestRating=" + request.MaxGuestRating);
            }
            if (!String.IsNullOrWhiteSpace(request.MinGuestRating)) {
                requestUrl.Append("&minGuestRating=" + request.MinGuestRating);
            }

            return requestUrl.ToString();
        }
    }
}
