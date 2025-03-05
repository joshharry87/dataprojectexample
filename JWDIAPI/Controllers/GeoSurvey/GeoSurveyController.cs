namespace dataintegrationexample;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JWDIAPI.Controllers;
using System.Threading.Tasks;

using JWDIACONTRACTS.Interfaces.GeoSurvey;

[Route("api/[controller]")]
[ApiController]
public class GeoSurveyController: BaseApiController
{
         private readonly IGeoSurveyService _geoSurveyService;
    public GeoSurveyController(IGeoSurveyService geoSurveyService)
    {
        _geoSurveyService = geoSurveyService;
    }


    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<GeochemSurveyDataModel>>> GetAllGeoSurveyDataAsync()
    {
        var geoSurveyData = await _geoSurveyService.GetAllGeoSurveyDataAsync();
        return Ok(geoSurveyData);
    }

    
}
