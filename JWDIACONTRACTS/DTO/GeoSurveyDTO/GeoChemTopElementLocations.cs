namespace JWDIACONTRACTS.DTO.GeoSurveyDTO;

public class GeoChemTopElementLocations
{
    public string? SampleID {get; set;}
    public int? Gswano {get; set;}
    public DateTime? ExtractionDate {get; set;}
    public string? BatchNo {get; set;}
    public decimal? DLat {get; set;}
    public decimal? DLong {get; set;}
    public string? Reliability {get; set;}
    public string? SampleType {get; set;}
    public string? Lithname {get; set;}
    public string? Sitend {get; set;} 
    public string? allPresentElements {get; set;}

}
