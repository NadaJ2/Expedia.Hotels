using System;
using System.Diagnostics;
using Expedia_Hotel.Models;
using Expedia_Hotel.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Expedia_Hotel.Controllers {
    public class HotelController : Controller {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService) => _hotelService = hotelService;

        public IActionResult Hotel() {
            return View();
        }

        [HttpPost]
        public IActionResult GetOffer(RequestHotel data) {
            var result = _hotelService.GetHotelOffer(data);
            return PartialView(result);
        }

        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}