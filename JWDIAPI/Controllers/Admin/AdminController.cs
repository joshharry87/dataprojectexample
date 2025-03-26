
using Microsoft.AspNetCore.Mvc;

using JWDIACONTRACTS.DTO.Auth;
using JWDIACONTRACTS.Interfaces.Admin;


namespace JWDIAPI.Controllers.Admin;


[Route("api/[controller]")]
[ApiController]
public class AdminController: BaseApiController
{
     private readonly IAdminService _adminService;

    public AdminController(IAdminService adminService)
    {
        _adminService = adminService;
    }

    [HttpGet]
    public async Task<ActionResult<List<UserDTO>>> Get(){

        var result = await _adminService.GetUsersAsync();

        return Ok(result);
    }

}
