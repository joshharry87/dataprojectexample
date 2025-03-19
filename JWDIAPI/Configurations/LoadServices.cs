using JWDIACONTRACTS.Services.Weather;
using JWDIACONTRACTS.Interfaces.Weather;
using JWDIACONTRACTS.Interfaces.GeoSurvey;
using JWDIACONTRACTS.Services.GeoSurvey;

// this should self generate reading by assembly and naming conventions
namespace JWDIAPI.Configurations
{
    public static class LoadServices
    {
        public static void LoadInCustomServices(IServiceCollection services)
        {
            services.AddScoped<IWeatherDataService, WeatherDataService>();
            services.AddScoped<IGeoSurveyService, GeoSurveyService>();
        }
    }
}
