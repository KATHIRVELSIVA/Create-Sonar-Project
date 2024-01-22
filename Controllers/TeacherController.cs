using Microsoft.AspNetCore.Mvc;
namespace Create.Controllers;
using Create.Data;
using Create.Models;
[ApiController]
public class TeacherController : ControllerBase
{
  private readonly Appdbcontext context;
  public TeacherController(Appdbcontext context)
  {
    this.context = context;
  }
  [Route("CreateTeacher")]
  [HttpPost]
  public async Task<IActionResult> CreateUser(TeacherModel teacher)
  {
    context.Add(teacher);
    await context.SaveChangesAsync();
    return Ok(teacher);
  }
}