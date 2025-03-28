
using System.Runtime.CompilerServices;
using System;
using JWDIACONTRACTS.DTO.Auth;

namespace JWDIACONTRACTS.Interfaces.Auth;
public interface IAuthService
{
    Task<UserDTO> CreateUserAsync (NewUser user);
    Task<string> LoginAsync (Login userLogin);
    
}
