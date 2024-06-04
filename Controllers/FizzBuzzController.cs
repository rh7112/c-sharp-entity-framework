using FizzBuzzApiEF;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FizzBuzzController : ControllerBase
{
   private readonly ILogger<FizzBuzzController> _logger;
   private readonly FizzBuzzContext _context;
   public FizzBuzzController(FizzBuzzContext context, ILogger<FizzBuzzController> logger)
   {
      _context = context;
      _logger = logger;
   }

   [HttpGet("get/{id:int}")]
   public string get(int id)
   {
      var model = _context.Items.FirstOrDefault(m => m.inputValue == id);
      if (model == null || model.outputValue == null)
      {
         return "Not found";
      }
      return model.outputValue;
   }

   [HttpPost("post/{newInputValue:int}/{newOutputValue}")]
   public string Post(int newInputValue, string newOutputValue)
   {
      var model = new FizzBuzzItem() { inputValue = newInputValue, outputValue = newOutputValue };
      _context.Items.Add(model);
      _context.SaveChanges();

      return "It worked";
   }


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