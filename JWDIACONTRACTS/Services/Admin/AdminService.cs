using JWDIACONTRACTS.Interfaces.Admin;
using JWDIACONTRACTS.DTO.Auth;
using JWDIADATA.Data.Entities;
using JWDIADATA.Data;
using JWDIACONTRACTS.Mappings.Auth;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using JWDIACONTRACTS.Mappings.Auth;

namespace JWDIACONTRACTS.Services.Admin;

public class AdminService: IAdminService
{
    
     private readonly ApplicationDbContext _context;

    public AdminService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<UserDTO>> GetUsersAsync(){
        List<UserDataModel> users = await _context.Users.ToListAsync();

        List<UserDTO> data = users.ConvertAll(new Converter<UserDataModel, UserDTO>(UserMappings.UserConverter));
        return data;
    }


    // manage user roles etc.. takes in username and role value then updates the role based on their username
}
