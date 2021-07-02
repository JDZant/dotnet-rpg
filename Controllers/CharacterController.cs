using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;
using dotnet_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
  public class CharacterController : ControllerBase
  {
      private readonly ICharacterService _characterService;

      private static List<Character> characters = new()
      {
          new Character(),
          new Character(){ Id = 1, Name = "Sam" }
      };

      public CharacterController(ICharacterService characterService)
      {
          _characterService = characterService;
      }

      [HttpGet("GetAllCharacters")]
      public async Task<ActionResult<List<Character>>> GetAllCharacters()
      {
          return Ok(await _characterService.GetAllCharacters());
      }
      
      [HttpGet("GetCharacter/{id}")]
      public async Task<ActionResult<Character>> GetCharacter(int id)
      {
          return Ok(await _characterService.GetCharacterById(id));
      }

      [HttpPost("AddCharacter")]
      public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter)
      {
          return Ok(await _characterService.AddCharacter(newCharacter));
      }

  }
}