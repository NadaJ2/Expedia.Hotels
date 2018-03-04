using System;
using System.Collections.Generic;
using System.Linq;

namespace Expedia_Hotel.Models {
    public class OfferDateRange {
        public List<int> TravelStartDate { get; set; }//[2018,4,21]
        public List<int> TravelEndDate { get; set; }
        public int LengthOfStay { get; set; }

        public string StartDate {
            get {
                return ConvertListToDate(TravelStartDate)?.ToShortDateString();
            }
        }
        public string EndDate {
            get {
                return ConvertListToDate(TravelEndDate)?.ToShortDateString();
            }
        }

        private DateTime? ConvertListToDate(List<int> stringDate) {
            if (stringDate.Any()) {
                return new DateTime(stringDate[0], stringDate[1], stringDate[2]);
            }
            return null;
        }
    }
}