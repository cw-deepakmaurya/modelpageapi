using System.Collections.Generic;
using System.Threading.Tasks;
using Modelpage.Models;

namespace Modelpage.Data
{
    public class CarModelRepoMock : ICarModelRepo
    {
        public CarModel GetCarModelDetails(int modelId)
        {
            CarModel carDetails = new CarModel{
                ModelId = modelId,
                ModelName = "Maruti Suzuki",
                VersionId = 1,
                VersionName = "MSV1",
                AveragePrice = 1503000,
                ImageUrl = "https://imgd.aeplcdn.com/664x374/n/cw/ec/26742/swift-exterior-right-front-three-quarter-117655.gif?q=85"
            };
            return carDetails;
        }

        public IEnumerable<CityModel> GetCityList()
        {
            var cityList = new List<CityModel>
            {   
               new CityModel{ Id = 1, Name="Mumbai"},
               new CityModel{ Id = 2, Name="Bangalore"}, 
               new CityModel{ Id = 3, Name="Chennai"}, 
               new CityModel{ Id = 4, Name="Kolkata"}, 
               new CityModel{ Id = 5, Name="Delhi"}, 
               new CityModel{ Id = 6, Name="Pune"}, 
            };
            return cityList;
        }

        public IEnumerable<VersionPriceModel> GetVersionsPriceList(int modelId)
        {
            var versionPriceList = new List<VersionPriceModel>{
                new VersionPriceModel{ ModelId = 1, VersionName = "LXI", Price=66200},
                new VersionPriceModel{ ModelId = 1, VersionName = "VXI", Price=73200},
                new VersionPriceModel{ ModelId = 1, VersionName = "VXI AMT", Price=68200},
                new VersionPriceModel{ ModelId = 1, VersionName = "ZXI", Price=86200},
                new VersionPriceModel{ ModelId = 1, VersionName = "ZXI AMT", Price=96200},
            };
            return versionPriceList;
        }
    }
}