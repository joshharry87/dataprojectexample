using System.Collections.Generic;
using System.Threading.Tasks;
using JWDIADATA.Data.Entities;

public interface IWeatherDataService
{
    Task<IEnumerable<WeatherDataModel>> GetAllWeatherDataAsync();
}