// Services/WeatherDataService.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JWDIADATA.Data.Entities;
using JWDIADATA.Data;
using JWDIACONTRACTS.Interface.Weather;

public class WeatherDataService : IWeatherDataService
{
    private readonly ApplicationDBContext _context;

    public WeatherDataService(WeatherDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<WeatherDataModel>> GetAllWeatherDataAsync()
    {
        return await _context.WeatherDataModels.ToListAsync();
    }
}
