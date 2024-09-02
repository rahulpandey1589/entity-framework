using EntityFramework.ViewModels;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class StudentController: ControllerBase{

   [HttpPost]
   public async Task<IActionResult> Post([FromBody] StudentViewModel students){
    return Ok();
   }

}