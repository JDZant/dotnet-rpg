using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
  public class CharacterController : ControllerBase
  {
      private static CharacterController knight = new CharacterController();
  }
}