using System.Collections.Generic;

namespace Modelpage.Models
{   
    public class CarModel
    {
        public int ModelId { get; set; }
        public int VersionId { get; set; }
        public string ModelName { get; set; }
        public string VersionName { get; set; }
        public ushort Rate {get ; set;}
        public int ReviewCount { get; set; }
        public int AveragePrice {get; set;}
        public string ImageUrl {get;set;}
        public IEnumerable<CityModel> CityList {get; set;}
        public IEnumerable<VersionPriceModel> VersionPriceList {get;set;}
    }
}