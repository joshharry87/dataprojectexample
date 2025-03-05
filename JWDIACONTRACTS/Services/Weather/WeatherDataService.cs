// Services/WeatherDataService.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JWDIADATA.Data.Entities;
using JWDIADATA.Data;
using JWDIACONTRACTS.Interfaces.Weather;

namespace JWDIACONTRACTS.Services.Weather;

public class WeatherDataService : IWeatherDataService
{
    private readonly ApplicationDbContext _context;

    public WeatherDataService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<WeatherDataModel>> GetAllWeatherDataAsync()
    {
        return await _context.WeatherDataModels.ToListAsync();
    }
}
