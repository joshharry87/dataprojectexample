
using Microsoft.EntityFrameworkCore;
using System.Linq;
using JWDIADATA.Data.Entities;
using JWDIADATA.Data;
using JWDIACONTRACTS.DTO.GeoSurveyDTO;
using JWDIACONTRACTS.Interfaces.GeoSurvey;
using JWDIACONTRACTS.Mappings.GEoSurvey;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;


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

    public async Task<List<GeoChemTopElementLocations>> GetAllGeoSurveyLocationsByElementAsync(string element)
    {
        List<GeochemSurveyDataModel> list =  await _context.GeochemSurveyDataModels.Where(w => w.Top_1_Elements.Equals(element)).ToListAsync();
        List<GeoChemTopElementLocations> data = list.ConvertAll(new Converter<GeochemSurveyDataModel, GeoChemTopElementLocations>(GeoSurveyMappings.GeoChemLocationConverter));
        return data;
    }
    

    public async Task<List<string>> GetAllUniqueElementsAsync()
    {
        return  await _context.GeochemSurveyDataModels.DistinctBy(w => w.Top_1_Elements).SelectMany(w => 
    
                    new List<string> {w.Top_1_Elements}).ToListAsync();
    }
    


    // Add in search conditions etc. 
}
