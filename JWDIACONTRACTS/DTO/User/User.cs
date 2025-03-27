using System.ComponentModel.DataAnnotations;
using System;

namespace JWDIACONTRACTS.DTO.Auth;

public class UserDTO
{

    [Required]
    public required Guid Id {get; set;}

    [Required]
    public required string Username {get; set;}


    [Required]
    public required string Password {get; set;}


    [Required]
    [EmailAddress]
    public required string RequireUniqueEmail {get; set;}

    public string Role {get; set;}
    
}
