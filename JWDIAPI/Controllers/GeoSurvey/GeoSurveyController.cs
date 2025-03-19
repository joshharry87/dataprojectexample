using Microsoft.AspNetCore.Mvc;

using JWDIACONTRACTS.Interfaces.GeoSurvey;
using JWDIACONTRACTS.DTO.GeoSurveyDTO;



namespace JWDIAPI.Controllers.GeoSurvey;


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
    public async Task<ActionResult<List<GeochemSurvey>>> GetAllGeoSurveyDataAsync()
    {
        var geoSurveyData = await _geoSurveyService.GetAllGeoSurveyDataAsync();
        return Ok(geoSurveyData);
    }
    
    [HttpGet]
    public async Task<ActionResult<List<GeoChemTopElementLocations>>> GetAllGeoSurveyLocationsByElementAsync(string element){
        
        var geoSurveyData = await _geoSurveyService.GetAllGeoSurveyLocationsByElementAsync(element);
        return Ok(geoSurveyData);
    }

    [HttpGet]
    public async Task<ActionResult<List<string>>> GetAllUniqueElementsAsync(){
        
        var geoSurveyData = await _geoSurveyService.GetAllUniqueElementsAsync();
        return Ok(geoSurveyData);
    }




    
}
