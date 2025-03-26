using System;
using System.ComponentModel.DataAnnotations;


namespace JWDIACONTRACTS.DTO.Auth;
public class NewUser
{
    

    [Required]
    public required string Username {get; set;}


    [Required]
    public required string Password {get; set;}


    [Required]
    [EmailAddress]
    public required string RequireUniqueEmail {get; set;}
    
}
