

namespace Ustora.Core.Models
{
    public class Address :BaseClass
    {
       
     
        public string StreetName { get; set; }
      
        public string AreaName { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string FullAddress { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public string LandMark { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
    
        public Company Company { get; set; }
        [ForeignKey("Country")]
        public int CompanyId { get; set; }
        public virtual ICollection<City> Cities { get; set; } = new List<City>();
        public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
        public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    }
}
