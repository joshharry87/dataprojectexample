

using JWDIACONTRACTS.DTO.GeoSurveyDTO;

namespace JWDIACONTRACTS.Interfaces.GeoSurvey;

public interface IGeoSurveyService
{
    Task<List<GeochemSurvey>> GetAllGeoSurveyDataAsync();
    
    Task<List<GeoChemTopElementLocations>> GetAllGeoSurveyLocationsByElementAsync(string element);

    Task<List<string>> GetAllUniqueElementsAsync ();

}

