
using Microsoft.AspNetCore.Mvc;

using JWDIACONTRACTS.DTO.Auth;

using JWDIACONTRACTS.Interfaces.Auth;



namespace JWDIAPI.Controllers.Auth;


[Route("api/[controller]")]
[ApiController]
public class AuthController : BaseApiController
{
    
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }
    [HttpGet]
    public IActionResult Get(){
        return Ok("Im a thing");
    }
    
    [HttpPost]
    public async Task<ActionResult<UserDTO>> CreateNewUser(NewUser newUser){

        var user = await _authService.CreateUserAsync(newUser);
        if (user == null){
            return BadRequest("Nope");
        }
        else{
            return Ok(user);
        } 
    }

    
}
