namespace Expedia_Hotel.Models
{
    public class Destination
    {
        public int RegionId { get; set; }
        public int AssociatedMultiCityRegionId { get; set; }
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string TLA { get; set; }
        public string NonLocalizedCity { get; set; }
    }
}
