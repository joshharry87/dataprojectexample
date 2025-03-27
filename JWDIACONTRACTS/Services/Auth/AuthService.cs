using System;
using JWDIACONTRACTS.Interfaces.Auth;
using JWDIACONTRACTS.DTO.Auth;
using JWDIADATA.Data.Entities;
using JWDIADATA.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
// using System.IdentityModel.Tokens.JWT;
using JWDIACONTRACTS.Mappings.Auth;


namespace JWDIACONTRACTS.Services.Auth;
public class AuthService : IAuthService
{
    private readonly ApplicationDbContext _context;

    public AuthService(ApplicationDbContext context)
    {
        _context = context;
    }


    public async Task<UserDTO> CreateUserAsync (NewUser userIn) {

        UserDataModel user = new UserDataModel(){
            Username = userIn.Username,
            Password = userIn.Password, 
            RequireUniqueEmail = userIn.RequireUniqueEmail,
            Role = "User"
        };
 
        // hash the password

        UserDataModel checkUser = await _context.Users.SingleOrDefaultAsync(u => u.Username == userIn.Username);
        
        if (checkUser == null){
            _context.Users.Add(user);
            _context.SaveChanges();
            return new UserDTO(){
                Id = user.Id,
                Username = user.Username,
                Password = userIn.Password, 
                RequireUniqueEmail = userIn.RequireUniqueEmail,
                Role = user.Role
            };
        }
        else {
            return null;
        }

    }


    public async Task<string> LoginAsync (Login userLogin) {

        // hash password
        // check exists
        // create a token
        // return the token

        return null ;
    }



    private async Task<string> CreateToken (UserDTO user) {


        return "I am a token";
    }
    
}
