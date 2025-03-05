
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JWDIADATA.Data.Entities;
using JWDIADATA.Data;
using JWDIACONTRACTS.Interfaces.GeoSurvey;
using dataintegrationexample;


namespace JWDIACONTRACTS.Services.GeoSurvey;
public class GeoSurveyService: IGeoSurveyService
{
    private readonly ApplicationDbContext _context;

    public GeoSurveyService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<GeochemSurveyDataModel>> GetAllGeoSurveyDataAsync()
    {
        return await _context.GeochemSurveyDataModels.ToListAsync();
    }
    

    // Add in search conditions etc. 
}
