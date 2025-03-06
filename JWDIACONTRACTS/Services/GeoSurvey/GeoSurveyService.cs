
using Microsoft.EntityFrameworkCore;
using JWDIADATA.Data.Entities;
using JWDIADATA.Data;
using JWDIACONTRACTS.DTO.GeoSurveyDTO;
using JWDIACONTRACTS.Interfaces.GeoSurvey;
using JWDIACONTRACTS.Mappings.GEoSurvey;


namespace JWDIACONTRACTS.Services.GeoSurvey;
public class GeoSurveyService: IGeoSurveyService
{
    private readonly ApplicationDbContext _context;

    public GeoSurveyService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<GeochemSurvey>> GetAllGeoSurveyDataAsync()
    {
        List<GeochemSurveyDataModel> list =  await _context.GeochemSurveyDataModels.ToListAsync();
        List<GeochemSurvey> data = list.ConvertAll(new Converter<GeochemSurveyDataModel, GeochemSurvey>(GeoSurveyMappings.GeoChemConverter));
        return data;
    }
    

    // Add in search conditions etc. 
}
