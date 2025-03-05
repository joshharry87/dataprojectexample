using System.Collections.Generic;
using System.Threading.Tasks;
using JWDIADATA.Data.Entities;

namespace JWDIACONTRACTS.Interfaces.Weather;

public interface IWeatherDataService
{
    Task<IEnumerable<WeatherDataModel>> GetAllWeatherDataAsync();
}