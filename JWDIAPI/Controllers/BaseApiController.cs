// Controllers/BaseApiController.cs

using Microsoft.AspNetCore.Mvc;

namespace JWDIAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public abstract class BaseApiController : ControllerBase
{
    // Generic method for handling OK responses
    protected ActionResult HandleSuccess<T>(T data)
    {
        return Ok(new 
        {
            Success = true,
            Data = data
        });
    }

    // Generic method for handling errors
    protected ActionResult HandleError(string errorMessage)
    {
        return BadRequest(new 
        {
            Success = false,
            Error = errorMessage
        });
    }
}
