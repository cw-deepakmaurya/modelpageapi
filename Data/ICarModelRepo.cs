using System.Collections.Generic;
using System.Threading.Tasks;
using Modelpage.Models;

namespace Modelpage.Data
{
    public interface ICarModelRepo
    {
        CarModel GetCarModelDetails(int modelId);
        IEnumerable<CityModel> GetCityList();
        IEnumerable<VersionPriceModel> GetVersionsPriceList(int modelId);
    }
}