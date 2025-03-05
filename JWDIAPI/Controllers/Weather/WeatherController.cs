namespace dataintegrationexample;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JWDIAPI.Models;
using System.Collections.Generic;
using JWDIAPI.Controllers;
using System.Threading.Tasks;
using JWDIADATA.Data.Entities;
using JWDIACONTRACTS.Interfaces.Services.Weather


[Route("api/[controller]")]
[ApiController]
public class WeatherController : BaseApiController
{
    private readonly ILogger<HomeController> _logger;

    private readonly IWeatherDataService _weatherDataService;
    public WeatherController(IWeatherDataService weatherDataService)
    {
        _weatherDataService = weatherDataService;
    }


    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<WeatherDataModel>>> GetAllWeatherData()
    {
        var weatherData = await _weatherDataService.GetAllWeatherDataAsync();
        return Ok(weatherData);
    }


}
