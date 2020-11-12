using System;
using System.Collections.Generic;
using Dapper;
using Microsoft.Extensions.Configuration;
using modelpage.Data;
using Modelpage.Models;
using MySql.Data.MySqlClient;

namespace Modelpage.Data
{
    public class SqlCarModelRepo : DbConnectionRepo, ICarModelRepo
    {
        public SqlCarModelRepo(IConfiguration config) : base(config)
        {

        }

        public CarModel GetCarModelDetails(int modelId)
        {
            /* no proper data is available for car models in training db */
            CarModel carDetails = new CarModel{
                ModelName = "Maruti Suzuki",
                AveragePrice = 1503000,
                ReviewCount = 324,
                Rate = 4,
                ImageUrl = "https://imgd.aeplcdn.com/664x374/n/cw/ec/26742/swift-exterior-right-front-three-quarter-117655.gif?q=85"
            };
            carDetails.CityList = GetCityList();
            carDetails.VersionPriceList = GetVersionsPriceList(modelId);
            return carDetails;
        }

        public IEnumerable<CityModel> GetCityList()
        {
            List<CityModel> cityList = null;
            try
            {
                using(MySqlConnection conn = Connection)
                {
                    string query = @"SELECT id, city
                                    FROM cities";
                    var result = conn.Query<Cities>(query);
                    
                    cityList = new List<CityModel>();
                    
                    foreach(var city in result)
                    {
                        cityList.Add(new CityModel{
                            Id = city.Id,
                            Name= city.City
                        });
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cityList;
        }

        public IEnumerable<VersionPriceModel> GetVersionsPriceList(int modelId)
        {
            List<VersionPriceModel> versionPrices = null;
            try
            {
                using(MySqlConnection conn = Connection)
                {
                    string query = @"SELECT carId, carVersion, onRoadPrice
                                    FROM carversion
                                    WHERE carId = @modelId";

                    var result = conn.Query<Carversion>(query, new{
                        modelId = modelId
                    });
                
                    versionPrices = new List<VersionPriceModel>();

                    foreach(var version in result)
                    {
                        versionPrices.Add(
                            new VersionPriceModel{
                                ModelId = version.CarId,
                                VersionName = version.CarVersion,
                                Price = version.OnRoadPrice
                            }
                        );
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return versionPrices;
        }
    }
}