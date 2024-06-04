using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FizzBuzzController : ControllerBase
{
   [HttpGet(Name = "fizzbuzz/{input:int}")]
   public string Fizz(int input)
   {
      if (input % 3 == 0 && input % 5 == 0)
      {
         return "FizzBuzz";
      }
      else if (input % 3 == 0)
      {
         return "Fizz";
      }
      else if (input % 5 == 0)
      {
         return "Buzz";
      }
      else
      {
         return input.ToString();
      }
   }
}
