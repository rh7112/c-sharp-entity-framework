using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MathController : ControllerBase
{
   [HttpGet(Name = "double/{input:int}")]
   public int Double(int input) 
   {
      return input * 2;
   }
}
