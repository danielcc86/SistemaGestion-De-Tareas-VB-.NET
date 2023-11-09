using Api_CRUD_GestionTareas.Data;
using Api_CRUD_GestionTareas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_CRUD_GestionTareas.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        [HttpPost("Crear")]
        public async Task<IActionResult> UsersCreate(UsersModel user)
        {
            return Ok(await Task.Run(()=> new UserData().CreateUser(user)));
        }

        [HttpGet("ValidacionUsuario")]
        public async Task<IActionResult> ValidateUser(string userName, string password)
        {
            int validation = await Task.Run(() => new UserData().ValidateUser(userName, password));
            var result = new
            {
                IsValid = (validation == 1), 
                ValidationValue = validation
            };
            return Ok(result);
        }
    }

    
}
