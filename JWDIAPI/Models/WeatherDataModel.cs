// using ;
namespace JWDIAPI.Models;


public class WeatherDataModel
{
    public int? id { get; set; }
    // public System.DateTime  date {get; set;}
    public int? date_epoch {get; set;}
    public int? hour {get; set;}
    public decimal? maxtemp_c {get; set;}
    public decimal? maxtemp_f {get; set;}
    public decimal? mintemp_c {get; set;}
    public decimal? mintemp_f {get; set;}
    public decimal? avgtemp_c {get; set;}
    public decimal? avgtemp_f {get; set;}
    public decimal? maxwind_mph {get; set;}
    public decimal? maxwind_kph {get; set;}
    public decimal? totalprecip_mm {get; set;}
    public decimal? totalprecip_in {get; set;}
    public int? totalsnow_cm {get; set;}
    public int? avgvis_km {get; set;}
    public int? avgvis_miles {get; set;}
    public int? avghumidity {get; set;}
    public int? daily_will_it_rain {get; set;}
    public int? daily_chance_of_rain {get; set;}
    public int? daily_will_it_snow {get; set;}
    public int? daily_chance_of_snow {get; set;}
    public string? condition_text {get; set;}
    public string? condition_icon {get; set;}
    public int? condition_code {get; set;}
    public int? uv {get; set;}
    public int? sunrise {get; set;}
    public int? sunset {get; set;}
    public int? moonrise {get; set;}
    public int? moonset {get; set;}
    public string? moon_phase {get; set;}
    public int? moon_illumination {get; set;}

    
}
