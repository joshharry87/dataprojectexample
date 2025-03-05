using System.Collections.Generic;
using System.Threading.Tasks;
using dataintegrationexample;
using JWDIADATA.Data.Entities;

namespace JWDIACONTRACTS.Interfaces.GeoSurvey;

public interface IGeoSurveyService
{
    Task<IEnumerable<GeochemSurveyDataModel>> GetAllGeoSurveyDataAsync();
}

