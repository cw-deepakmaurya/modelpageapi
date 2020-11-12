using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Modelpage.Models;
using Modelpage.Data;

namespace ModelPage.Controllers
{
    [Route("api/modelpage")]
    [ApiController]
    public class ModelPageController : ControllerBase
    {
        private readonly ICarModelRepo _carModelRepo;

        public ModelPageController(ICarModelRepo carModelRepo)
        {
            _carModelRepo = carModelRepo;
        }

        // api/modelpage/1
        [HttpGet("{id}")]
        public ActionResult<CarModel> GetCarDetails(int Id)
        {
            var carDeatils = _carModelRepo.GetCarModelDetails(Id);
            return Ok(carDeatils);
        }

        [HttpGet("cities")]
        public ActionResult <IEnumerable<CityModel>> GetCities()
        {
            var cityList =  _carModelRepo.GetCityList();
            return Ok(cityList);
        }


        [HttpGet("versionsprice/{id}")]
        public ActionResult <IEnumerable<VersionPriceModel>> GetVersionsPrices(int Id)
        {
            var versionsPricesList = _carModelRepo.GetVersionsPriceList(Id);
            return Ok(versionsPricesList);
        }
    }
}