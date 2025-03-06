

using JWDIACONTRACTS.DTO.GeoSurveyDTO;

namespace JWDIACONTRACTS.Interfaces.GeoSurvey;

public interface IGeoSurveyService
{
    Task<List<GeochemSurvey>> GetAllGeoSurveyDataAsync();
}

